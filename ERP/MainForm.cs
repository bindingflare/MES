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

namespace MES
{
    public partial class MainForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        private ProjectManager m_Manager = null;
        private OverlayPainter m_Overlay = new OverlayPainter();

        private XtraForm dummyForm;
        private MasterDetailHelper helper;

        private DevExpress.XtraGrid.Views.Card.CardView cardView;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView;

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

            // Perform some task operations
            m_Manager.AddCustomField("Greeting", typeof(string), 80);
            m_Manager.AddCustomField("Cancelled", typeof(string), 80);
            m_Manager.AddCustomField("Important", typeof(bool), 80);

            var work = new MyTask(m_Manager) { Name = "Prepare for Work" };
            var wake = new MyTask(m_Manager) { Name = "Wake Up" };
            var teeth = new MyTask(m_Manager) { Name = "Brush Teeth" };
            var shower = new MyTask(m_Manager) { Name = "Shower" };
            var clothes = new MyTask(m_Manager) { Name = "Change into New Clothes" };
            var hair = new MyTask(m_Manager) { Name = "Blow My Hair" };
            var pack = new MyTask(m_Manager) { Name = "Pack the Suitcase" };

            m_Manager.Add(work);
            m_Manager.Add(wake);
            m_Manager.Add(teeth);
            m_Manager.Add(shower);
            m_Manager.Add(clothes);
            m_Manager.Add(hair);
            m_Manager.Add(pack);

            m_Manager.SetField(work, 7, "Hello");
            m_Manager.SetField(wake, 7, "HI");
            m_Manager.SetField(teeth, 7, "hey");
            m_Manager.SetField(shower, 7, "Yo");
            m_Manager.SetField(clothes, 7, "Greetings");
            m_Manager.SetField(hair, 7, "Good morning");
            m_Manager.SetField(pack, 7, "Good evening");

            var job1 = new MyTask(m_Manager) { Name = "Job1" };
            var job2 = new MyTask(m_Manager) { Name = "Job2" };
            var job3 = new MyTask(m_Manager) { Name = "Brush Teeth" };
            var job4 = new MyTask(m_Manager) { Name = "JOb4" };
            var job5 = new MyTask(m_Manager) { Name = "JOb 5" };
            var job6 = new MyTask(m_Manager) { Name = "job 6" };
            var job7 = new MyTask(m_Manager) { Name = "end job" };

            m_Manager.Add(job1);
            m_Manager.Add(job2);
            m_Manager.Add(job3);
            m_Manager.Add(job4);
            m_Manager.Add(job5);
            m_Manager.Add(job6);
            m_Manager.Add(job7);

            m_Manager.SetField(job1, 7, "Hello");
            m_Manager.SetField(job2, 7, "HI");
            m_Manager.SetField(job3, 7, "hey");
            m_Manager.SetField(job4, 7, "Yo");
            m_Manager.SetField(job5, 7, "Greetings");
            m_Manager.SetField(job6, 7, "Good morning");
            m_Manager.SetField(job7, 7, "Good evening");

            //m_Manager.SetField(work, "Important", "Yes");

            // Test delay
            m_Manager.SetDelay(job2, new TimeSpan(3, 0, 0, 0));
            m_Manager.SetDelay(job3, new TimeSpan(1, 0, 0, 0));
            m_Manager.SetDelay(job4, new TimeSpan(7, 0, 0, 0));
            m_Manager.SetDelay(job7, new TimeSpan(3, 0, 0, 0));

            // Create another 1000 tasks for stress testing
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var task = new MyTask(m_Manager) { Name = string.Format("New Task {0}", i.ToString()) };
                m_Manager.Add(task);
                m_Manager.SetStart(task, TimeSpan.FromDays(rand.Next(100)));
                m_Manager.SetDuration(task, TimeSpan.FromDays(rand.Next(50)));
            }

            // Set task durations, e.g. using ProjectManager methods 
            m_Manager.SetDuration(wake, TimeSpan.FromDays(3));
            m_Manager.SetDuration(teeth, TimeSpan.FromDays(5));
            m_Manager.SetDuration(shower, TimeSpan.FromDays(7));
            m_Manager.SetDuration(clothes, TimeSpan.FromDays(4));
            m_Manager.SetDuration(hair, TimeSpan.FromDays(3));
            m_Manager.SetDuration(pack, TimeSpan.FromDays(5));
            m_Manager.SetDuration(job2, TimeSpan.FromDays(3));
            m_Manager.SetDuration(job3, TimeSpan.FromDays(5));
            m_Manager.SetDuration(job4, TimeSpan.FromDays(7));
            m_Manager.SetDuration(job5, TimeSpan.FromDays(4));
            m_Manager.SetDuration(job6, TimeSpan.FromDays(3));
            m_Manager.SetDuration(job7, TimeSpan.FromDays(5));

            // demostrate splitting a task
            m_Manager.Split(pack, new MyTask(m_Manager), new MyTask(m_Manager), TimeSpan.FromDays(2));
            m_Manager.Split(job7, new MyTask(m_Manager), new MyTask(m_Manager), TimeSpan.FromDays(2));

            // Set task complete status, e.g. using newly created properties
            wake.Complete = 0.9f;
            teeth.Complete = 0.5f;
            shower.Complete = 0.4f;

            job2.Complete = 0.9f;
            job3.Complete = 0.5f;
            job4.Complete = 0.4f;

            // Give the Tasks some organisation, setting group and precedents
            m_Manager.Group(work, wake);
            m_Manager.Group(work, teeth);
            m_Manager.Group(work, shower);
            m_Manager.Group(work, clothes);
            m_Manager.Group(work, hair);
            m_Manager.Group(work, pack);
            m_Manager.Relate(wake, teeth);
            m_Manager.Relate(wake, shower);
            m_Manager.Relate(shower, clothes);
            m_Manager.Relate(shower, hair);
            m_Manager.Relate(hair, pack);
            m_Manager.Relate(clothes, pack);

            m_Manager.Group(job1, job2);
            m_Manager.Group(job1, job3);
            m_Manager.Group(job1, job4);
            m_Manager.Group(job1, job5);
            //m_Manager.Group(job1, job6);
            m_Manager.Group(job1, job7);
            m_Manager.Relate(job2, job3);
            m_Manager.Relate(job2, job4);
            m_Manager.Relate(job4, job5);
            //m_Manager.Relate(job4, job6);
            //m_Manager.Relate(job6, job7);
            m_Manager.Relate(job5, job7);

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

            //ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            ganttControlOverview.ChartMappings.TextFieldName = "Text";
            ganttControlOverview.ChartMappings.InteractionTooltipTextFieldName = "Tooltip";

            foreach (DataColumn column in m_Manager.HeaderList)
            {
                ganttControlOverview.Columns.AddField(column.ColumnName);
            }
            ganttControlOverview.OptionsBehavior.PopulateServiceColumns = true;
            //ganttControlOverview.OptionsBehavior.AllowSplitTasks = DevExpress.Utils.DefaultBoolean.True;
            //ganttControlOverview.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;

            ganttControlOverview.ChartStartDate = m_Manager.Start;
            ganttControlOverview.OptionsView.ShowBaselines = true;
            ganttControlOverview.DataSource = GetTasks();

            ganttControlOverview.ExpandAll();

            // Build tree for GanttChart
            ganttChartChart.Init(m_Manager);
            ganttChartChart.CreateTaskDelegate = delegate () { return new MyTask(m_Manager); };

            ganttChartChartSplitContainer.SplitterPosition = 400;

            ganttChartChartTreeList.DataSource = GetTasks();

            _FormatTreeList();

            ganttChartChartTreeList.RowHeight = ganttChartChart.BarSpacing - 1;
            ganttChartChartTreeList.Columns.ElementAt(0).Width = 200;
            ganttChartChartTreeList.ExpandAll();

            // GanttChart event listeners
            //ganttChart.TaskMouseOver += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskMouseOver);
            //ganttChart.TaskMouseOut += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskMouseOut);
            ganttChartChart.TaskSelected += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskSelected);
            ganttChartChart.TaskDeselecting += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskDeselecting);
            ganttChartChart.TaskMouseDoubleClick += new EventHandler<TaskMouseEventArgs>(m_Chart_TaskMouseDoubleClick);
            m_Overlay.PrintMode = true;
            ganttChartChart.PaintOverlay += m_Overlay.ChartOverlayPainter;
            ganttChartChart.AllowTaskDragDrop = true;
            //m_Chart.Scroll += new ScrollEventHandler(m_Chart_Scroll);
            ganttChartChart.MouseWheel += new MouseEventHandler(m_Chart_MouseWheel);
            ganttChartChart.MousePan += new EventHandler<MousePanEventArgs>(m_Chart_MousePan);

            // Tasklist event listeners
            ganttChartChartTreeList.AfterExpand += new NodeEventHandler(m_TaskList_Expanded);
            ganttChartChartTreeList.AfterCollapse += new NodeEventHandler(m_TaskList_Collapsed);
            ganttChartChartTreeList.TopVisibleNodeIndexChanged += new EventHandler(gChartTreeList_TopVisibleIndexChanged);
            //gChartTreeList.BeforeExpand += new NodeEventHandler(m_TaskList_Expanding);
            //gChartTreeList.BeforeCollapse += new NodeEventHandler(m_TaskList_Collapsing);

            // Set Time information
            var span = DateTime.Today - m_Manager.Start;
            m_Manager.Now = span; // set the "Now" marker at the correct date

            // Gantt chart styling
            setGanttChartColors();
            setElementColors();
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;

            // Initialize other elements
            AfterInitialization();
            // This line of code is generated by Data Source Configuration Wizard
        }
        private void AfterInitialization()
        {
            // Set mainform text
            this.Appearance.Font = new Font("Segoe UI", 9f);

            // Set text
            ganttChartChartProjectLabel.Text = m_Manager.Name;
            ganttChartChartTreeListTableLayoutPanel.RowStyles[0].Height = ganttChartChart.HeaderOneHeight - 6;
            layoutControlGroup9.Text = m_Manager.Name;

            // Popup menus
            UpdateDropDownButton(barButtonItemGridView);
            viewPopupMenu.MinWidth = dropDownButtonBOM.Width;

            // Create dummy secondary form
            _CreateDummyForm();

            // BOM
            searchControlBOM.EditValueChanged += SearchControlBOM_Enter;

            // Views
            cardView = new DevExpress.XtraGrid.Views.Card.CardView();
            layoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();

            // Account label
            barButtonItemAccountSettings.ItemClick += BarButtonItemAccountSettings_ItemClick;
            barButtonItemLogout.ItemClick += BarButtonItemLogout_ItemClick;

            // View popup
            barButtonItemCardView.ItemClick += barButtonItemCardView_Click;
            barButtonItemGridView.ItemClick += barButtonItemGridView_Click;
            barButtonIteLayoutView.ItemClick += barButtonItemLayoutView_Click;

            // Status strip
            toolStripStatusLabel1.Text = "Ready";

            // Finished goods lookup
            gridViewFinishedGoods.CustomUnboundColumnData += GridViewFinishedGoods_CustomUnboundColumnData;

            // Manufacturing order product search
            // comboBoxEditManufacturingOrderProductListing.TextChanged += TextEditManufacturingOrderSelect_TextChanged;
            lookUpEditMOProductFilter.EditValue = null;
            lookUpEditMOProductFilter.EditValueChanged += LookUpEditMOProductFilter_EditValueChanged;

            lookUpEditMOProductFilter.QueryPopUp += LookUpEditMOProductFilter_QueryPopUp;
        }

        

        #region Overview

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage6;
        }

        private void tileInventory_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage5;
        }

        private void tileEventM_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPane1.SelectedPage = tabNavigationPage4;
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

            gridControlBOM.MainView = cardView;

            helper = new MasterDetailHelper(cardView, ViewType.Card);
            helper.CreateDetail();
        }

        private void barButtonItemGridView_Click(object sender, ItemClickEventArgs e)
        {
            UpdateDropDownButton(e.Item);

            gridControlBOM.MainView = gridViewProductListing;
        }

        private void barButtonItemLayoutView_Click(object sender, ItemClickEventArgs e)
        {
            UpdateDropDownButton(e.Item);

            gridControlBOM.MainView = layoutView;

            helper = new MasterDetailHelper(layoutView, ViewType.Card);
            helper.CreateDetail();
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
            gridViewProductListing.AddNewRow();
        }

        private void simpleButtonBOMAddMaterial_Click(object sender, EventArgs e)
        {
            gridViewProductListing.ExpandMasterRow(gridViewProductListing.FocusedRowHandle);
            CardView detailView = (gridViewProductListing.GetDetailView(gridViewProductListing.FocusedRowHandle, 0) as CardView);
            detailView.AddNewRow();
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

        #region Job Despatch

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
            m_TaskGrid.SelectedObjects = ganttChartChart.SelectedTasks.Select(x => m_Manager.IsPart(x) ? m_Manager.SplitTaskOf(x) : x).ToArray();
            m_TaskGrid.ExpandAllGridItems();

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

            ganttChartChart.Invalidate();
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

            ganttChartChart.Invalidate();

        }

        private void m_Chart_TaskMouseDoubleClick(object sender, TaskMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_SearchMode)
            {
                TreeListNode node = ganttChartChartTreeList.FindNodeByID(int.Parse(e.Task.ID));
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
                delta = -ganttChartChart.Viewport.WheelDelta;
                _ScrollFix = -1;
            }
            else
            {
                delta = ganttChartChart.Viewport.WheelDelta;
                _ScrollFix = 1;
            }

            int index = (int)(ganttChartChart.Viewport.Y - ganttChartChart.HeaderOneHeight + ganttChartChart.HeaderTwoHeight + delta) / ganttChartChart.BarSpacing;
            ganttChartChartTreeList.TopVisibleNodeIndex = index;
        }

        private void _mChart_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
            {
                //float ratio = (float) dataTreeListView1.GetItemCount() * m_Chart.BarSpacing / m_Chart.Viewport.WorldHeight;
                int nodes = (e.NewValue - ganttChartChart.HeaderOneHeight - ganttChartChart.HeaderTwoHeight) / ganttChartChart.BarSpacing;
                //int rem = e.NewValue % ganttChart.BarSpacing;

                ganttChartChartTreeList.TopVisibleNodeIndex = nodes;
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
            ganttChartChart.Viewport.Y = ganttChartChart.HeaderOneHeight + ganttChartChart.HeaderTwoHeight + ganttChartChartTreeList.TopVisibleNodeIndex * ganttChartChart.BarSpacing;

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

            //panelControlMain.LookAndFeel.Color
        }
        private void setGanttChartColors()
        {
            var commonSkin = CommonSkins.GetSkin(this.LookAndFeel);
            var svgPalette = commonSkin.SvgPalettes["DefaultSkinPalette"];

            ganttChartChart.BackColor = svgPalette["Paint High"].Value;

            HeaderFormat headerFormat = ganttChartChart.HeaderFormat;
            headerFormat.Color = new SolidBrush(commonSkin.Colors["ControlText"]);
            headerFormat.GradientLight = commonSkin.Colors["Control"];
            headerFormat.GradientDark = commonSkin.Colors["Control"];
            headerFormat.Border = new Pen(svgPalette["Brush Major"].Value);
            ganttChartChart.HeaderFormat = headerFormat;

            TaskFormat taskFormat = ganttChartChart.TaskFormat;
            taskFormat.Color = new SolidBrush(commonSkin.Colors["ControlText"]);
            taskFormat.Border = new Pen(Color.FromArgb(100, svgPalette["Accent Paint"].Value), 2f);
            taskFormat.ForeFill = new SolidBrush(svgPalette["Accent Paint"].Value);
            taskFormat.BackFill = new SolidBrush(Color.FromArgb(120, svgPalette["Accent Paint"].Value));
            taskFormat.DelayForeFill = new SolidBrush(commonSkin.Colors["WarningFill"]);
            taskFormat.DelayBackFill = new SolidBrush(Color.FromArgb(120, commonSkin.Colors["WarningFill"]));
            ganttChartChart.TaskFormat = taskFormat;

            RelationFormat relationFormat = ganttChartChart.RelationFormat;
            relationFormat.Line = new Pen(svgPalette["Brush"].Value);
            relationFormat.Brush = new SolidBrush(svgPalette["Brush"].Value);
            ganttChartChart.RelationFormat = relationFormat;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'signes_MESDataSet.FINISHED_MST' table. You can move, or remove it, as needed.
            this.finisheD_MSTTableAdapter1.Fill(this.signes_MESDataSet.FINISHED_MST);
            // TODO: This line of code loads data into the 'signes_MESDataSet.MM_PROC_MST' table. You can move, or remove it, as needed.
            this.mM_PROC_MSTTableAdapter.Fill(this.signes_MESDataSet.MM_PROC_MST);
            // TODO: This line of code loads data into the 'signes_MESDataSet.MM_PROD_MST' table. You can move, or remove it, as needed.
            this.PRODUCT_MSTTableAdapter.Fill(this.signes_MESDataSet.PRODUCT_MST);
            this.materiaL_MSTTableAdapter.Fill(this.signes_MESDataSet.MATERIAL_MST);
            this.mM_PROC_STEPTableAdapter.Fill(this.signes_MESDataSet.MM_PROC_STEP);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            //Point loc = 
            Point bottomleft = panelControlMain.PointToScreen(new Point(labelControl2.Left, labelControl2.Bottom));
            accountPopupMenu.ShowPopup(bottomleft, labelControl2);
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
            foreach (TreeListColumn column in ganttChartChartTreeList.Columns)
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
            tabPane1.SelectedPage = tabNavigationPage1;
        }

        #endregion

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
}
