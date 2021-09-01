using Edcore.GanttChart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Svg;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using System.Globalization;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils;
using DevExpress.XtraBars.ToolbarForm;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraEditors.Repository;

namespace MES
{
    public partial class MainForm : ToolbarForm
    {
        private ProjectManager m_Manager = null;
        private OverlayPainter m_Overlay = new OverlayPainter();

        private XtraForm dummyForm;

        private DevExpress.XtraGrid.Views.Card.CardView cardViewProductListing;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutViewProductListing;

        private int _SplitterX;
        private int _ScrollFix = 0;
        private bool _IsPanning = false;
        private bool _SearchMode = false;
        private int _ListY;
        private float _ChartY;
        private Task m_SelectedTask;
        private DataColumn m_SelectedTaskColumn;
        private bool _IsSearchScroll = false;
        private bool comboListingPopupActive = false;

        public MainForm()
        {
            InitializeComponent();

            // Create a Project
            m_Manager = new ProjectManager("256K DRAM 7월 진척현황");

            // Custom fields
            m_Manager.AddCustomField("Greeting", typeof(string), 80);
            m_Manager.AddCustomField("Cancelled", typeof(string), 80);
            m_Manager.AddCustomField("Important", typeof(bool), 80);

            // Add some events to event manager
            for (int i = 0; i < 3; i++)
            {
                PanelControl panel = new PanelControl();
                panel.Size = new Size(270, 70);

                LabelControl titleLabel = new LabelControl();
                titleLabel.Text = string.Format("Event #{0}: Hello world", i);
                titleLabel.Font = new Font(this.Font.FontFamily, 11f, FontStyle.Bold);
                titleLabel.Location = new Point(5, 5);
                panel.Controls.Add(titleLabel);

                LabelControl label = new LabelControl();
                label.Text = string.Format("Information about the event goes here");
                label.Font = new Font(this.Font.FontFamily, 9f, FontStyle.Regular);
                label.Location = new Point(5, 25);
                panel.Controls.Add(label);

                //eventManagerEventStackPanel1.Controls.Add(panel);
            }
            
            // Build tree for Overview
            IEnumerable<Task> tasks = m_Manager.RootTasks;
            foreach (Task task in tasks)
            {
                task.Children = m_Manager.DirectMembersOf(task);
                if (task.Children.Count() != 0)
                {
                    task.CanExpand = true;
                }
            }

            // Build tree for GanttChart
            ganttChartProductionMonitor.Init(m_Manager);
            ganttChartProductionMonitor.CreateTaskDelegate = delegate () { return new MyTask(m_Manager); };

            ganttChartChartSplitContainer.SplitterPosition = 400;

            treeListPMChartTreeList.DataSource = GetTasks();

            _FormatTreeList();

            treeListPMChartTreeList.RowHeight = ganttChartProductionMonitor.BarSpacing - 1;
            treeListPMChartTreeList.Columns.ElementAt(0).Width = 200;
            treeListPMChartTreeList.ExpandAll();

            // GanttChart event listeners
            //ganttChart.TaskMouseOver += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskMouseOver);
            //ganttChart.TaskMouseOut += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskMouseOut);
            ganttChartProductionMonitor.TaskSelected += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskSelected);
            ganttChartProductionMonitor.TaskDeselecting += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskDeselecting);
            ganttChartProductionMonitor.TaskMouseDoubleClick += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskMouseDoubleClick);
            m_Overlay.PrintMode = true;
            ganttChartProductionMonitor.PaintOverlay += m_Overlay.ChartOverlayPainter;
            ganttChartProductionMonitor.AllowTaskDragDrop = true;
            //m_Chart.Scroll += new ScrollEventHandler(m_Chart_Scroll);
            ganttChartProductionMonitor.MouseWheel += new MouseEventHandler(m_Chart_MouseWheel);
            ganttChartProductionMonitor.MousePan += new EventHandler<MousePanEventArgs>(m_Chart_MousePan);

            // Tasklist event listeners
            treeListPMChartTreeList.AfterExpand += new NodeEventHandler(m_TaskList_Expanded);
            treeListPMChartTreeList.AfterCollapse += new NodeEventHandler(m_TaskList_Collapsed);
            treeListPMChartTreeList.TopVisibleNodeIndexChanged += new EventHandler(gChartTreeList_TopVisibleIndexChanged);
            //gChartTreeList.BeforeExpand += new NodeEventHandler(m_TaskList_Expanding);
            //gChartTreeList.BeforeCollapse += new NodeEventHandler(m_TaskList_Collapsing);

            // BOM events
            searchControlBOM.EditValueChanged += SearchControlBOM_Enter;

            // Job Dispatch events
            listBoxControlJDOrderListing.SelectedIndexChanged += ListBoxControlJDOrderListing_SelectedIndexChanged;
            listBoxControlJDProductListing.SelectedIndexChanged += ListBoxControlJDSelectProduct_SelectedIndexChanged;

            // Initialize other elements
            AfterInitialization();
            // This line of code is generated by Data Source Configuration Wizard
        }

        private void AfterInitialization()
        {
            // Set mainform text
            //this.Appearance.Caption = new Font("Segoe UI", 9f);

            // Set text
            labelControlPMProjectLabel.Text = m_Manager.Name;
            ganttChartChartTreeListTableLayoutPanel.RowStyles[0].Height = ganttChartProductionMonitor.HeaderOneHeight - 6;
            layoutControlGroup9.Text = m_Manager.Name;

            // Popup menus
            UpdateDropDownButton(barButtonItemGridView);
            viewPopupMenu.MinWidth = dropDownButtonBOM.Width;

            // Create dummy secondary form
            _CreateDummyForm();

            // Set Time information
            var span = DateTime.Today - m_Manager.Start;
            m_Manager.Now = span; // set the "Now" marker at the correct date

            // Gantt chart styling
            setGanttChartColors();
            setElementColors();
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;

            // Gantt control settings
            //ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            ganttControlHome.ChartMappings.TextFieldName = "Text";
            ganttControlHome.ChartMappings.InteractionTooltipTextFieldName = "Tooltip";

            foreach (DataColumn column in m_Manager.HeaderList)
            {
                ganttControlHome.Columns.AddField(column.ColumnName);
            }
            ganttControlHome.OptionsBehavior.PopulateServiceColumns = true;
            //ganttControlOverview.OptionsBehavior.AllowSplitTasks = DevExpress.Utils.DefaultBoolean.True;
            //ganttControlOverview.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;

            ganttControlHome.ChartStartDate = m_Manager.Start;
            ganttControlHome.OptionsView.ShowBaselines = true;
            ganttControlHome.DataSource = GetTasks();

            ganttControlHome.ExpandAll();

            // Add details to ProductListing Views by temporarily giving them main view status
            cardViewProductListing = new DevExpress.XtraGrid.Views.Card.CardView();
            MasterDetailHelper cardHelper = new MasterDetailHelper(cardViewProductListing, ViewType.Card);

            gridControlBOM.MainView = cardViewProductListing;
            cardViewProductListing.CardCaptionFormat = "{1}/{2}/{3}";

            cardHelper.CreateDetail();
            _viewSetColumnProdCaption(cardViewProductListing);

            layoutViewProductListing = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            MasterDetailHelper layoutHelper = new MasterDetailHelper(layoutViewProductListing, ViewType.Layout);

            gridControlBOM.MainView = layoutViewProductListing;
            layoutViewProductListing.CardCaptionFormat = "{1}/{2}/{3}";

            layoutHelper.CreateDetail();
            _viewSetColumnProdCaption(layoutViewProductListing);

            // MasterDetailHelper events
            cardHelper.AfterPopup += CardHelper_AfterPopup;
            layoutHelper.AfterPopup += LayoutHelper_AfterPopup;

            gridControlBOM.MainView = gridViewProductListing; // Reset to default view

            // Account label
            barButtonItemAccountSettings.ItemClick += BarButtonItemAccountSettings_ItemClick;
            barButtonItemLogout.ItemClick += BarButtonItemLogout_ItemClick;

            // View popup
            barButtonItemCardView.ItemClick += barButtonItemCardView_Click;
            barButtonItemGridView.ItemClick += barButtonItemGridView_Click;
            barButtonIteLayoutView.ItemClick += barButtonItemLayoutView_Click;

            // Status strip
            toolStripStatusLabelStatus.Text = "Ready";
            statusStrip.Paint += StatusStrip_Paint;

            tabPaneMainForm.SelectedPageChanged += TabPaneMainForm_SelectedPageChanged;

            // Finished goods lookup
            gridViewFinishedGoods.CustomUnboundColumnData += GridViewFinishedGoods_CustomUnboundColumnData;

            // Manufacturing order product search
            // comboBoxEditManufacturingOrderProductListing.TextChanged += TextEditManufacturingOrderSelect_TextChanged;
            lookUpEditMOProductFilter.EditValue = null;
            lookUpEditMOProductFilter.EditValueChanged += LookUpEditMOProductFilter_EditValueChanged;

            lookUpEditMOProductFilter.QueryPopUp += LookUpEditMOProductFilter_QueryPopUp;
        }

        private void LayoutHelper_AfterPopup(object sender, DetailEventArgs e)
        {
            _viewSetColumnMaterialCaption(e.DetailView);
            (e.DetailView as LayoutView).CardCaptionFormat = "{1}/{2}/{3}";
        }

        private void CardHelper_AfterPopup(object sender, DetailEventArgs e)
        {
            _viewSetColumnMaterialCaption(e.DetailView);
            (e.DetailView as CardView).CardCaptionFormat = "{1}/{2}/{3}";
        }

        #region Overview

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPaneMainForm.SelectedPage = tabNavigationPage6;
        }

        private void tileInventory_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPaneMainForm.SelectedPage = tabNavigationPage5;
        }

        private void tileEventM_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPaneMainForm.SelectedPage = tabNavigationPage4;
        }

        #endregion

        #region BOM

        private void SearchControlBOM_Enter(object sender, EventArgs e)
        {
            GridView view = gridViewProductListing;
            GridColumn col = view.Columns["PROD_ID"];
            string text = searchControlBOM.Text;
            
            if(text.Length != 0)
            {
                view.BeginUpdate();

                //col.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                view.ActiveFilter.Remove(col);
                view.ActiveFilter.Add(col, new ColumnFilterInfo("Contains([PROD_ID], '" + text + "')"));
                
                view.EndUpdate();
            }
        }

        private void simpleButtonBOMSave_Click(object sender, EventArgs e)
        {
            PRODUCT_MSTTableAdapter.Update(signes_MESDataSet);
            materiaL_MSTTableAdapter.Update(signes_MESDataSet);
        }

        private void barButtonItemCardView_Click(object sender, ItemClickEventArgs e)
        {
            UpdateDropDownButton(e.Item);

            gridControlBOM.MainView = cardViewProductListing;
        }

        private void barButtonItemGridView_Click(object sender, ItemClickEventArgs e)
        {
            UpdateDropDownButton(e.Item);

            gridControlBOM.MainView = gridViewProductListing;
        }

        private void barButtonItemLayoutView_Click(object sender, ItemClickEventArgs e)
        {
            UpdateDropDownButton(e.Item);

            gridControlBOM.MainView = layoutViewProductListing;
        }

        private void UpdateDropDownButton(BarItem item)
        {
            dropDownButtonBOM.Text = item.Caption;
            dropDownButtonBOM.ImageOptions.SvgImage = item.ImageOptions.SvgImage;
            dropDownButtonBOM.ImageOptions.SvgImageSize = new Size(16, 16);
            dropDownButtonBOM.Tag = item.Tag;
        }

        private void simpleButtonBOMAddProduct_Click(object sender, EventArgs e)
        {
            BaseView view = gridControlBOM.MainView;
            (view as ColumnView).AddNewRow();

            //if (view is GridView)
            //{
            //    gridViewProductListing.AddNewRow();
            //}
            //else if(view is CardView)
            //{
            //    cardView.AddNewRow();
            //}
            //else if(view is LayoutView)
            //{
            //    layoutView.AddNewRow();
            //}
        }

        private void simpleButtonBOMAddMaterial_Click(object sender, EventArgs e)
        {
            BaseView view = gridControlBOM.MainView;
            if (view is GridView)
            {
                gridViewProductListing.ExpandMasterRow(gridViewProductListing.FocusedRowHandle);
                CardView detailView = (gridViewProductListing.GetDetailView(gridViewProductListing.FocusedRowHandle, 0) as CardView);
                detailView.AddNewRow();
            }
            else
            {
                ColumnView columnView = view as ColumnView;
                GridColumn column = columnView.Columns["Detail"];
                RepositoryItemPopupContainerEdit containerEdit = column.ColumnEdit as RepositoryItemPopupContainerEdit;
                PopupContainerControl control = containerEdit.PopupControl;

                MasterDetailHelper helper = column.Tag as MasterDetailHelper;
                
                // Get editor shown in focused column to utilize ShowPopup()
                columnView.FocusedColumn = column;
                columnView.ShowEditor();
                (columnView.ActiveEditor as PopupContainerEdit).ShowPopup();

                // Add new entry
                helper.DetailView.AddNewRow();
                

                //view.GridControl.BeginInvoke(new MethodInvoker(() => {
                //    PopupBaseEdit edit = view.ActiveEditor as PopupBaseEdit;
                //    if (edit == null) return;
                //    edit.ShowPopup();
                //}));

                
                //control.Show();
                //(containerEdit as RepositoryItemPopupContainerEdit).
            }
        }

        #endregion

        #region Manufacturing Order

        private void LookUpEditMOProductFilter_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lookUpEditMOProductFilter.Properties.PopupFormMinSize = new Size(1000, 200);

            GridColumnCollection collection = lookUpEditMOProductFilter.Properties.View.Columns;

            // hide columns
            collection["PROD_CLASS_CODE"].Visible = false;
            collection["DEL_YN"].Visible = false;
            collection["REASON_CODE"].Visible = false;
            collection["CREATE_USER_ID"].Visible = false;
            collection["CREATE_DATE"].Visible = false;
            collection["UPDATE_USER_ID"].Visible = false;
            collection["UPDATE_DATE"].Visible = false;

            collection["PROC_ID"].Visible = false;
            collection["SITE_ID"].Visible = false;
        }

        private void LookUpEditMOProductFilter_EditValueChanged(object sender, EventArgs e)
        {
            string filterText = (string)lookUpEditMOProductFilter.EditValue;

            if(filterText != null)
            {
                ColumnFilterInfo filter = new ColumnFilterInfo("[PROD_ID] = '" + filterText + "'");
                gridViewManufacturingOrder.ActiveFilter.Add(gridViewManufacturingOrder.Columns["PROD_ID"], filter);
            }
            else
            {
                // clear all filters
                gridViewManufacturingOrder.ClearColumnsFilter();
            }
        }

        private void simpleButtonManufacturingOrderSave_Click(object sender, EventArgs e)
        {
            mM_PROC_MSTTableAdapter.Update(signes_MESDataSet);
        }

        private void simpleButtonMOAddStep_Click(object sender, EventArgs e)
        {
            gridViewManufacturingOrder.ExpandMasterRow(gridViewManufacturingOrder.FocusedRowHandle);
            CardView detailView = (gridViewManufacturingOrder.GetDetailView(gridViewManufacturingOrder.FocusedRowHandle, 0) as CardView);
            detailView.AddNewRow();
        }

        #endregion

        #region Job Dispatch

        private void ListBoxControlJDSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prod_id = listBoxControlJDProductListing.SelectedValue as string;

            // Check selection
            if (prod_id != null)
            {
                // Update status
                checkEditJDSelectProduct.Checked = true;

                // Filter order list
                DataView view = jOB_MSTTableAdapter.GetData().DefaultView;
                view.RowFilter = "PROD_ID = '" + prod_id + "'";

                listBoxControlJDOrderListing.DataSource = view;
                listBoxControlJDOrderListing.SelectedIndex = -1;
            }
            else
            {
                // Update status
                checkEditJDSelectProduct.Checked = false;

                // Clear order list
                listBoxControlJDOrderListing.DataSource = null;
            }
        }

        private void ListBoxControlJDOrderListing_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prod_id = listBoxControlJDProductListing.SelectedValue as string;
            string order_id = listBoxControlJDOrderListing.SelectedValue as string;

            // Check selection
            if (prod_id != null && order_id != null)
            {
                // Update status
                checkEditJDSelectOrder.Checked = true;

                _createOrderDetailsForm(prod_id, order_id);
            }
            else
            {
                // Update status
                checkEditJDSelectOrder.Checked = false;

                // TODO create empty order details form
            }
        }

        private void _createOrderDetailsForm(string prod_id, string order_id)
        {
            tableLayoutPanelJDOrderDetails.Controls.Clear();

            LabelControl label = new LabelControl();
            TextEdit edit = new TextEdit();

            tableLayoutPanelJDOrderDetails.Controls.Add(edit);
            tableLayoutPanelJDOrderDetails.Controls.Add(label);
        }

        #endregion

        #region Material Inventory

        private void simpleButtonMaterialInventorySave_Click(object sender, EventArgs e)
        {
            materiaL_MSTTableAdapter.Update(signes_MESDataSet);
        }

        #endregion

        #region Production Monitor

        #region GanttChart Events
        void m_Chart_TaskSelected(object sender, TaskMouseEventArgs e)
        {
            taskGridPMSidebar.SelectedObjects = ganttChartProductionMonitor.SelectedTasks.Select(x => m_Manager.IsPart(x) ? m_Manager.SplitTaskOf(x) : x).ToArray();
            taskGridPMSidebar.ExpandAllGridItems();

            // Change visibility
            ganttChartChartOptionsPanel.Visible = true;
        }

        void m_Chart_TaskDeselecting(object sender, TaskMouseEventArgs e)
        {
            // Change visibility
            ganttChartChartOptionsPanel.Visible = false;
        }

        //void m_Chart_TaskMouseOut(object sender, TaskMouseEventArgs e)
        //{
        //    lblStatus.Text = "";
        //    m_Chart.Invalidate();
        //}

        //void m_Chart_TaskMouseOver(object sender, TaskMouseEventArgs e)
        //{
        //    lblStatus.Text = string.Format("{0} to {1}", m_Manager.GetDateTime(e.Task.Start).ToLongDateString(), m_Manager.GetDateTime(e.Task.End).ToLongDateString());
        //    m_Chart.Invalidate();
        //}

        //private void m_TaskList_CellEditFinishing(object sender, CellEditEventArgs e)
        //{
        //    m_Chart.Invalidate();
        //}

        //private void m_TaskList_CellEditValidating(object sender, CellEditEventArgs e)
        //{
        //    //int index = e.ListViewItem.Index;

        //    //if (e.NewValue is string)
        //    //{
        //    //    if (!m_Manager.SetField((Task)e.RowObject, index, (string)e.NewValue))
        //    //    {
        //    //        MessageBox.Show("Unknown error", "Gantt Chart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        e.Cancel = true;
        //    //    }
        //    //}
        //    //else if (e.NewValue is TimeSpan)
        //    //{
        //    //    if (!m_Manager.SetField((Task)e.RowObject, index, (TimeSpan)e.NewValue))
        //    //    {
        //    //        MessageBox.Show("Please try checking datetime input again", "Gantt Chart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        e.Cancel = true;
        //    //    }
        //    //}
        //    //else if (e.NewValue is DateTime)
        //    //{
        //    //    if (!m_Manager.SetField((Task)e.RowObject, index, m_Manager.Start - (DateTime)e.NewValue))
        //    //    {
        //    //        MessageBox.Show("Please try checking datetime input again", "Gantt Chart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        e.Cancel = true;
        //    //    }
        //    //}
        //}

        private void m_TaskList_Collapsed(object sender, NodeEventArgs e)
        {
            string ID = e.Node.Id.ToString();
            foreach (Task task in m_Manager.Tasks)
            {
                if (task.ID == ID)
                {
                    task.IsCollapsed = false;
                }
            }

            ganttChartProductionMonitor.Invalidate();
        }

        private void m_TaskList_Expanded(object sender, NodeEventArgs e)
        {
            string ID = e.Node.Id.ToString();
            foreach (Task task in m_Manager.Tasks)
            {
                if (task.ID == ID)
                {
                    task.IsCollapsed = false;
                }
            }

            ganttChartProductionMonitor.Invalidate();

        }

        private void m_Chart_TaskMouseDoubleClick(object sender, TaskMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_SearchMode)
            {
                TreeListNode node = treeListPMChartTreeList.FindNodeByID(int.Parse(e.Task.ID));
                // this check happens BEFORE IsCollapsed is toggled by double click
                if (!e.Task.IsCollapsed)
                {
                    node.Collapse();
                }
                else
                {
                    node.Expand();
                }
            }
        }

        private void m_Chart_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta;
            if (e.Delta > 0)
            {
                delta = -ganttChartProductionMonitor.Viewport.WheelDelta;
                _ScrollFix = -1;
            }
            else
            {
                delta = ganttChartProductionMonitor.Viewport.WheelDelta;
                _ScrollFix = 1;
            }

            int index = (int)(ganttChartProductionMonitor.Viewport.Y - ganttChartProductionMonitor.HeaderOneHeight + ganttChartProductionMonitor.HeaderTwoHeight + delta) / ganttChartProductionMonitor.BarSpacing;
            treeListPMChartTreeList.TopVisibleNodeIndex = index;
        }

        private void _mChart_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
            {
                //float ratio = (float) dataTreeListView1.GetItemCount() * m_Chart.BarSpacing / m_Chart.Viewport.WorldHeight;
                int nodes = (e.NewValue - ganttChartProductionMonitor.HeaderOneHeight - ganttChartProductionMonitor.HeaderTwoHeight) / ganttChartProductionMonitor.BarSpacing;
                //int rem = e.NewValue % ganttChart.BarSpacing;

                treeListPMChartTreeList.TopVisibleNodeIndex = nodes;
            }

            //int h1 = dataTreeListView1.Height * dataTreeListView1.RowHeight;
            //float h2 = m_Chart.Viewport.WorldHeight;
        }

        private void m_Chart_MousePan(object sender, MousePanEventArgs e)
        {
            // Prevent tasklist's Scroll event from mixing with panning functionality
            _IsPanning = true;
            //gChartTreeList.TopVisibleNodeIndex = TODO
            _IsPanning = false;
        }
        #endregion

        #region GanttChartTreeList Events
        private void gChartTreeList_TopVisibleIndexChanged(object sender, EventArgs e)
        {
            ganttChartProductionMonitor.Viewport.Y = ganttChartProductionMonitor.HeaderOneHeight + ganttChartProductionMonitor.HeaderTwoHeight + treeListPMChartTreeList.TopVisibleNodeIndex * ganttChartProductionMonitor.BarSpacing;

            _ScrollFix = 0;
        }

        private void m_TaskList_Collapsing(object sender, NodeEventArgs e)
        {
            if (_SearchMode)
            {
                //e.Canceled = true;
            }
        }

        private void m_TaskList_Expanding(object sender, NodeEventArgs e)
        {
            if (_SearchMode)
            {
                //e. = true;
            }
        }
        #endregion
        
        #endregion

        #region FinishedGoods
        private void GridViewFinishedGoods_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            // NOTE: To be replaced by object data if converted to business objects first.
            e.Value = signes_MESDataSet.PRODUCT_MST.FindByPROD_ID(((DataRowView)e.Row).Row.Field<string>("PROD_ID")).Field<string>(e.Column.FieldName);
        }

        private void simpleButtonFinishedGoodsSave_Click(object sender, EventArgs e)
        {
            finisheD_MSTTableAdapter1.Update(signes_MESDataSet);
        }

        #endregion

        #region Mainform

        #region Appearance & Style
        private void Default_StyleChanged(object sender, EventArgs e)
        {
            setGanttChartColors();
            setElementColors();
        }

        private void setElementColors()
        {
            var commonSkin = CommonSkins.GetSkin(this.LookAndFeel);
            var svgPalette = commonSkin.SvgPalettes["DefaultSkinPalette"];

            panelControlMain.Appearance.BackColor = svgPalette["Paint High"].Value;
            panelControlMain.Appearance.BackColor2 = svgPalette["Paint Shadow"].Value;
            labelControlTitle.ForeColor = svgPalette["Key Brush Light"].Value;

            //Color color = Color.FromArgb(Math.Max(color.A - 10, 0), Math.Max(color.R - 10, 0), Math.Max(color.G - 10, 0));
            statusStrip.BackColor = svgPalette["Accent Paint"].Value;
            toolStripStatusLabelStatus.ForeColor = commonSkin.Colors["Control"];

            //panelControlMain.LookAndFeel.Color
        }
        private void setGanttChartColors()
        {
            var commonSkin = CommonSkins.GetSkin(this.LookAndFeel);
            var svgPalette = commonSkin.SvgPalettes["DefaultSkinPalette"];

            ganttChartProductionMonitor.BackColor = svgPalette["Paint High"].Value;

            HeaderFormat headerFormat = ganttChartProductionMonitor.HeaderFormat;
            headerFormat.Color = new SolidBrush(commonSkin.Colors["ControlText"]);
            headerFormat.GradientLight = commonSkin.Colors["Control"];
            headerFormat.GradientDark = commonSkin.Colors["Control"];
            headerFormat.Border = new Pen(svgPalette["Brush Major"].Value);
            ganttChartProductionMonitor.HeaderFormat = headerFormat;

            TaskFormat taskFormat = ganttChartProductionMonitor.TaskFormat;
            taskFormat.Color = new SolidBrush(commonSkin.Colors["ControlText"]);
            taskFormat.Border = new Pen(Color.FromArgb(100, svgPalette["Accent Paint"].Value), 2f);
            taskFormat.ForeFill = new SolidBrush(svgPalette["Accent Paint"].Value);
            taskFormat.BackFill = new SolidBrush(Color.FromArgb(120, svgPalette["Accent Paint"].Value));
            taskFormat.DelayForeFill = new SolidBrush(commonSkin.Colors["WarningFill"]);
            taskFormat.DelayBackFill = new SolidBrush(Color.FromArgb(120, commonSkin.Colors["WarningFill"]));
            ganttChartProductionMonitor.TaskFormat = taskFormat;

            RelationFormat relationFormat = ganttChartProductionMonitor.RelationFormat;
            relationFormat.Line = new Pen(svgPalette["Brush"].Value);
            relationFormat.Brush = new SolidBrush(svgPalette["Brush"].Value);
            ganttChartProductionMonitor.RelationFormat = relationFormat;
        }

        private void StatusStrip_Paint(object sender, PaintEventArgs e)
        {
            Brush background = new SolidBrush(statusStrip.BackColor);
            //Pen pen = new Pen(new SolidBrush(Color.Gray));
            e.Graphics.FillRectangle(background, e.ClipRectangle);
            //e.Graphics.DrawRectangle(pen, e.ClipRectangle);

            base.OnPaint(e);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'signes_MESDataSet.JOB_MST' table. You can move, or remove it, as needed.
            this.jOB_MSTTableAdapter.Fill(this.signes_MESDataSet.JOB_MST);
            // TODO: This line of code loads data into the 'signes_MESDataSet.FINISHED_MST' table. You can move, or remove it, as needed.
            this.finisheD_MSTTableAdapter1.Fill(this.signes_MESDataSet.FINISHED_MST);
            // TODO: This line of code loads data into the 'signes_MESDataSet.MM_PROC_MST' table. You can move, or remove it, as needed.
            this.mM_PROC_MSTTableAdapter.Fill(this.signes_MESDataSet.MM_PROC_MST);
            // TODO: This line of code loads data into the 'signes_MESDataSet.MM_PROD_MST' table. You can move, or remove it, as needed.
            this.PRODUCT_MSTTableAdapter.Fill(this.signes_MESDataSet.PRODUCT_MST);
            this.materiaL_MSTTableAdapter.Fill(this.signes_MESDataSet.MATERIAL_MST);
            this.mM_PROC_STEPTableAdapter.Fill(this.signes_MESDataSet.MM_PROC_STEP);
        }

        private void TabPaneMainForm_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            string page = e.Page.Caption;

            if (page == "Job Dispatch")
            {
                // Reset selection
                listBoxControlJDProductListing.SelectedIndex = -1;
                listBoxControlJDOrderListing.SelectedIndex = -1;
            }

        }

        private object GetTasks()
        {
            //DataTable table = new DataTable();


            //foreach (Task task in m_Manager.Tasks)
            //{
            //    ModelledTask mTask = new ModelledTask(task, m_Manager);

            //    DataRow row = table.NewRow();
            //    row["Text"] = mTask.Text;
            //    row["ID"] = mTask.ID;
            //    row["ParentID"] = mTask.ParentID;
            //    row["StartDate"] = mTask.StartDate;
            //    row["FinishDate"] = mTask.FinishDate;
            //    row["BaselineStartDate"] = mTask.BaselineStartDate;
            //    row["BaselineFinishDate"] = mTask.BaselineFinishDate;
            //    row["Duration"] = mTask.Duration;
            //    row["Delay"] = mTask.Delay;
            //    row["Tooltip"] = mTask.Tooltip;
            //    row["Progress"] = mTask.Progress;
            //    table.Rows.Add(row);
            //}

            List<ModelledTask> tasks = new List<ModelledTask>();
            foreach (Task task in m_Manager.Tasks)
            {
                tasks.Add(new ModelledTask(task, m_Manager));
            }

            return tasks;
        }

        private void _FormatTreeList()
        {
            foreach (TreeListColumn column in treeListPMChartTreeList.Columns)
            {
                int hits = 0;

                foreach (DataColumn headerColumn in m_Manager.HeaderList)
                {
                    if (column.FieldName == headerColumn.ColumnName)
                    {
                        hits++;
                        break;
                    }
                }

                if (hits == 0)
                {
                    column.Visible = false;
                }
            }
        }

        private void _viewSetColumnProdCaption(ColumnView view)
        {
            view.BeginUpdate();
            view.Columns["PROD_ID"].Caption = "Product ID";
            view.Columns["PROD_GROUP_ID"].Caption = "Group ID";
            view.Columns["SITE_ID"].Caption = "Site ID";
            view.Columns["PROC_ID"].Caption = "Process ID";
            view.Columns["PROD_CLASS_CODE"].Caption = "Class code";
            view.Columns["PROD_NM"].Caption = "Name";
            view.Columns["PROD_TYPE"].Caption = "Type";
            view.Columns["SUB_PROD_TYPE"].Caption = "Subtype";
            view.Columns["PROD_GRADE"].Caption = "Grade";
            view.Columns["PROD_MODEL"].Caption = "Model";
            view.Columns["DEL_YN"].Visible = false;
            view.Columns["REASON_CODE"].Visible = false;
            view.Columns["DESCR"].Caption = "Description";
            view.Columns["CREATE_USER_ID"].Caption = "Created by";
            view.Columns["CREATE_DATE"].Caption = "Create date";
            view.Columns["UPDATE_USER_ID"].Caption = "Updated by";
            view.Columns["UPDATE_DATE"].Caption = "Update date";
            view.EndUpdate();
        }

        private void _viewSetColumnMaterialCaption(ColumnView view)
        {
            view.BeginUpdate();
            view.Columns["MATERIAL_ID"].Caption = "Material ID";
            view.Columns["MATERIAL_NAME"].Caption = "Name";
            view.Columns["QTY"].Caption = "Quantity";
            view.Columns["PROD_ID"].Caption = "Product ID";
            view.Columns["PROD_GROUP_ID"].Caption = "Product Group ID";
            view.Columns["SITE_ID"].Caption = "Product Site ID";
            view.Columns["PROC_ID"].Caption = "Product Process ID";
            view.Columns["PROD_CLASS_CODE"].Caption = "Product Class code";
            view.Columns["PROD_NM"].Caption = "Product Name";
            view.Columns["PROD_TYPE"].Caption = "Product Type";
            //view.Columns["SUB_PROD_TYPE"].Caption = "Product Subtype";
            view.Columns["PROD_GRADE"].Caption = "Product Grade";
            view.Columns["PROD_MODEL"].Caption = "Product Model";
            view.Columns["DEL_YN"].Visible = false;
            view.Columns["REASON_CODE"].Visible = false;
            view.Columns["DESCR"].Caption = "Product Description";
            view.Columns["CREATE_USER_ID"].Caption = "Created by";
            view.Columns["CREATE_DATE"].Caption = "Create date";
            view.Columns["UPDATE_USER_ID"].Caption = "Updated by";
            view.Columns["UPDATE_DATE"].Caption = "Update date";

            view.Columns["PROC_VER"].Caption = "Process Version";
            view.EndUpdate();
        }

        private void dummyForm_Disposed(object sender, EventArgs e)
        {
            _CreateDummyForm();
        }

        private void _CreateDummyForm()
        {
            dummyForm = new XtraForm();
            dummyForm.Size = new Size(852, 480);
            dummyForm.Name = "Dummy form";
            dummyForm.Disposed += new EventHandler(dummyForm_Disposed);
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            dummyForm.Text = "Group editor dummy form";
            dummyForm.ShowDialog();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            dummyForm.Text = "Task editor dummy form";
            dummyForm.ShowDialog();
        }

        private void accordionControlElementSetting_Click(object sender, EventArgs e)
        {
            dummyForm.Text = "Settings dummy form";
            dummyForm.ShowDialog();
        }

        private void BarButtonItemLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dummyForm.Text = "Login dummy form";
            dummyForm.ShowDialog();
        }

        private void BarButtonItemAccountSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dummyForm.Text = "Account settings dummy form";
            dummyForm.ShowDialog();
        }

        private void barButtonItemLicense_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dummyForm.Text = "License dummy form";
            dummyForm.ShowDialog();
        }

        private void accordionControlElementTaskEditor_Click(object sender, EventArgs e)
        {
            hyperlinkLabelControl1_Click(sender, e);
        }

        private void accordionControlElementGroupEditor_Click(object sender, EventArgs e)
        {
            hyperlinkLabelControl2_Click(sender, e);
        }


        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            tabPaneMainForm.SelectedPage = tabNavigationPage1;
        }

        protected override FormPainter CreateFormBorderPainter()
        {
            return new CustomToolbarFormPainter(this, LookAndFeel);
        }

        #endregion

        private void labelControl2_Click(object sender, EventArgs e)
        {
            //Point loc = 
            Point bottomleft = panelControlMain.PointToScreen(new Point(labelControl2.Left, labelControl2.Bottom));
            accountPopupMenu.ShowPopup(bottomleft, labelControl2);
        }

    }

    #region overlay painter
    /// <summary>
    /// An example of how to encapsulate a helper painter for painter additional features on Chart
    /// </summary>
    public class OverlayPainter
    {
        /// <summary>
        /// Hook such a method to the chart paint event listeners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChartOverlayPainter(object sender, ChartPaintEventArgs e)
        {
            // Don't want to print instructions to file
            if (this.PrintMode) return;

            var g = e.Graphics;
            var chart = e.Chart;

            // Demo: Static billboards begin -----------------------------------
            // Demonstrate how to draw static billboards
            // "push matrix" -- save our transformation matrix
            e.Chart.BeginBillboardMode(e.Graphics);

            // draw mouse command instructions
            int margin = 320;
            int left = 20;
            var color = chart.HeaderFormat.Color;
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("LEFT  - Select task and display properties in PropertyGrid");
            builder.AppendLine("LEFT Doubleclick  - Toggle collaspe on task group");
            builder.AppendLine("");
            builder.AppendLine("LEFT + Drag  - Change task starting point");
            builder.AppendLine("RIGHT + Drag  - Change task duration");
            builder.AppendLine("MIDDLE + Drag  - Change task complete percentage");
            builder.AppendLine("RIGHT Doubleclick  - Split task into task parts");
            builder.AppendLine("LEFT + Drag and drop*  - Group drag task under drop task");
            builder.AppendLine("RIGHT + Drag and drop*  - Join task parts");
            builder.AppendLine("SHIFT + LEFT + Drag and drop*  - Make drop task precedent of drag task");
            builder.AppendLine("ALT + LEFT + Drag and drop*  - Ungroup drag task from drop task / Remove drop task from drag task precedent list");
            builder.AppendLine("");
            builder.AppendLine("SHIFT + LEFT + Drag and drop*  - Order tasks");
            builder.AppendLine("SHIFT + MIDDLE  - Create new task");
            builder.AppendLine("ALT + MIDDLE  - Delete task");
            builder.AppendLine("LEFT Doubleclick  - Toggle collaspe on task group");
            builder.AppendLine();
            builder.AppendLine("*Drag and drop onto another task or task part");
            var size = g.MeasureString(builder.ToString(), e.Chart.Font);
            var background = new Rectangle(left, chart.Height - margin, (int)size.Width, (int)size.Height);
            background.Inflate(10, 10);
            g.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(background, Color.LightYellow, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical), background);
            g.DrawRectangle(Pens.Brown, background);
            g.DrawString(builder.ToString(), chart.Font, color, new PointF(left, chart.Height - margin));


            // "pop matrix" -- restore the previous matrix
            e.Chart.EndBillboardMode(e.Graphics);
            // Demo: Static billboards end -----------------------------------
        }

        public bool PrintMode { get; set; }
    }
    #endregion overlay painter

    #region MyTask (Custom Task Class)
    /// <summary>
    /// A custom task of your own type deriving from the Task interface (optional)
    /// </summary>
    [Serializable]
    public class MyTask : Task
    {
        public MyTask(ProjectManager manager)
            : base()
        {
            Manager = manager;
        }

        private ProjectManager Manager { get; set; }
        public new float Complete { get { return base.Complete; } set { Manager.SetComplete(this, value); } }
    }
    #endregion MyTask (Custom Task Class)

    public class CustomToolbarFormPainter : ToolbarFormPainter
    {
        public CustomToolbarFormPainter(Control owner, ISkinProvider provider) : base(owner, provider) { }

        protected override void DrawText(DevExpress.Utils.Drawing.GraphicsCache cache)
        {
            string text = Text;
            if (text == null || text.Length == 0 || this.TextBounds.IsEmpty) return;
            AppearanceObject appearance = new AppearanceObject(GetDefaultAppearance());
            appearance.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            appearance.TextOptions.Trimming = Trimming.EllipsisCharacter;
            Rectangle r = RectangleHelper.GetCenterBounds(TextBounds, new Size(TextBounds.Width, appearance.CalcDefaultTextSize(cache.Graphics).Height));
            DrawTextShadow(cache, appearance, r);
            cache.DrawString(text, appearance.Font, appearance.GetForeBrush(cache), r, appearance.GetStringFormat());
        }
    }
}
