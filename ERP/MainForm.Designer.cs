using System.ComponentModel;
using DevExpress.XtraLayout;

namespace MES
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            this.cardViewMaterialDetail = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colMATERIAL_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_NAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_MODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_CLASS_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GRADE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GROUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_VER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREASON_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlBOM = new DevExpress.XtraGrid.GridControl();
            this.mMPRODMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signes_MESDataSet = new MES.Signes_MESDataSet();
            this.gridViewProductListing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROD_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GROUP_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_CLASS_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_NM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_TYPE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUB_PROD_TYPE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GRADE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_MODEL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_YN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREASON_CODE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_USER_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_DATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItemAccountSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCardView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGridView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonIteLayoutView = new DevExpress.XtraBars.BarButtonItem();
            this.cardViewProcessStep = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colDUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE_ID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTEP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTEP_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_ID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_VER3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQP_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDCSPEC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDCOLL_MAND_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDURABLE_USE_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONSUM_USE_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHILD_PROC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHILD_PROC_VER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_YN4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREASON_CODE4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCR4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_DATE4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlManufacturingOrder = new DevExpress.XtraGrid.GridControl();
            this.mMPROCMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewManufacturingOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROC_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_VER2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_YN3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREASON_CODE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCR3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DATE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_USER_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_DATE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTitle = new DevExpress.XtraEditors.LabelControl();
            this.ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.StartDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.FinishDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Duration = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.BaselineStartDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.BaselineEndDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Complete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Delay = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.viewPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControlGroup24 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup26 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementMain = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementEventManager = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementExportLogs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInventory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementMaterialEditor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementViewRestocks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGanttChart = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementTaskEditor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementGroupEditor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSetting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.toolbarFormManager2 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItemLicense = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.skinPaletteDropDownButtonItem = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.accountPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlOverview = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.tileControlOverview = new DevExpress.XtraEditors.TileControl();
            this.groupGanttChart = new DevExpress.XtraEditors.TileGroup();
            this.tileGanttChart = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.groupInventory = new DevExpress.XtraEditors.TileGroup();
            this.tileInventory = new DevExpress.XtraEditors.TileItem();
            this.tileEventM = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.ganttControlOverview = new DevExpress.XtraGantt.GanttControl();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.tabNavigationPage6 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlProductionMonitor = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ganttChartHyperLinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.ganttChartChartSplitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.ganttChartChartTreeListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ganttChartChartProjectLabel = new DevExpress.XtraEditors.LabelControl();
            this.ganttChartChartTreeList = new DevExpress.XtraTreeList.TreeList();
            this.ganttChartChartOptionsPanel = new System.Windows.Forms.Panel();
            this.m_TaskGrid = new System.Windows.Forms.PropertyGrid();
            this.ganttChartChart = new Edcore.GanttChart.GanttChart();
            this.ganttChartHyperLinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.ganttChartLabelControlQuickLinks = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem5 = new DevExpress.XtraLayout.SplitterItem();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlMaterialInventory = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonMaterialInventorySave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMaterialInventoryReserved = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMaterialListing = new DevExpress.XtraGrid.GridControl();
            this.mATERIAL_MSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMaterialListing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATERIAL_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_NAME2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_NM2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_MODEL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_TYPE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_CLASS_CODE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GRADE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GROUP_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_VER1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_YN2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREASON_CODE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DATE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_USER_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATE_DATE2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup18 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem6 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup16 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem17 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlJobDispatch = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.eventManagerEventStackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.eventManagerEventStackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup19 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup20 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup14 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup15 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem4 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlManufacturingOrder = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlManufacturingOrder = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonMOAddStep = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMOSave = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditMOProductFilter = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup27 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem10 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup29 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup30 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlBOM = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonBOMAddMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.simpleButtonBOMAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.searchControlBOM = new DevExpress.XtraEditors.SearchControl();
            this.dropDownButtonBOM = new DevExpress.XtraEditors.DropDownButton();
            this.simpleButtonBOMSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup21 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup22 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem8 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup23 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem9 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabNavigationPage7 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControlFinishedGoodsInventory = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonFinishedGoodsReserved = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonFinishedGoodsSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlFinishedGoods = new DevExpress.XtraGrid.GridControl();
            this.fINISHEDMSTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewFinishedGoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDUID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEVENT_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_ID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DATE4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GROUP_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSITE_ID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROC_ID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_CLASS_CODE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_NM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_TYPE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUB_PROD_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_GRADE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_MODEL3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup25 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup17 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup28 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem7 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mMPROCMSTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fINISHEDMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMPROCSTEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMATERIAL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATERIAL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControlGanttChart = new DevExpress.XtraEditors.PanelControl();
            this.tableAdapterManager = new MES.Signes_MESDataSetTableAdapters.TableAdapterManager();
            this.PRODUCT_MSTTableAdapter = new MES.Signes_MESDataSetTableAdapters.PRODUCT_MSTTableAdapter();
            this.materiaL_MSTTableAdapter = new MES.Signes_MESDataSetTableAdapters.MATERIAL_MSTTableAdapter();
            this.mM_PROC_STEPTableAdapter = new MES.Signes_MESDataSetTableAdapters.MM_PROC_STEPTableAdapter();
            this.mM_PROC_MSTTableAdapter = new MES.Signes_MESDataSetTableAdapters.MM_PROC_MSTTableAdapter();
            this.finisheD_MSTTableAdapter1 = new MES.Signes_MESDataSetTableAdapters.FINISHED_MSTTableAdapter();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager3 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.skinPaletteDropDownButtonItem2 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.productPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.mMPROCMSTMMPROCSTEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardViewMaterialDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPRODMSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signes_MESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewProcessStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlManufacturingOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCMSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManufacturingOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOverview)).BeginInit();
            this.panelControlOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControlOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.tabNavigationPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlProductionMonitor)).BeginInit();
            this.panelControlProductionMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartSplitContainer.Panel1)).BeginInit();
            this.ganttChartChartSplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartSplitContainer.Panel2)).BeginInit();
            this.ganttChartChartSplitContainer.Panel2.SuspendLayout();
            this.ganttChartChartSplitContainer.SuspendLayout();
            this.ganttChartChartTreeListTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartTreeList)).BeginInit();
            this.ganttChartChartOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem5)).BeginInit();
            this.tabNavigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMaterialInventory)).BeginInit();
            this.panelControlMaterialInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIAL_MSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialListing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlJobDispatch)).BeginInit();
            this.panelControlJobDispatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerEventStackPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerEventStackPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlManufacturingOrder)).BeginInit();
            this.panelControlManufacturingOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlManufacturingOrder)).BeginInit();
            this.layoutControlManufacturingOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMOProductFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBOM)).BeginInit();
            this.panelControlBOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
            this.layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControlBOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            this.tabNavigationPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFinishedGoodsInventory)).BeginInit();
            this.panelControlFinishedGoodsInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
            this.layoutControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFinishedGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINISHEDMSTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFinishedGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCMSTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINISHEDMSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCSTEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGanttChart)).BeginInit();
            this.panelControlGanttChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCMSTMMPROCSTEPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cardViewMaterialDetail
            // 
            this.cardViewMaterialDetail.CardCaptionFormat = "{1}/{2}/{3}";
            this.cardViewMaterialDetail.CardWidth = 230;
            this.cardViewMaterialDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATERIAL_ID1,
            this.colMATERIAL_NAME1,
            this.colSITE_ID,
            this.colQTY,
            this.colPROD_ID,
            this.colPROD_NM,
            this.colPROD_MODEL,
            this.colPROD_TYPE,
            this.colPROD_CLASS_CODE,
            this.colPROD_GRADE,
            this.colPROD_GROUP_ID,
            this.colPROC_ID,
            this.colPROC_VER,
            this.colDEL_YN,
            this.colREASON_CODE,
            this.colDESCR,
            this.colCREATE_USER_ID,
            this.colCREATE_DATE,
            this.colUPDATE_USER_ID,
            this.colUPDATE_DATE});
            this.cardViewMaterialDetail.DetailHeight = 375;
            this.cardViewMaterialDetail.GridControl = this.gridControlBOM;
            this.cardViewMaterialDetail.Name = "cardViewMaterialDetail";
            this.cardViewMaterialDetail.OptionsBehavior.AutoFocusNewCard = true;
            // 
            // colMATERIAL_ID1
            // 
            this.colMATERIAL_ID1.Caption = "Material ID";
            this.colMATERIAL_ID1.FieldName = "MATERIAL_ID";
            this.colMATERIAL_ID1.Name = "colMATERIAL_ID1";
            this.colMATERIAL_ID1.Visible = true;
            this.colMATERIAL_ID1.VisibleIndex = 0;
            // 
            // colMATERIAL_NAME1
            // 
            this.colMATERIAL_NAME1.Caption = "Name";
            this.colMATERIAL_NAME1.FieldName = "MATERIAL_NAME";
            this.colMATERIAL_NAME1.Name = "colMATERIAL_NAME1";
            this.colMATERIAL_NAME1.Visible = true;
            this.colMATERIAL_NAME1.VisibleIndex = 1;
            // 
            // colSITE_ID
            // 
            this.colSITE_ID.Caption = "Site";
            this.colSITE_ID.FieldName = "SITE_ID";
            this.colSITE_ID.Name = "colSITE_ID";
            this.colSITE_ID.Visible = true;
            this.colSITE_ID.VisibleIndex = 2;
            // 
            // colQTY
            // 
            this.colQTY.Caption = "Quantity";
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            // 
            // colPROD_ID
            // 
            this.colPROD_ID.Caption = "Product ID";
            this.colPROD_ID.FieldName = "PROD_ID";
            this.colPROD_ID.Name = "colPROD_ID";
            // 
            // colPROD_NM
            // 
            this.colPROD_NM.Caption = "Product Name";
            this.colPROD_NM.FieldName = "PROD_NM";
            this.colPROD_NM.Name = "colPROD_NM";
            // 
            // colPROD_MODEL
            // 
            this.colPROD_MODEL.Caption = "Product Model";
            this.colPROD_MODEL.FieldName = "PROD_MODEL";
            this.colPROD_MODEL.Name = "colPROD_MODEL";
            // 
            // colPROD_TYPE
            // 
            this.colPROD_TYPE.Caption = "Product type";
            this.colPROD_TYPE.FieldName = "PROD_TYPE";
            this.colPROD_TYPE.Name = "colPROD_TYPE";
            // 
            // colPROD_CLASS_CODE
            // 
            this.colPROD_CLASS_CODE.Caption = "Product Class Code";
            this.colPROD_CLASS_CODE.FieldName = "PROD_CLASS_CODE";
            this.colPROD_CLASS_CODE.Name = "colPROD_CLASS_CODE";
            // 
            // colPROD_GRADE
            // 
            this.colPROD_GRADE.Caption = "Product Grade";
            this.colPROD_GRADE.FieldName = "PROD_GRADE";
            this.colPROD_GRADE.Name = "colPROD_GRADE";
            // 
            // colPROD_GROUP_ID
            // 
            this.colPROD_GROUP_ID.Caption = "Product Group ID";
            this.colPROD_GROUP_ID.FieldName = "PROD_GROUP_ID";
            this.colPROD_GROUP_ID.Name = "colPROD_GROUP_ID";
            // 
            // colPROC_ID
            // 
            this.colPROC_ID.Caption = "Process";
            this.colPROC_ID.FieldName = "PROC_ID";
            this.colPROC_ID.Name = "colPROC_ID";
            this.colPROC_ID.Visible = true;
            this.colPROC_ID.VisibleIndex = 4;
            // 
            // colPROC_VER
            // 
            this.colPROC_VER.Caption = "Process version";
            this.colPROC_VER.FieldName = "PROC_VER";
            this.colPROC_VER.Name = "colPROC_VER";
            this.colPROC_VER.Visible = true;
            this.colPROC_VER.VisibleIndex = 5;
            // 
            // colDEL_YN
            // 
            this.colDEL_YN.FieldName = "DEL_YN";
            this.colDEL_YN.Name = "colDEL_YN";
            // 
            // colREASON_CODE
            // 
            this.colREASON_CODE.FieldName = "REASON_CODE";
            this.colREASON_CODE.Name = "colREASON_CODE";
            // 
            // colDESCR
            // 
            this.colDESCR.Caption = "Product Description";
            this.colDESCR.FieldName = "DESCR";
            this.colDESCR.Name = "colDESCR";
            this.colDESCR.Visible = true;
            this.colDESCR.VisibleIndex = 6;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.Caption = "Created by";
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 7;
            // 
            // colCREATE_DATE
            // 
            this.colCREATE_DATE.Caption = "Create date";
            this.colCREATE_DATE.FieldName = "CREATE_DATE";
            this.colCREATE_DATE.Name = "colCREATE_DATE";
            this.colCREATE_DATE.Visible = true;
            this.colCREATE_DATE.VisibleIndex = 8;
            // 
            // colUPDATE_USER_ID
            // 
            this.colUPDATE_USER_ID.Caption = "Updated by";
            this.colUPDATE_USER_ID.FieldName = "UPDATE_USER_ID";
            this.colUPDATE_USER_ID.Name = "colUPDATE_USER_ID";
            // 
            // colUPDATE_DATE
            // 
            this.colUPDATE_DATE.Caption = "Update date";
            this.colUPDATE_DATE.FieldName = "UPDATE_DATE";
            this.colUPDATE_DATE.Name = "colUPDATE_DATE";
            // 
            // gridControlBOM
            // 
            this.gridControlBOM.DataSource = this.mMPRODMSTBindingSource;
            gridLevelNode1.LevelTemplate = this.cardViewMaterialDetail;
            gridLevelNode1.RelationName = "MM_PROD_MST_MATERIAL_MST";
            this.gridControlBOM.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlBOM.Location = new System.Drawing.Point(18, 69);
            this.gridControlBOM.MainView = this.gridViewProductListing;
            this.gridControlBOM.MenuManager = this.toolbarFormManager1;
            this.gridControlBOM.Name = "gridControlBOM";
            this.gridControlBOM.Size = new System.Drawing.Size(1192, 432);
            this.gridControlBOM.TabIndex = 6;
            this.gridControlBOM.UseEmbeddedNavigator = true;
            this.gridControlBOM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductListing,
            this.cardViewMaterialDetail});
            // 
            // mMPRODMSTBindingSource
            // 
            this.mMPRODMSTBindingSource.DataMember = "PRODUCT_MST";
            this.mMPRODMSTBindingSource.DataSource = this.signes_MESDataSet;
            // 
            // signes_MESDataSet
            // 
            this.signes_MESDataSet.DataSetName = "Signes_MESDataSet";
            this.signes_MESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewProductListing
            // 
            this.gridViewProductListing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROD_ID1,
            this.colPROD_GROUP_ID1,
            this.colSITE_ID1,
            this.colPROC_ID1,
            this.colPROD_CLASS_CODE1,
            this.colPROD_NM1,
            this.colPROD_TYPE1,
            this.colSUB_PROD_TYPE1,
            this.colPROD_GRADE1,
            this.colPROD_MODEL1,
            this.colDEL_YN1,
            this.colREASON_CODE1,
            this.colDESCR1,
            this.colCREATE_USER_ID1,
            this.colCREATE_DATE1,
            this.colUPDATE_USER_ID1,
            this.colUPDATE_DATE1});
            this.gridViewProductListing.DetailHeight = 375;
            this.gridViewProductListing.GridControl = this.gridControlBOM;
            this.gridViewProductListing.Name = "gridViewProductListing";
            this.gridViewProductListing.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewProductListing.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextFilter;
            this.gridViewProductListing.OptionsView.ColumnAutoWidth = false;
            // 
            // colPROD_ID1
            // 
            this.colPROD_ID1.Caption = "Product ID";
            this.colPROD_ID1.FieldName = "PROD_ID";
            this.colPROD_ID1.Name = "colPROD_ID1";
            this.colPROD_ID1.Visible = true;
            this.colPROD_ID1.VisibleIndex = 0;
            // 
            // colPROD_GROUP_ID1
            // 
            this.colPROD_GROUP_ID1.Caption = "Group ID";
            this.colPROD_GROUP_ID1.FieldName = "PROD_GROUP_ID";
            this.colPROD_GROUP_ID1.Name = "colPROD_GROUP_ID1";
            this.colPROD_GROUP_ID1.Visible = true;
            this.colPROD_GROUP_ID1.VisibleIndex = 1;
            // 
            // colSITE_ID1
            // 
            this.colSITE_ID1.Caption = "Site ID";
            this.colSITE_ID1.FieldName = "SITE_ID";
            this.colSITE_ID1.Name = "colSITE_ID1";
            this.colSITE_ID1.Visible = true;
            this.colSITE_ID1.VisibleIndex = 2;
            // 
            // colPROC_ID1
            // 
            this.colPROC_ID1.Caption = "Process";
            this.colPROC_ID1.FieldName = "PROC_ID";
            this.colPROC_ID1.Name = "colPROC_ID1";
            this.colPROC_ID1.Visible = true;
            this.colPROC_ID1.VisibleIndex = 3;
            // 
            // colPROD_CLASS_CODE1
            // 
            this.colPROD_CLASS_CODE1.Caption = "Class Code";
            this.colPROD_CLASS_CODE1.FieldName = "PROD_CLASS_CODE";
            this.colPROD_CLASS_CODE1.Name = "colPROD_CLASS_CODE1";
            this.colPROD_CLASS_CODE1.Visible = true;
            this.colPROD_CLASS_CODE1.VisibleIndex = 4;
            // 
            // colPROD_NM1
            // 
            this.colPROD_NM1.Caption = "Name";
            this.colPROD_NM1.FieldName = "PROD_NM";
            this.colPROD_NM1.Name = "colPROD_NM1";
            this.colPROD_NM1.Visible = true;
            this.colPROD_NM1.VisibleIndex = 5;
            // 
            // colPROD_TYPE1
            // 
            this.colPROD_TYPE1.Caption = "Type";
            this.colPROD_TYPE1.FieldName = "PROD_TYPE";
            this.colPROD_TYPE1.Name = "colPROD_TYPE1";
            this.colPROD_TYPE1.Visible = true;
            this.colPROD_TYPE1.VisibleIndex = 6;
            // 
            // colSUB_PROD_TYPE1
            // 
            this.colSUB_PROD_TYPE1.Caption = "Subtype";
            this.colSUB_PROD_TYPE1.FieldName = "SUB_PROD_TYPE";
            this.colSUB_PROD_TYPE1.Name = "colSUB_PROD_TYPE1";
            this.colSUB_PROD_TYPE1.Visible = true;
            this.colSUB_PROD_TYPE1.VisibleIndex = 7;
            // 
            // colPROD_GRADE1
            // 
            this.colPROD_GRADE1.Caption = "Grade";
            this.colPROD_GRADE1.FieldName = "PROD_GRADE";
            this.colPROD_GRADE1.Name = "colPROD_GRADE1";
            this.colPROD_GRADE1.Visible = true;
            this.colPROD_GRADE1.VisibleIndex = 8;
            // 
            // colPROD_MODEL1
            // 
            this.colPROD_MODEL1.Caption = "Model";
            this.colPROD_MODEL1.FieldName = "PROD_MODEL";
            this.colPROD_MODEL1.Name = "colPROD_MODEL1";
            this.colPROD_MODEL1.Visible = true;
            this.colPROD_MODEL1.VisibleIndex = 9;
            // 
            // colDEL_YN1
            // 
            this.colDEL_YN1.FieldName = "DEL_YN";
            this.colDEL_YN1.Name = "colDEL_YN1";
            // 
            // colREASON_CODE1
            // 
            this.colREASON_CODE1.FieldName = "REASON_CODE";
            this.colREASON_CODE1.Name = "colREASON_CODE1";
            // 
            // colDESCR1
            // 
            this.colDESCR1.Caption = "Description";
            this.colDESCR1.FieldName = "DESCR";
            this.colDESCR1.Name = "colDESCR1";
            this.colDESCR1.Visible = true;
            this.colDESCR1.VisibleIndex = 10;
            // 
            // colCREATE_USER_ID1
            // 
            this.colCREATE_USER_ID1.Caption = "Created by";
            this.colCREATE_USER_ID1.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID1.Name = "colCREATE_USER_ID1";
            this.colCREATE_USER_ID1.Visible = true;
            this.colCREATE_USER_ID1.VisibleIndex = 11;
            // 
            // colCREATE_DATE1
            // 
            this.colCREATE_DATE1.Caption = "Create date";
            this.colCREATE_DATE1.FieldName = "CREATE_DATE";
            this.colCREATE_DATE1.Name = "colCREATE_DATE1";
            this.colCREATE_DATE1.Visible = true;
            this.colCREATE_DATE1.VisibleIndex = 12;
            // 
            // colUPDATE_USER_ID1
            // 
            this.colUPDATE_USER_ID1.Caption = "Updated by";
            this.colUPDATE_USER_ID1.FieldName = "UPDATE_USER_ID";
            this.colUPDATE_USER_ID1.Name = "colUPDATE_USER_ID1";
            this.colUPDATE_USER_ID1.Visible = true;
            this.colUPDATE_USER_ID1.VisibleIndex = 13;
            // 
            // colUPDATE_DATE1
            // 
            this.colUPDATE_DATE1.Caption = "Update date";
            this.colUPDATE_DATE1.FieldName = "UPDATE_DATE";
            this.colUPDATE_DATE1.Name = "colUPDATE_DATE1";
            this.colUPDATE_DATE1.Visible = true;
            this.colUPDATE_DATE1.VisibleIndex = 14;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Account", new System.Guid("14973033-613e-4200-a862-7e20f2deb65d")),
            new DevExpress.XtraBars.BarManagerCategory("Product", new System.Guid("ac933564-f1c0-4bd3-842d-ab8cfcdcb063")),
            new DevExpress.XtraBars.BarManagerCategory("View", new System.Guid("bac13e53-74ad-48f9-b4e4-52d2a5fee75f"))});
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAccountSettings,
            this.barButtonItemLogout,
            this.barButtonItemCardView,
            this.barButtonItemGridView,
            this.barButtonIteLayoutView});
            this.toolbarFormManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 30);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 771);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 30);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 741);
            // 
            // barButtonItemAccountSettings
            // 
            this.barButtonItemAccountSettings.Caption = "Account settings";
            this.barButtonItemAccountSettings.CategoryGuid = new System.Guid("14973033-613e-4200-a862-7e20f2deb65d");
            this.barButtonItemAccountSettings.Id = 2;
            this.barButtonItemAccountSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAccountSettings.ImageOptions.SvgImage")));
            this.barButtonItemAccountSettings.Name = "barButtonItemAccountSettings";
            // 
            // barButtonItemLogout
            // 
            this.barButtonItemLogout.Caption = "Logout";
            this.barButtonItemLogout.CategoryGuid = new System.Guid("14973033-613e-4200-a862-7e20f2deb65d");
            this.barButtonItemLogout.Id = 3;
            this.barButtonItemLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemLogout.ImageOptions.Image")));
            this.barButtonItemLogout.Name = "barButtonItemLogout";
            // 
            // barButtonItemCardView
            // 
            this.barButtonItemCardView.Caption = "Card View";
            this.barButtonItemCardView.CategoryGuid = new System.Guid("bac13e53-74ad-48f9-b4e4-52d2a5fee75f");
            this.barButtonItemCardView.Id = 4;
            this.barButtonItemCardView.Name = "barButtonItemCardView";
            // 
            // barButtonItemGridView
            // 
            this.barButtonItemGridView.Caption = "Grid View";
            this.barButtonItemGridView.CategoryGuid = new System.Guid("bac13e53-74ad-48f9-b4e4-52d2a5fee75f");
            this.barButtonItemGridView.Id = 5;
            this.barButtonItemGridView.Name = "barButtonItemGridView";
            // 
            // barButtonIteLayoutView
            // 
            this.barButtonIteLayoutView.Caption = "Layout View";
            this.barButtonIteLayoutView.CategoryGuid = new System.Guid("bac13e53-74ad-48f9-b4e4-52d2a5fee75f");
            this.barButtonIteLayoutView.Id = 6;
            this.barButtonIteLayoutView.Name = "barButtonIteLayoutView";
            // 
            // cardViewProcessStep
            // 
            this.cardViewProcessStep.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDUID,
            this.colSITE_ID4,
            this.colSTEP_ID,
            this.colSTEP_SEQ,
            this.colPROC_ID4,
            this.colPROC_VER3,
            this.colEQP_TYPE,
            this.colDCSPEC_ID,
            this.colDCOLL_MAND_YN,
            this.colDURABLE_USE_YN,
            this.colCONSUM_USE_YN,
            this.colCHILD_PROC_ID,
            this.colCHILD_PROC_VER,
            this.colDEL_YN4,
            this.colREASON_CODE4,
            this.colDESCR4,
            this.colCREATE_USER_ID4,
            this.colUPDATE_DATE4});
            this.cardViewProcessStep.DetailHeight = 375;
            this.cardViewProcessStep.GridControl = this.gridControlManufacturingOrder;
            this.cardViewProcessStep.Name = "cardViewProcessStep";
            this.cardViewProcessStep.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colDUID
            // 
            this.colDUID.FieldName = "DUID";
            this.colDUID.Name = "colDUID";
            this.colDUID.Visible = true;
            this.colDUID.VisibleIndex = 0;
            // 
            // colSITE_ID4
            // 
            this.colSITE_ID4.FieldName = "SITE_ID";
            this.colSITE_ID4.Name = "colSITE_ID4";
            this.colSITE_ID4.Visible = true;
            this.colSITE_ID4.VisibleIndex = 1;
            // 
            // colSTEP_ID
            // 
            this.colSTEP_ID.FieldName = "STEP_ID";
            this.colSTEP_ID.Name = "colSTEP_ID";
            this.colSTEP_ID.Visible = true;
            this.colSTEP_ID.VisibleIndex = 2;
            // 
            // colSTEP_SEQ
            // 
            this.colSTEP_SEQ.FieldName = "STEP_SEQ";
            this.colSTEP_SEQ.Name = "colSTEP_SEQ";
            this.colSTEP_SEQ.Visible = true;
            this.colSTEP_SEQ.VisibleIndex = 3;
            // 
            // colPROC_ID4
            // 
            this.colPROC_ID4.FieldName = "PROC_ID";
            this.colPROC_ID4.Name = "colPROC_ID4";
            this.colPROC_ID4.Visible = true;
            this.colPROC_ID4.VisibleIndex = 4;
            // 
            // colPROC_VER3
            // 
            this.colPROC_VER3.FieldName = "PROC_VER";
            this.colPROC_VER3.Name = "colPROC_VER3";
            this.colPROC_VER3.Visible = true;
            this.colPROC_VER3.VisibleIndex = 5;
            // 
            // colEQP_TYPE
            // 
            this.colEQP_TYPE.FieldName = "EQP_TYPE";
            this.colEQP_TYPE.Name = "colEQP_TYPE";
            this.colEQP_TYPE.Visible = true;
            this.colEQP_TYPE.VisibleIndex = 6;
            // 
            // colDCSPEC_ID
            // 
            this.colDCSPEC_ID.FieldName = "DCSPEC_ID";
            this.colDCSPEC_ID.Name = "colDCSPEC_ID";
            this.colDCSPEC_ID.Visible = true;
            this.colDCSPEC_ID.VisibleIndex = 7;
            // 
            // colDCOLL_MAND_YN
            // 
            this.colDCOLL_MAND_YN.FieldName = "DCOLL_MAND_YN";
            this.colDCOLL_MAND_YN.Name = "colDCOLL_MAND_YN";
            this.colDCOLL_MAND_YN.Visible = true;
            this.colDCOLL_MAND_YN.VisibleIndex = 8;
            // 
            // colDURABLE_USE_YN
            // 
            this.colDURABLE_USE_YN.FieldName = "DURABLE_USE_YN";
            this.colDURABLE_USE_YN.Name = "colDURABLE_USE_YN";
            this.colDURABLE_USE_YN.Visible = true;
            this.colDURABLE_USE_YN.VisibleIndex = 9;
            // 
            // colCONSUM_USE_YN
            // 
            this.colCONSUM_USE_YN.FieldName = "CONSUM_USE_YN";
            this.colCONSUM_USE_YN.Name = "colCONSUM_USE_YN";
            this.colCONSUM_USE_YN.Visible = true;
            this.colCONSUM_USE_YN.VisibleIndex = 10;
            // 
            // colCHILD_PROC_ID
            // 
            this.colCHILD_PROC_ID.FieldName = "CHILD_PROC_ID";
            this.colCHILD_PROC_ID.Name = "colCHILD_PROC_ID";
            this.colCHILD_PROC_ID.Visible = true;
            this.colCHILD_PROC_ID.VisibleIndex = 11;
            // 
            // colCHILD_PROC_VER
            // 
            this.colCHILD_PROC_VER.FieldName = "CHILD_PROC_VER";
            this.colCHILD_PROC_VER.Name = "colCHILD_PROC_VER";
            this.colCHILD_PROC_VER.Visible = true;
            this.colCHILD_PROC_VER.VisibleIndex = 12;
            // 
            // colDEL_YN4
            // 
            this.colDEL_YN4.FieldName = "DEL_YN";
            this.colDEL_YN4.Name = "colDEL_YN4";
            this.colDEL_YN4.Visible = true;
            this.colDEL_YN4.VisibleIndex = 13;
            // 
            // colREASON_CODE4
            // 
            this.colREASON_CODE4.FieldName = "REASON_CODE";
            this.colREASON_CODE4.Name = "colREASON_CODE4";
            this.colREASON_CODE4.Visible = true;
            this.colREASON_CODE4.VisibleIndex = 14;
            // 
            // colDESCR4
            // 
            this.colDESCR4.FieldName = "DESCR";
            this.colDESCR4.Name = "colDESCR4";
            this.colDESCR4.Visible = true;
            this.colDESCR4.VisibleIndex = 15;
            // 
            // colCREATE_USER_ID4
            // 
            this.colCREATE_USER_ID4.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID4.Name = "colCREATE_USER_ID4";
            this.colCREATE_USER_ID4.Visible = true;
            this.colCREATE_USER_ID4.VisibleIndex = 16;
            // 
            // colUPDATE_DATE4
            // 
            this.colUPDATE_DATE4.FieldName = "UPDATE_DATE";
            this.colUPDATE_DATE4.Name = "colUPDATE_DATE4";
            this.colUPDATE_DATE4.Visible = true;
            this.colUPDATE_DATE4.VisibleIndex = 17;
            // 
            // gridControlManufacturingOrder
            // 
            this.gridControlManufacturingOrder.DataSource = this.mMPROCMSTBindingSource;
            gridLevelNode2.LevelTemplate = this.cardViewProcessStep;
            gridLevelNode2.RelationName = "MM_PROC_MST_MM_PROC_STEP";
            this.gridControlManufacturingOrder.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlManufacturingOrder.Location = new System.Drawing.Point(17, 68);
            this.gridControlManufacturingOrder.MainView = this.gridViewManufacturingOrder;
            this.gridControlManufacturingOrder.MenuManager = this.toolbarFormManager1;
            this.gridControlManufacturingOrder.Name = "gridControlManufacturingOrder";
            this.gridControlManufacturingOrder.Size = new System.Drawing.Size(1194, 466);
            this.gridControlManufacturingOrder.TabIndex = 15;
            this.gridControlManufacturingOrder.UseEmbeddedNavigator = true;
            this.gridControlManufacturingOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewManufacturingOrder,
            this.cardViewProcessStep});
            // 
            // mMPROCMSTBindingSource
            // 
            this.mMPROCMSTBindingSource.DataMember = "MM_PROC_MST";
            this.mMPROCMSTBindingSource.DataSource = this.signes_MESDataSet;
            // 
            // gridViewManufacturingOrder
            // 
            this.gridViewManufacturingOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROC_ID3,
            this.colSITE_ID3,
            this.colPROD_ID3,
            this.colPROC_VER2,
            this.colPROC_NM,
            this.colPROC_TYPE,
            this.colDEL_YN3,
            this.colREASON_CODE3,
            this.colDESCR3,
            this.colCREATE_USER_ID3,
            this.colCREATE_DATE3,
            this.colUPDATE_USER_ID3,
            this.colUPDATE_DATE3});
            this.gridViewManufacturingOrder.DetailHeight = 375;
            this.gridViewManufacturingOrder.GridControl = this.gridControlManufacturingOrder;
            this.gridViewManufacturingOrder.Name = "gridViewManufacturingOrder";
            this.gridViewManufacturingOrder.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewManufacturingOrder.OptionsView.ColumnAutoWidth = false;
            // 
            // colPROC_ID3
            // 
            this.colPROC_ID3.Caption = "Process ID";
            this.colPROC_ID3.FieldName = "PROC_ID";
            this.colPROC_ID3.Name = "colPROC_ID3";
            this.colPROC_ID3.Visible = true;
            this.colPROC_ID3.VisibleIndex = 0;
            // 
            // colSITE_ID3
            // 
            this.colSITE_ID3.Caption = "Site ID";
            this.colSITE_ID3.FieldName = "SITE_ID";
            this.colSITE_ID3.Name = "colSITE_ID3";
            this.colSITE_ID3.Visible = true;
            this.colSITE_ID3.VisibleIndex = 1;
            // 
            // colPROD_ID3
            // 
            this.colPROD_ID3.Caption = "Product ID";
            this.colPROD_ID3.FieldName = "PROD_ID";
            this.colPROD_ID3.Name = "colPROD_ID3";
            this.colPROD_ID3.Visible = true;
            this.colPROD_ID3.VisibleIndex = 2;
            // 
            // colPROC_VER2
            // 
            this.colPROC_VER2.Caption = "Version";
            this.colPROC_VER2.FieldName = "PROC_VER";
            this.colPROC_VER2.Name = "colPROC_VER2";
            this.colPROC_VER2.Visible = true;
            this.colPROC_VER2.VisibleIndex = 3;
            // 
            // colPROC_NM
            // 
            this.colPROC_NM.Caption = "Name";
            this.colPROC_NM.FieldName = "PROC_NM";
            this.colPROC_NM.Name = "colPROC_NM";
            this.colPROC_NM.Visible = true;
            this.colPROC_NM.VisibleIndex = 4;
            // 
            // colPROC_TYPE
            // 
            this.colPROC_TYPE.Caption = "Type";
            this.colPROC_TYPE.FieldName = "PROC_TYPE";
            this.colPROC_TYPE.Name = "colPROC_TYPE";
            this.colPROC_TYPE.Visible = true;
            this.colPROC_TYPE.VisibleIndex = 5;
            // 
            // colDEL_YN3
            // 
            this.colDEL_YN3.FieldName = "DEL_YN";
            this.colDEL_YN3.Name = "colDEL_YN3";
            this.colDEL_YN3.Visible = true;
            this.colDEL_YN3.VisibleIndex = 6;
            // 
            // colREASON_CODE3
            // 
            this.colREASON_CODE3.FieldName = "REASON_CODE";
            this.colREASON_CODE3.Name = "colREASON_CODE3";
            this.colREASON_CODE3.Visible = true;
            this.colREASON_CODE3.VisibleIndex = 7;
            // 
            // colDESCR3
            // 
            this.colDESCR3.Caption = "Description";
            this.colDESCR3.FieldName = "DESCR";
            this.colDESCR3.Name = "colDESCR3";
            this.colDESCR3.Visible = true;
            this.colDESCR3.VisibleIndex = 8;
            // 
            // colCREATE_USER_ID3
            // 
            this.colCREATE_USER_ID3.Caption = "Created by";
            this.colCREATE_USER_ID3.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID3.Name = "colCREATE_USER_ID3";
            this.colCREATE_USER_ID3.Visible = true;
            this.colCREATE_USER_ID3.VisibleIndex = 9;
            // 
            // colCREATE_DATE3
            // 
            this.colCREATE_DATE3.Caption = "Create date";
            this.colCREATE_DATE3.FieldName = "CREATE_DATE";
            this.colCREATE_DATE3.Name = "colCREATE_DATE3";
            this.colCREATE_DATE3.Visible = true;
            this.colCREATE_DATE3.VisibleIndex = 10;
            // 
            // colUPDATE_USER_ID3
            // 
            this.colUPDATE_USER_ID3.Caption = "Updated by";
            this.colUPDATE_USER_ID3.FieldName = "UPDATE_USER_ID";
            this.colUPDATE_USER_ID3.Name = "colUPDATE_USER_ID3";
            this.colUPDATE_USER_ID3.Visible = true;
            this.colUPDATE_USER_ID3.VisibleIndex = 11;
            // 
            // colUPDATE_DATE3
            // 
            this.colUPDATE_DATE3.Caption = "Update date";
            this.colUPDATE_DATE3.FieldName = "UPDATE_DATE";
            this.colUPDATE_DATE3.Name = "colUPDATE_DATE3";
            this.colUPDATE_DATE3.Visible = true;
            this.colUPDATE_DATE3.VisibleIndex = 12;
            // 
            // panelControlMain
            // 
            this.panelControlMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControlMain.Appearance.Options.UseBackColor = true;
            this.panelControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlMain.Controls.Add(this.labelControl2);
            this.panelControlMain.Controls.Add(this.labelControlTitle);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMain.Location = new System.Drawing.Point(0, 30);
            this.panelControlMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControlMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1236, 129);
            this.panelControlMain.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl2.ImageOptions.SvgImage")));
            this.labelControl2.IndentBetweenImageAndText = 4;
            this.labelControl2.Location = new System.Drawing.Point(1083, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 36);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "UserNamePassword";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControlTitle.Appearance.Options.UseFont = true;
            this.labelControlTitle.Appearance.Options.UseForeColor = true;
            this.labelControlTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControlTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.labelControlTitle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControlTitle.ImageOptions.SvgImage")));
            this.labelControlTitle.IndentBetweenImageAndText = 4;
            this.labelControlTitle.Location = new System.Drawing.Point(9, 59);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(227, 45);
            this.labelControlTitle.TabIndex = 0;
            this.labelControlTitle.Text = "Signe-S MES";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ParentID
            // 
            this.ParentID.Caption = "ParentID";
            this.ParentID.FieldName = "ParentID";
            this.ParentID.Name = "ParentID";
            this.ParentID.Visible = true;
            this.ParentID.VisibleIndex = 4;
            // 
            // StartDate
            // 
            this.StartDate.Caption = "Start Date";
            this.StartDate.FieldName = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 0;
            this.StartDate.Width = 130;
            // 
            // FinishDate
            // 
            this.FinishDate.Caption = "End Date";
            this.FinishDate.FieldName = "FinishDate";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.Visible = true;
            this.FinishDate.VisibleIndex = 2;
            this.FinishDate.Width = 130;
            // 
            // Duration
            // 
            this.Duration.Caption = "Duration";
            this.Duration.FieldName = "TimeDuration";
            this.Duration.Name = "Duration";
            this.Duration.Visible = true;
            this.Duration.VisibleIndex = 3;
            this.Duration.Width = 80;
            // 
            // BaselineStartDate
            // 
            this.BaselineStartDate.Caption = "BaselineStartDate";
            this.BaselineStartDate.FieldName = "BaselineStartDate";
            this.BaselineStartDate.Name = "BaselineStartDate";
            // 
            // BaselineEndDate
            // 
            this.BaselineEndDate.Caption = "BaselineEndDate";
            this.BaselineEndDate.FieldName = "BaselineEndDate";
            this.BaselineEndDate.Name = "BaselineEndDate";
            // 
            // Complete
            // 
            this.Complete.Caption = "Complete";
            this.Complete.FieldName = "Complete";
            this.Complete.Name = "Complete";
            // 
            // Delay
            // 
            this.Delay.Caption = "Delay";
            this.Delay.FieldName = "Delay";
            this.Delay.Name = "Delay";
            this.Delay.Visible = true;
            this.Delay.VisibleIndex = 1;
            this.Delay.Width = 100;
            // 
            // viewPopupMenu
            // 
            this.viewPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCardView),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemGridView),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonIteLayoutView)});
            this.viewPopupMenu.Manager = this.toolbarFormManager1;
            this.viewPopupMenu.Name = "viewPopupMenu";
            // 
            // layoutControlGroup24
            // 
            this.layoutControlGroup24.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup24.GroupBordersVisible = false;
            this.layoutControlGroup24.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup26});
            this.layoutControlGroup24.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup24.Name = "Root";
            this.layoutControlGroup24.Size = new System.Drawing.Size(1228, 1196);
            this.layoutControlGroup24.TextVisible = false;
            // 
            // layoutControlGroup26
            // 
            this.layoutControlGroup26.CustomizationFormText = "Product Listing";
            this.layoutControlGroup26.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup26.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem20});
            this.layoutControlGroup26.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup26.Name = "layoutControlGroup26";
            this.layoutControlGroup26.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup26.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup26.Size = new System.Drawing.Size(1208, 1176);
            this.layoutControlGroup26.Text = "Database Access";
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(50, 20);
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 30);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1236, 690);
            this.fluentDesignFormContainer1.TabIndex = 6;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementMain,
            this.accordionControlElementSetting});
            this.accordionControl1.Location = new System.Drawing.Point(1236, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(44, 741);
            this.accordionControl1.TabIndex = 7;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementMain
            // 
            this.accordionControlElementMain.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElementEventManager,
            this.accordionControlElementInventory,
            this.accordionControlElementGanttChart,
            this.accordionControlElement3});
            this.accordionControlElementMain.Expanded = true;
            this.accordionControlElementMain.Name = "accordionControlElementMain";
            this.accordionControlElementMain.Text = "Main";
            this.accordionControlElementMain.VisibleInFooter = false;
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement5.ImageOptions.SvgImage")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Production Overview";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Main page";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "BOM";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Manufacturing Order";
            // 
            // accordionControlElementEventManager
            // 
            this.accordionControlElementEventManager.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementExportLogs});
            this.accordionControlElementEventManager.Expanded = true;
            this.accordionControlElementEventManager.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementEventManager.ImageOptions.SvgImage")));
            this.accordionControlElementEventManager.Name = "accordionControlElementEventManager";
            this.accordionControlElementEventManager.Text = "Job Dispatch";
            // 
            // accordionControlElementExportLogs
            // 
            this.accordionControlElementExportLogs.Name = "accordionControlElementExportLogs";
            this.accordionControlElementExportLogs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementExportLogs.Text = "Export logs";
            // 
            // accordionControlElementInventory
            // 
            this.accordionControlElementInventory.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementMaterialEditor,
            this.accordionControlElementViewRestocks});
            this.accordionControlElementInventory.Expanded = true;
            this.accordionControlElementInventory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementInventory.ImageOptions.SvgImage")));
            this.accordionControlElementInventory.Name = "accordionControlElementInventory";
            this.accordionControlElementInventory.Text = "Material Inventory";
            // 
            // accordionControlElementMaterialEditor
            // 
            this.accordionControlElementMaterialEditor.Name = "accordionControlElementMaterialEditor";
            this.accordionControlElementMaterialEditor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementMaterialEditor.Text = "Material editor";
            // 
            // accordionControlElementViewRestocks
            // 
            this.accordionControlElementViewRestocks.Name = "accordionControlElementViewRestocks";
            this.accordionControlElementViewRestocks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementViewRestocks.Text = "View restocks";
            // 
            // accordionControlElementGanttChart
            // 
            this.accordionControlElementGanttChart.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementTaskEditor,
            this.accordionControlElementGroupEditor});
            this.accordionControlElementGanttChart.Expanded = true;
            this.accordionControlElementGanttChart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementGanttChart.ImageOptions.SvgImage")));
            this.accordionControlElementGanttChart.Name = "accordionControlElementGanttChart";
            this.accordionControlElementGanttChart.Text = "Production Monitor";
            // 
            // accordionControlElementTaskEditor
            // 
            this.accordionControlElementTaskEditor.Name = "accordionControlElementTaskEditor";
            this.accordionControlElementTaskEditor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementTaskEditor.Text = "Task editor";
            this.accordionControlElementTaskEditor.Click += new System.EventHandler(this.accordionControlElementTaskEditor_Click);
            // 
            // accordionControlElementGroupEditor
            // 
            this.accordionControlElementGroupEditor.Name = "accordionControlElementGroupEditor";
            this.accordionControlElementGroupEditor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementGroupEditor.Text = "Group editor";
            this.accordionControlElementGroupEditor.Click += new System.EventHandler(this.accordionControlElementGroupEditor_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement3.ImageOptions.SvgImage")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Finished Goods Inventory";
            // 
            // accordionControlElementSetting
            // 
            this.accordionControlElementSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementSetting.ImageOptions.SvgImage")));
            this.accordionControlElementSetting.Name = "accordionControlElementSetting";
            this.accordionControlElementSetting.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSetting.Text = "Settings";
            this.accordionControlElementSetting.Click += new System.EventHandler(this.accordionControlElementSetting_Click);
            // 
            // toolbarFormManager2
            // 
            this.toolbarFormManager2.DockControls.Add(this.barDockControl1);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl2);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl3);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl4);
            this.toolbarFormManager2.Form = this;
            this.toolbarFormManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemLicense,
            this.barToolbarsListItem1,
            this.skinPaletteDropDownButtonItem});
            this.toolbarFormManager2.MaxItemId = 5;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = this.toolbarFormManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 771);
            this.barDockControl2.Manager = this.toolbarFormManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.toolbarFormManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1280, 30);
            this.barDockControl4.Manager = this.toolbarFormManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 741);
            // 
            // barButtonItemLicense
            // 
            this.barButtonItemLicense.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemLicense.Caption = "License";
            this.barButtonItemLicense.Id = 0;
            this.barButtonItemLicense.Name = "barButtonItemLicense";
            this.barButtonItemLicense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLicense_ItemClick);
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "View";
            this.barToolbarsListItem1.Id = 2;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // skinPaletteDropDownButtonItem
            // 
            this.skinPaletteDropDownButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinPaletteDropDownButtonItem.Id = 4;
            this.skinPaletteDropDownButtonItem.Name = "skinPaletteDropDownButtonItem";
            // 
            // accountPopupMenu
            // 
            this.accountPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAccountSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLogout)});
            this.accountPopupMenu.Manager = this.toolbarFormManager1;
            this.accountPopupMenu.Name = "accountPopupMenu";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1195, 726);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1212, 54);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 54);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1212, 112);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 166);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1212, 353);
            // 
            // tabPane1
            // 
            this.tabPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tabPane1.Controls.Add(this.statusStrip);
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage6);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage7);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5,
            this.tabNavigationPage6,
            this.tabNavigationPage7});
            this.tabPane1.RegularSize = new System.Drawing.Size(1232, 608);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1232, 608);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.TransitionAnimationProperties.FrameCount = 200;
            this.tabPane1.TransitionAnimationProperties.FrameInterval = 5000;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 586);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.AutoScroll = true;
            this.tabNavigationPage1.Caption = "Production Overview";
            this.tabNavigationPage1.Controls.Add(this.panelControlOverview);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlOverview
            // 
            this.panelControlOverview.Controls.Add(this.layoutControl2);
            this.panelControlOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlOverview.Location = new System.Drawing.Point(0, 0);
            this.panelControlOverview.MinimumSize = new System.Drawing.Size(0, 1286);
            this.panelControlOverview.Name = "panelControlOverview";
            this.panelControlOverview.Size = new System.Drawing.Size(1215, 1286);
            this.panelControlOverview.TabIndex = 1;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.tileControlOverview);
            this.layoutControl2.Controls.Add(this.ganttControlOverview);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1210, 573, 650, 308);
            this.layoutControl2.Root = this.layoutControlGroup8;
            this.layoutControl2.Size = new System.Drawing.Size(1211, 1282);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // tileControlOverview
            // 
            this.tileControlOverview.AllowSmoothScrolling = false;
            this.tileControlOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileControlOverview.ColumnCount = 3;
            this.tileControlOverview.ContextButtonOptions.AnimationTime = 300;
            this.tileControlOverview.Groups.Add(this.groupGanttChart);
            this.tileControlOverview.Groups.Add(this.groupInventory);
            this.tileControlOverview.Groups.Add(this.tileGroup2);
            this.tileControlOverview.IndentBetweenGroups = 32;
            this.tileControlOverview.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            this.tileControlOverview.Location = new System.Drawing.Point(612, 41);
            this.tileControlOverview.MaxId = 16;
            this.tileControlOverview.Name = "tileControlOverview";
            this.tileControlOverview.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tileControlOverview.RowCount = 3;
            this.tileControlOverview.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileControlOverview.SelectionColor = System.Drawing.Color.Empty;
            this.tileControlOverview.Size = new System.Drawing.Size(583, 438);
            this.tileControlOverview.TabIndex = 0;
            this.tileControlOverview.Text = "tileControl1";
            // 
            // groupGanttChart
            // 
            this.groupGanttChart.Items.Add(this.tileGanttChart);
            this.groupGanttChart.Items.Add(this.tileItem2);
            this.groupGanttChart.Items.Add(this.tileItem1);
            this.groupGanttChart.Name = "groupGanttChart";
            // 
            // tileGanttChart
            // 
            this.tileGanttChart.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileGanttChart.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.tileGanttChart.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(60)))));
            this.tileGanttChart.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileGanttChart.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement1.ImageOptions.ImageSize = new System.Drawing.Size(64, 64);
            tileItemElement1.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement1.Text = "Gantt Chart";
            this.tileGanttChart.Elements.Add(tileItemElement1);
            this.tileGanttChart.Id = 12;
            this.tileGanttChart.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileGanttChart.Name = "tileGanttChart";
            toolTipItem1.Text = "View the current tasks";
            superToolTip1.Items.Add(toolTipItem1);
            this.tileGanttChart.SuperTip = superToolTip1;
            this.tileGanttChart.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem12_ItemClick);
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "tileItem2";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem1
            // 
            tileItemElement3.Text = "tileItem1";
            this.tileItem1.Elements.Add(tileItemElement3);
            this.tileItem1.Id = 11;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            // 
            // groupInventory
            // 
            this.groupInventory.Items.Add(this.tileInventory);
            this.groupInventory.Items.Add(this.tileEventM);
            this.groupInventory.Items.Add(this.tileItem7);
            this.groupInventory.Name = "groupInventory";
            // 
            // tileInventory
            // 
            this.tileInventory.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(0)))), ((int)(((byte)(142)))));
            this.tileInventory.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(30)))), ((int)(((byte)(202)))));
            this.tileInventory.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(0)))), ((int)(((byte)(142)))));
            this.tileInventory.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileInventory.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement4.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement4.Text = "Inventory";
            this.tileInventory.Elements.Add(tileItemElement4);
            this.tileInventory.Id = 3;
            this.tileInventory.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileInventory.Name = "tileInventory";
            this.tileInventory.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileInventory_ItemClick);
            // 
            // tileEventM
            // 
            this.tileEventM.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.tileEventM.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(245)))));
            this.tileEventM.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(180)))));
            this.tileEventM.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileEventM.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement5.ImageOptions.SvgImageSize = new System.Drawing.Size(48, 48);
            tileItemElement5.Text = "Jobs";
            this.tileEventM.Elements.Add(tileItemElement5);
            this.tileEventM.Id = 7;
            this.tileEventM.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileEventM.Name = "tileEventM";
            this.tileEventM.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileEventM_ItemClick);
            // 
            // tileItem7
            // 
            tileItemElement6.Text = "tileItem7";
            this.tileItem7.Elements.Add(tileItemElement6);
            this.tileItem7.Id = 6;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem4);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem5);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem4
            // 
            tileItemElement7.Text = "tileItem4";
            this.tileItem4.Elements.Add(tileItemElement7);
            this.tileItem4.Id = 14;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            // 
            // tileItem3
            // 
            tileItemElement8.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement8);
            this.tileItem3.Id = 13;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem5
            // 
            tileItemElement9.Text = "tileItem5";
            this.tileItem5.Elements.Add(tileItemElement9);
            this.tileItem5.Id = 15;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            // 
            // ganttControlOverview
            // 
            this.ganttControlOverview.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ID,
            this.ParentID,
            this.StartDate,
            this.FinishDate,
            this.Duration,
            this.BaselineStartDate,
            this.BaselineEndDate,
            this.Complete,
            this.Delay});
            this.ganttControlOverview.CustomizationFormBounds = new System.Drawing.Rectangle(1116, 229, 250, 290);
            this.ganttControlOverview.Location = new System.Drawing.Point(16, 41);
            this.ganttControlOverview.MenuManager = this.toolbarFormManager1;
            this.ganttControlOverview.Name = "ganttControlOverview";
            this.ganttControlOverview.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.ganttControlOverview.OptionsSplitter.PanelVisibility = DevExpress.XtraGantt.GanttPanelVisibility.Chart;
            this.ganttControlOverview.OptionsView.EnableAppearanceEvenRow = true;
            this.ganttControlOverview.OptionsView.ShowBaselines = true;
            this.ganttControlOverview.Size = new System.Drawing.Size(582, 438);
            this.ganttControlOverview.SplitterPosition = 87;
            this.ganttControlOverview.TabIndex = 0;
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup8.GroupBordersVisible = false;
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup9,
            this.layoutControlGroup10,
            this.splitterItem1});
            this.layoutControlGroup8.Name = "Root";
            this.layoutControlGroup8.Size = new System.Drawing.Size(1211, 1282);
            this.layoutControlGroup8.TextVisible = false;
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.splitterItem2});
            this.layoutControlGroup9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup9.Name = "layoutControlGroup9";
            this.layoutControlGroup9.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup9.Size = new System.Drawing.Size(1191, 475);
            this.layoutControlGroup9.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup9.Text = "Overview";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ganttControlOverview;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(586, 442);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tileControlOverview;
            this.layoutControlItem6.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(587, 442);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(586, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(10, 442);
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 485);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup10.Size = new System.Drawing.Size(1191, 777);
            this.layoutControlGroup10.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup10.Text = "Cards";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1183, 744);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 475);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(1191, 10);
            // 
            // tabNavigationPage6
            // 
            this.tabNavigationPage6.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.tabNavigationPage6.Appearance.Options.UseBorderColor = true;
            this.tabNavigationPage6.AutoScroll = true;
            this.tabNavigationPage6.Caption = "Production Monitor";
            this.tabNavigationPage6.Controls.Add(this.panelControlProductionMonitor);
            this.tabNavigationPage6.Controls.Add(this.xtraScrollableControl1);
            this.tabNavigationPage6.Name = "tabNavigationPage6";
            this.tabNavigationPage6.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlProductionMonitor
            // 
            this.panelControlProductionMonitor.AutoSize = true;
            this.panelControlProductionMonitor.Controls.Add(this.layoutControl1);
            this.panelControlProductionMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlProductionMonitor.Location = new System.Drawing.Point(0, 0);
            this.panelControlProductionMonitor.MinimumSize = new System.Drawing.Size(0, 1071);
            this.panelControlProductionMonitor.Name = "panelControlProductionMonitor";
            this.panelControlProductionMonitor.Size = new System.Drawing.Size(1232, 1071);
            this.panelControlProductionMonitor.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ganttChartHyperLinkLabelControl2);
            this.layoutControl1.Controls.Add(this.ganttChartChartSplitContainer);
            this.layoutControl1.Controls.Add(this.ganttChartHyperLinkLabelControl1);
            this.layoutControl1.Controls.Add(this.ganttChartLabelControlQuickLinks);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(760, 264, 650, 718);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1228, 1067);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ganttChartHyperLinkLabelControl2
            // 
            this.ganttChartHyperLinkLabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.ganttChartHyperLinkLabelControl2.Location = new System.Drawing.Point(22, 616);
            this.ganttChartHyperLinkLabelControl2.Name = "ganttChartHyperLinkLabelControl2";
            this.ganttChartHyperLinkLabelControl2.Size = new System.Drawing.Size(110, 14);
            this.ganttChartHyperLinkLabelControl2.StyleController = this.layoutControl1;
            this.ganttChartHyperLinkLabelControl2.TabIndex = 2;
            this.ganttChartHyperLinkLabelControl2.Text = "Open group editor..";
            this.ganttChartHyperLinkLabelControl2.Click += new System.EventHandler(this.hyperlinkLabelControl2_Click);
            // 
            // ganttChartChartSplitContainer
            // 
            this.ganttChartChartSplitContainer.Location = new System.Drawing.Point(13, 39);
            this.ganttChartChartSplitContainer.Name = "ganttChartChartSplitContainer";
            // 
            // ganttChartChartSplitContainer.Panel1
            // 
            this.ganttChartChartSplitContainer.Panel1.AutoScroll = true;
            this.ganttChartChartSplitContainer.Panel1.Controls.Add(this.ganttChartChartTreeListTableLayoutPanel);
            this.ganttChartChartSplitContainer.Panel1.MinSize = 200;
            this.ganttChartChartSplitContainer.Panel1.Text = "Panel1";
            // 
            // ganttChartChartSplitContainer.Panel2
            // 
            this.ganttChartChartSplitContainer.Panel2.Controls.Add(this.ganttChartChartOptionsPanel);
            this.ganttChartChartSplitContainer.Panel2.Controls.Add(this.ganttChartChart);
            this.ganttChartChartSplitContainer.Panel2.MinSize = 200;
            this.ganttChartChartSplitContainer.Panel2.Text = "Panel2";
            this.ganttChartChartSplitContainer.Size = new System.Drawing.Size(1202, 478);
            this.ganttChartChartSplitContainer.SplitterPosition = 375;
            this.ganttChartChartSplitContainer.TabIndex = 4;
            // 
            // ganttChartChartTreeListTableLayoutPanel
            // 
            this.ganttChartChartTreeListTableLayoutPanel.ColumnCount = 1;
            this.ganttChartChartTreeListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ganttChartChartTreeListTableLayoutPanel.Controls.Add(this.ganttChartChartProjectLabel, 0, 0);
            this.ganttChartChartTreeListTableLayoutPanel.Controls.Add(this.ganttChartChartTreeList, 0, 1);
            this.ganttChartChartTreeListTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttChartChartTreeListTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ganttChartChartTreeListTableLayoutPanel.Name = "ganttChartChartTreeListTableLayoutPanel";
            this.ganttChartChartTreeListTableLayoutPanel.RowCount = 2;
            this.ganttChartChartTreeListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ganttChartChartTreeListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ganttChartChartTreeListTableLayoutPanel.Size = new System.Drawing.Size(375, 478);
            this.ganttChartChartTreeListTableLayoutPanel.TabIndex = 2;
            // 
            // ganttChartChartProjectLabel
            // 
            this.ganttChartChartProjectLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganttChartChartProjectLabel.Appearance.Options.UseFont = true;
            this.ganttChartChartProjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttChartChartProjectLabel.Location = new System.Drawing.Point(3, 3);
            this.ganttChartChartProjectLabel.Name = "ganttChartChartProjectLabel";
            this.ganttChartChartProjectLabel.Size = new System.Drawing.Size(369, 34);
            this.ganttChartChartProjectLabel.TabIndex = 1;
            this.ganttChartChartProjectLabel.Text = "{project_title}";
            // 
            // ganttChartChartTreeList
            // 
            this.ganttChartChartTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttChartChartTreeList.Location = new System.Drawing.Point(3, 43);
            this.ganttChartChartTreeList.MenuManager = this.toolbarFormManager1;
            this.ganttChartChartTreeList.Name = "ganttChartChartTreeList";
            this.ganttChartChartTreeList.OptionsView.AutoWidth = false;
            this.ganttChartChartTreeList.Size = new System.Drawing.Size(369, 437);
            this.ganttChartChartTreeList.TabIndex = 0;
            // 
            // ganttChartChartOptionsPanel
            // 
            this.ganttChartChartOptionsPanel.AutoSize = true;
            this.ganttChartChartOptionsPanel.Controls.Add(this.m_TaskGrid);
            this.ganttChartChartOptionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ganttChartChartOptionsPanel.Location = new System.Drawing.Point(617, 0);
            this.ganttChartChartOptionsPanel.MaximumSize = new System.Drawing.Size(350, 1371);
            this.ganttChartChartOptionsPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.ganttChartChartOptionsPanel.Name = "ganttChartChartOptionsPanel";
            this.ganttChartChartOptionsPanel.Size = new System.Drawing.Size(200, 478);
            this.ganttChartChartOptionsPanel.TabIndex = 1;
            this.ganttChartChartOptionsPanel.Visible = false;
            // 
            // m_TaskGrid
            // 
            this.m_TaskGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_TaskGrid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TaskGrid.Location = new System.Drawing.Point(0, 0);
            this.m_TaskGrid.Name = "m_TaskGrid";
            this.m_TaskGrid.Size = new System.Drawing.Size(200, 478);
            this.m_TaskGrid.TabIndex = 0;
            // 
            // ganttChartChart
            // 
            this.ganttChartChart.BarHeight = 23;
            this.ganttChartChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttChartChart.ForeColor = System.Drawing.Color.Black;
            this.ganttChartChart.HeaderOneHeight = 33;
            this.ganttChartChart.HeaderTwoHeight = 26;
            this.ganttChartChart.Location = new System.Drawing.Point(0, 0);
            this.ganttChartChart.Margin = new System.Windows.Forms.Padding(0);
            this.ganttChartChart.Name = "ganttChartChart";
            this.ganttChartChart.Size = new System.Drawing.Size(817, 478);
            this.ganttChartChart.TabIndex = 0;
            // 
            // ganttChartHyperLinkLabelControl1
            // 
            this.ganttChartHyperLinkLabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.ganttChartHyperLinkLabelControl1.Location = new System.Drawing.Point(22, 598);
            this.ganttChartHyperLinkLabelControl1.Name = "ganttChartHyperLinkLabelControl1";
            this.ganttChartHyperLinkLabelControl1.Size = new System.Drawing.Size(100, 14);
            this.ganttChartHyperLinkLabelControl1.StyleController = this.layoutControl1;
            this.ganttChartHyperLinkLabelControl1.TabIndex = 3;
            this.ganttChartHyperLinkLabelControl1.Text = "Open task editor..";
            this.ganttChartHyperLinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // ganttChartLabelControlQuickLinks
            // 
            this.ganttChartLabelControlQuickLinks.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganttChartLabelControlQuickLinks.Appearance.Options.UseFont = true;
            this.ganttChartLabelControlQuickLinks.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.ganttChartLabelControlQuickLinks.Location = new System.Drawing.Point(22, 571);
            this.ganttChartLabelControlQuickLinks.Name = "ganttChartLabelControlQuickLinks";
            this.ganttChartLabelControlQuickLinks.Size = new System.Drawing.Size(93, 23);
            this.ganttChartLabelControlQuickLinks.StyleController = this.layoutControl1;
            this.ganttChartLabelControlQuickLinks.TabIndex = 0;
            this.ganttChartLabelControlQuickLinks.Text = "Quick Links";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup7,
            this.layoutControlGroup5,
            this.layoutControlGroup6,
            this.splitterItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 9, 9);
            this.Root.Size = new System.Drawing.Size(1228, 1067);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 635);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(1212, 414);
            this.layoutControlGroup7.Text = "Cards";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1188, 365);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Gantt Chart";
            this.layoutControlGroup5.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup5.Size = new System.Drawing.Size(1212, 513);
            this.layoutControlGroup5.Text = "Gantt Chart";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ganttChartChartSplitContainer;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1206, 482);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Actions";
            this.layoutControlGroup6.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem3});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 523);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(1212, 112);
            this.layoutControlGroup6.Text = "Actions";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ganttChartLabelControlQuickLinks;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1188, 27);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.ganttChartHyperLinkLabelControl2;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1188, 18);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ganttChartHyperLinkLabelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1188, 18);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem5
            // 
            this.splitterItem5.AllowHotTrack = true;
            this.splitterItem5.Location = new System.Drawing.Point(0, 513);
            this.splitterItem5.Name = "splitterItem5";
            this.splitterItem5.Size = new System.Drawing.Size(1212, 10);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1232, 581);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.AutoScroll = true;
            this.tabNavigationPage5.Caption = "Material Inventory";
            this.tabNavigationPage5.Controls.Add(this.panelControlMaterialInventory);
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlMaterialInventory
            // 
            this.panelControlMaterialInventory.Controls.Add(this.layoutControl3);
            this.panelControlMaterialInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMaterialInventory.Location = new System.Drawing.Point(0, 0);
            this.panelControlMaterialInventory.MinimumSize = new System.Drawing.Size(0, 1286);
            this.panelControlMaterialInventory.Name = "panelControlMaterialInventory";
            this.panelControlMaterialInventory.Size = new System.Drawing.Size(1232, 1286);
            this.panelControlMaterialInventory.TabIndex = 5;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.simpleButtonMaterialInventorySave);
            this.layoutControl3.Controls.Add(this.simpleButtonMaterialInventoryReserved);
            this.layoutControl3.Controls.Add(this.gridControlMaterialListing);
            this.layoutControl3.Controls.Add(this.dataGridView1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(2, 2);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(746, 332, 650, 400);
            this.layoutControl3.Root = this.layoutControlGroup11;
            this.layoutControl3.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // simpleButtonMaterialInventorySave
            // 
            this.simpleButtonMaterialInventorySave.Location = new System.Drawing.Point(157, 14);
            this.simpleButtonMaterialInventorySave.MaximumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMaterialInventorySave.MinimumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMaterialInventorySave.Name = "simpleButtonMaterialInventorySave";
            this.simpleButtonMaterialInventorySave.Size = new System.Drawing.Size(120, 22);
            this.simpleButtonMaterialInventorySave.StyleController = this.layoutControl3;
            this.simpleButtonMaterialInventorySave.TabIndex = 20;
            this.simpleButtonMaterialInventorySave.Text = "Save changes";
            this.simpleButtonMaterialInventorySave.Click += new System.EventHandler(this.simpleButtonMaterialInventorySave_Click);
            // 
            // simpleButtonMaterialInventoryReserved
            // 
            this.simpleButtonMaterialInventoryReserved.Location = new System.Drawing.Point(13, 14);
            this.simpleButtonMaterialInventoryReserved.MaximumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMaterialInventoryReserved.MinimumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMaterialInventoryReserved.Name = "simpleButtonMaterialInventoryReserved";
            this.simpleButtonMaterialInventoryReserved.Size = new System.Drawing.Size(120, 22);
            this.simpleButtonMaterialInventoryReserved.StyleController = this.layoutControl3;
            this.simpleButtonMaterialInventoryReserved.TabIndex = 15;
            this.simpleButtonMaterialInventoryReserved.Text = "(Reserved)";
            // 
            // gridControlMaterialListing
            // 
            this.gridControlMaterialListing.DataSource = this.mATERIAL_MSTBindingSource;
            this.gridControlMaterialListing.Location = new System.Drawing.Point(18, 70);
            this.gridControlMaterialListing.MainView = this.gridViewMaterialListing;
            this.gridControlMaterialListing.Name = "gridControlMaterialListing";
            this.gridControlMaterialListing.Size = new System.Drawing.Size(1192, 455);
            this.gridControlMaterialListing.TabIndex = 4;
            this.gridControlMaterialListing.UseEmbeddedNavigator = true;
            this.gridControlMaterialListing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialListing});
            // 
            // mATERIAL_MSTBindingSource
            // 
            this.mATERIAL_MSTBindingSource.DataMember = "MATERIAL_MST";
            this.mATERIAL_MSTBindingSource.DataSource = this.signes_MESDataSet;
            // 
            // gridViewMaterialListing
            // 
            this.gridViewMaterialListing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATERIAL_ID2,
            this.colMATERIAL_NAME2,
            this.colSITE_ID2,
            this.colPROD_ID2,
            this.colPROD_NM2,
            this.colPROD_MODEL2,
            this.colPROD_TYPE2,
            this.colPROD_CLASS_CODE2,
            this.colPROD_GRADE2,
            this.colPROD_GROUP_ID2,
            this.colPROC_ID2,
            this.colPROC_VER1,
            this.colDEL_YN2,
            this.colREASON_CODE2,
            this.colDESCR2,
            this.colCREATE_USER_ID2,
            this.colCREATE_DATE2,
            this.colUPDATE_USER_ID2,
            this.colUPDATE_DATE2,
            this.colQTY1});
            this.gridViewMaterialListing.DetailHeight = 375;
            this.gridViewMaterialListing.GridControl = this.gridControlMaterialListing;
            this.gridViewMaterialListing.Name = "gridViewMaterialListing";
            this.gridViewMaterialListing.OptionsView.ColumnAutoWidth = false;
            // 
            // colMATERIAL_ID2
            // 
            this.colMATERIAL_ID2.FieldName = "MATERIAL_ID";
            this.colMATERIAL_ID2.Name = "colMATERIAL_ID2";
            this.colMATERIAL_ID2.Visible = true;
            this.colMATERIAL_ID2.VisibleIndex = 0;
            // 
            // colMATERIAL_NAME2
            // 
            this.colMATERIAL_NAME2.FieldName = "MATERIAL_NAME";
            this.colMATERIAL_NAME2.Name = "colMATERIAL_NAME2";
            this.colMATERIAL_NAME2.Visible = true;
            this.colMATERIAL_NAME2.VisibleIndex = 1;
            // 
            // colSITE_ID2
            // 
            this.colSITE_ID2.FieldName = "SITE_ID";
            this.colSITE_ID2.Name = "colSITE_ID2";
            this.colSITE_ID2.Visible = true;
            this.colSITE_ID2.VisibleIndex = 2;
            // 
            // colPROD_ID2
            // 
            this.colPROD_ID2.FieldName = "PROD_ID";
            this.colPROD_ID2.Name = "colPROD_ID2";
            this.colPROD_ID2.Visible = true;
            this.colPROD_ID2.VisibleIndex = 3;
            // 
            // colPROD_NM2
            // 
            this.colPROD_NM2.FieldName = "PROD_NM";
            this.colPROD_NM2.Name = "colPROD_NM2";
            this.colPROD_NM2.Visible = true;
            this.colPROD_NM2.VisibleIndex = 4;
            // 
            // colPROD_MODEL2
            // 
            this.colPROD_MODEL2.FieldName = "PROD_MODEL";
            this.colPROD_MODEL2.Name = "colPROD_MODEL2";
            this.colPROD_MODEL2.Visible = true;
            this.colPROD_MODEL2.VisibleIndex = 5;
            // 
            // colPROD_TYPE2
            // 
            this.colPROD_TYPE2.FieldName = "PROD_TYPE";
            this.colPROD_TYPE2.Name = "colPROD_TYPE2";
            this.colPROD_TYPE2.Visible = true;
            this.colPROD_TYPE2.VisibleIndex = 6;
            // 
            // colPROD_CLASS_CODE2
            // 
            this.colPROD_CLASS_CODE2.FieldName = "PROD_CLASS_CODE";
            this.colPROD_CLASS_CODE2.Name = "colPROD_CLASS_CODE2";
            this.colPROD_CLASS_CODE2.Visible = true;
            this.colPROD_CLASS_CODE2.VisibleIndex = 7;
            // 
            // colPROD_GRADE2
            // 
            this.colPROD_GRADE2.FieldName = "PROD_GRADE";
            this.colPROD_GRADE2.Name = "colPROD_GRADE2";
            this.colPROD_GRADE2.Visible = true;
            this.colPROD_GRADE2.VisibleIndex = 8;
            // 
            // colPROD_GROUP_ID2
            // 
            this.colPROD_GROUP_ID2.FieldName = "PROD_GROUP_ID";
            this.colPROD_GROUP_ID2.Name = "colPROD_GROUP_ID2";
            this.colPROD_GROUP_ID2.Visible = true;
            this.colPROD_GROUP_ID2.VisibleIndex = 9;
            // 
            // colPROC_ID2
            // 
            this.colPROC_ID2.FieldName = "PROC_ID";
            this.colPROC_ID2.Name = "colPROC_ID2";
            this.colPROC_ID2.Visible = true;
            this.colPROC_ID2.VisibleIndex = 10;
            // 
            // colPROC_VER1
            // 
            this.colPROC_VER1.FieldName = "PROC_VER";
            this.colPROC_VER1.Name = "colPROC_VER1";
            this.colPROC_VER1.Visible = true;
            this.colPROC_VER1.VisibleIndex = 11;
            // 
            // colDEL_YN2
            // 
            this.colDEL_YN2.FieldName = "DEL_YN";
            this.colDEL_YN2.Name = "colDEL_YN2";
            this.colDEL_YN2.Visible = true;
            this.colDEL_YN2.VisibleIndex = 12;
            // 
            // colREASON_CODE2
            // 
            this.colREASON_CODE2.FieldName = "REASON_CODE";
            this.colREASON_CODE2.Name = "colREASON_CODE2";
            this.colREASON_CODE2.Visible = true;
            this.colREASON_CODE2.VisibleIndex = 13;
            // 
            // colDESCR2
            // 
            this.colDESCR2.FieldName = "DESCR";
            this.colDESCR2.Name = "colDESCR2";
            this.colDESCR2.Visible = true;
            this.colDESCR2.VisibleIndex = 14;
            // 
            // colCREATE_USER_ID2
            // 
            this.colCREATE_USER_ID2.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID2.Name = "colCREATE_USER_ID2";
            this.colCREATE_USER_ID2.Visible = true;
            this.colCREATE_USER_ID2.VisibleIndex = 15;
            // 
            // colCREATE_DATE2
            // 
            this.colCREATE_DATE2.FieldName = "CREATE_DATE";
            this.colCREATE_DATE2.Name = "colCREATE_DATE2";
            this.colCREATE_DATE2.Visible = true;
            this.colCREATE_DATE2.VisibleIndex = 16;
            // 
            // colUPDATE_USER_ID2
            // 
            this.colUPDATE_USER_ID2.FieldName = "UPDATE_USER_ID";
            this.colUPDATE_USER_ID2.Name = "colUPDATE_USER_ID2";
            this.colUPDATE_USER_ID2.Visible = true;
            this.colUPDATE_USER_ID2.VisibleIndex = 17;
            // 
            // colUPDATE_DATE2
            // 
            this.colUPDATE_DATE2.FieldName = "UPDATE_DATE";
            this.colUPDATE_DATE2.Name = "colUPDATE_DATE2";
            this.colUPDATE_DATE2.Visible = true;
            this.colUPDATE_DATE2.VisibleIndex = 18;
            // 
            // colQTY1
            // 
            this.colQTY1.FieldName = "QTY";
            this.colQTY1.Name = "colQTY1";
            this.colQTY1.Visible = true;
            this.colQTY1.VisibleIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 1246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 22);
            this.dataGridView1.TabIndex = 5;
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup11.GroupBordersVisible = false;
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup18,
            this.splitterItem6,
            this.layoutControlItem14,
            this.layoutControlItem29,
            this.layoutControlItem22,
            this.layoutControlGroup16,
            this.emptySpaceItem16,
            this.emptySpaceItem17});
            this.layoutControlGroup11.Name = "Root";
            this.layoutControlGroup11.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 9, 9);
            this.layoutControlGroup11.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControlGroup11.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup11.TextVisible = false;
            // 
            // layoutControlGroup18
            // 
            this.layoutControlGroup18.CustomizationFormText = "Actions";
            this.layoutControlGroup18.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup18.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem6});
            this.layoutControlGroup18.Location = new System.Drawing.Point(0, 530);
            this.layoutControlGroup18.Name = "layoutControlGroup18";
            this.layoutControlGroup18.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 9, 9);
            this.layoutControlGroup18.Size = new System.Drawing.Size(1206, 702);
            this.layoutControlGroup18.Text = "Actions";
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(1184, 653);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem6
            // 
            this.splitterItem6.AllowHotTrack = true;
            this.splitterItem6.Location = new System.Drawing.Point(0, 520);
            this.splitterItem6.Name = "splitterItem6";
            this.splitterItem6.Size = new System.Drawing.Size(1206, 10);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.dataGridView1;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 1232);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(1206, 26);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(112, 14);
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.simpleButtonMaterialInventoryReserved;
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem29.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem29.TextVisible = false;
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.simpleButtonMaterialInventorySave;
            this.layoutControlItem22.Location = new System.Drawing.Point(144, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // layoutControlGroup16
            // 
            this.layoutControlGroup16.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup16.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem30});
            this.layoutControlGroup16.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup16.Name = "layoutControlGroup16";
            this.layoutControlGroup16.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup16.Size = new System.Drawing.Size(1206, 494);
            this.layoutControlGroup16.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup16.Text = "Material Inventory";
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.Control = this.gridControlMaterialListing;
            this.layoutControlItem30.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem30.Name = "layoutControlItem30";
            this.layoutControlItem30.Size = new System.Drawing.Size(1196, 459);
            this.layoutControlItem30.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem30.TextVisible = false;
            // 
            // emptySpaceItem16
            // 
            this.emptySpaceItem16.AllowHotTrack = false;
            this.emptySpaceItem16.Location = new System.Drawing.Point(124, 0);
            this.emptySpaceItem16.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem16.MinSize = new System.Drawing.Size(20, 11);
            this.emptySpaceItem16.Name = "emptySpaceItem16";
            this.emptySpaceItem16.Size = new System.Drawing.Size(20, 26);
            this.emptySpaceItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem16.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem17
            // 
            this.emptySpaceItem17.AllowHotTrack = false;
            this.emptySpaceItem17.Location = new System.Drawing.Point(268, 0);
            this.emptySpaceItem17.Name = "emptySpaceItem17";
            this.emptySpaceItem17.Size = new System.Drawing.Size(938, 26);
            this.emptySpaceItem17.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.AutoScroll = true;
            this.tabNavigationPage4.Caption = "Job Dispatch";
            this.tabNavigationPage4.Controls.Add(this.panelControlJobDispatch);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlJobDispatch
            // 
            this.panelControlJobDispatch.Controls.Add(this.layoutControl4);
            this.panelControlJobDispatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlJobDispatch.Location = new System.Drawing.Point(0, 0);
            this.panelControlJobDispatch.MinimumSize = new System.Drawing.Size(0, 1286);
            this.panelControlJobDispatch.Name = "panelControlJobDispatch";
            this.panelControlJobDispatch.Size = new System.Drawing.Size(1215, 1286);
            this.panelControlJobDispatch.TabIndex = 5;
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.labelControl5);
            this.layoutControl4.Controls.Add(this.labelControl4);
            this.layoutControl4.Controls.Add(this.labelControl3);
            this.layoutControl4.Controls.Add(this.eventManagerEventStackPanel2);
            this.layoutControl4.Controls.Add(this.eventManagerEventStackPanel1);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(2, 2);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(778, 218, 650, 400);
            this.layoutControl4.Root = this.layoutControlGroup12;
            this.layoutControl4.Size = new System.Drawing.Size(1211, 1282);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(326, 43);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(303, 14);
            this.labelControl5.StyleController = this.layoutControl4;
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Event Stack #2";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 1261);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 14);
            this.labelControl4.StyleController = this.layoutControl4;
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "labelControl4";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(17, 43);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(297, 14);
            this.labelControl3.StyleController = this.layoutControl4;
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Event Stack #1";
            // 
            // eventManagerEventStackPanel2
            // 
            this.eventManagerEventStackPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventManagerEventStackPanel2.AutoScroll = true;
            this.eventManagerEventStackPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.eventManagerEventStackPanel2.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.eventManagerEventStackPanel2.Location = new System.Drawing.Point(327, 60);
            this.eventManagerEventStackPanel2.Name = "eventManagerEventStackPanel2";
            this.eventManagerEventStackPanel2.Size = new System.Drawing.Size(301, 378);
            this.eventManagerEventStackPanel2.TabIndex = 5;
            // 
            // eventManagerEventStackPanel1
            // 
            this.eventManagerEventStackPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.eventManagerEventStackPanel1.AutoScroll = true;
            this.eventManagerEventStackPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.eventManagerEventStackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.eventManagerEventStackPanel1.Location = new System.Drawing.Point(18, 60);
            this.eventManagerEventStackPanel1.Name = "eventManagerEventStackPanel1";
            this.eventManagerEventStackPanel1.Size = new System.Drawing.Size(295, 378);
            this.eventManagerEventStackPanel1.TabIndex = 4;
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup12.GroupBordersVisible = false;
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup13,
            this.layoutControlGroup14,
            this.layoutControlGroup15,
            this.splitterItem4,
            this.layoutControlItem12});
            this.layoutControlGroup12.Name = "Root";
            this.layoutControlGroup12.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup12.Size = new System.Drawing.Size(1211, 1282);
            this.layoutControlGroup12.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup12.TextVisible = false;
            // 
            // layoutControlGroup13
            // 
            this.layoutControlGroup13.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlGroup19,
            this.layoutControlGroup20,
            this.splitterItem3});
            this.layoutControlGroup13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup13.Name = "layoutControlGroup13";
            this.layoutControlGroup13.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 9, 9);
            this.layoutControlGroup13.Size = new System.Drawing.Size(636, 447);
            this.layoutControlGroup13.Text = "Dispatch Events";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.eventManagerEventStackPanel1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 16);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(299, 382);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.eventManagerEventStackPanel2;
            this.layoutControlItem11.Location = new System.Drawing.Point(309, 16);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(305, 382);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlGroup19
            // 
            this.layoutControlGroup19.AppearanceGroup.BackColor = System.Drawing.Color.Gray;
            this.layoutControlGroup19.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup19.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup19.Name = "layoutControlGroup19";
            this.layoutControlGroup19.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup19.Size = new System.Drawing.Size(299, 16);
            this.layoutControlGroup19.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup19.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl3;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem7.Size = new System.Drawing.Size(297, 14);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup20
            // 
            this.layoutControlGroup20.AppearanceGroup.BackColor = System.Drawing.Color.Gray;
            this.layoutControlGroup20.AppearanceGroup.BackColor2 = System.Drawing.Color.Silver;
            this.layoutControlGroup20.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup20.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem13});
            this.layoutControlGroup20.Location = new System.Drawing.Point(309, 0);
            this.layoutControlGroup20.Name = "layoutControlGroup20";
            this.layoutControlGroup20.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup20.Size = new System.Drawing.Size(305, 16);
            this.layoutControlGroup20.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup20.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.labelControl5;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem13.Size = new System.Drawing.Size(303, 14);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.Location = new System.Drawing.Point(299, 0);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(10, 398);
            // 
            // layoutControlGroup14
            // 
            this.layoutControlGroup14.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup14.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem3});
            this.layoutControlGroup14.Location = new System.Drawing.Point(646, 0);
            this.layoutControlGroup14.Name = "layoutControlGroup14";
            this.layoutControlGroup14.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 9, 9);
            this.layoutControlGroup14.Size = new System.Drawing.Size(555, 447);
            this.layoutControlGroup14.Text = "Stats";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(533, 398);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup15
            // 
            this.layoutControlGroup15.CustomizationFormText = "Other Information";
            this.layoutControlGroup15.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup15.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem4});
            this.layoutControlGroup15.Location = new System.Drawing.Point(0, 447);
            this.layoutControlGroup15.Name = "layoutControlGroup15";
            this.layoutControlGroup15.Size = new System.Drawing.Size(1201, 807);
            this.layoutControlGroup15.Text = "Other Information";
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(1177, 758);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem4
            // 
            this.splitterItem4.AllowHotTrack = true;
            this.splitterItem4.Location = new System.Drawing.Point(636, 0);
            this.splitterItem4.Name = "splitterItem4";
            this.splitterItem4.Size = new System.Drawing.Size(10, 447);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.labelControl4;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 1254);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(1201, 18);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.AutoScroll = true;
            this.tabNavigationPage3.Caption = "Manufacturing Order";
            this.tabNavigationPage3.Controls.Add(this.panelControlManufacturingOrder);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlManufacturingOrder
            // 
            this.panelControlManufacturingOrder.AutoSize = true;
            this.panelControlManufacturingOrder.Controls.Add(this.layoutControlManufacturingOrder);
            this.panelControlManufacturingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlManufacturingOrder.Location = new System.Drawing.Point(0, 0);
            this.panelControlManufacturingOrder.MinimumSize = new System.Drawing.Size(0, 1286);
            this.panelControlManufacturingOrder.Name = "panelControlManufacturingOrder";
            this.panelControlManufacturingOrder.Size = new System.Drawing.Size(1232, 1286);
            this.panelControlManufacturingOrder.TabIndex = 0;
            // 
            // layoutControlManufacturingOrder
            // 
            this.layoutControlManufacturingOrder.Controls.Add(this.simpleButtonMOAddStep);
            this.layoutControlManufacturingOrder.Controls.Add(this.simpleButtonMOSave);
            this.layoutControlManufacturingOrder.Controls.Add(this.gridControlManufacturingOrder);
            this.layoutControlManufacturingOrder.Controls.Add(this.lookUpEditMOProductFilter);
            this.layoutControlManufacturingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlManufacturingOrder.Location = new System.Drawing.Point(2, 2);
            this.layoutControlManufacturingOrder.Name = "layoutControlManufacturingOrder";
            this.layoutControlManufacturingOrder.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(524, 450, 650, 400);
            this.layoutControlManufacturingOrder.Root = this.layoutControlGroup27;
            this.layoutControlManufacturingOrder.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControlManufacturingOrder.TabIndex = 0;
            // 
            // simpleButtonMOAddStep
            // 
            this.simpleButtonMOAddStep.Location = new System.Drawing.Point(573, 12);
            this.simpleButtonMOAddStep.MaximumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMOAddStep.MinimumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMOAddStep.Name = "simpleButtonMOAddStep";
            this.simpleButtonMOAddStep.Size = new System.Drawing.Size(120, 22);
            this.simpleButtonMOAddStep.StyleController = this.layoutControlManufacturingOrder;
            this.simpleButtonMOAddStep.TabIndex = 20;
            this.simpleButtonMOAddStep.Text = "Add Step";
            this.simpleButtonMOAddStep.Click += new System.EventHandler(this.simpleButtonMOAddStep_Click);
            // 
            // simpleButtonMOSave
            // 
            this.simpleButtonMOSave.Location = new System.Drawing.Point(429, 12);
            this.simpleButtonMOSave.MaximumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMOSave.MinimumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonMOSave.Name = "simpleButtonMOSave";
            this.simpleButtonMOSave.Size = new System.Drawing.Size(120, 22);
            this.simpleButtonMOSave.StyleController = this.layoutControlManufacturingOrder;
            this.simpleButtonMOSave.TabIndex = 2;
            this.simpleButtonMOSave.Text = "Save Changes";
            this.simpleButtonMOSave.Click += new System.EventHandler(this.simpleButtonManufacturingOrderSave_Click);
            // 
            // lookUpEditMOProductFilter
            // 
            this.lookUpEditMOProductFilter.EditValue = "Search product ID, name..";
            this.lookUpEditMOProductFilter.Location = new System.Drawing.Point(109, 12);
            this.lookUpEditMOProductFilter.MenuManager = this.toolbarFormManager1;
            this.lookUpEditMOProductFilter.MinimumSize = new System.Drawing.Size(290, 0);
            this.lookUpEditMOProductFilter.Name = "lookUpEditMOProductFilter";
            this.lookUpEditMOProductFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMOProductFilter.Properties.DataSource = this.mMPRODMSTBindingSource;
            this.lookUpEditMOProductFilter.Properties.DisplayMember = "PROD_ID";
            this.lookUpEditMOProductFilter.Properties.NullText = "Search product ID, name..";
            this.lookUpEditMOProductFilter.Properties.PopupView = this.searchLookUpEdit1View;
            this.lookUpEditMOProductFilter.Properties.ValueMember = "PROD_ID";
            this.lookUpEditMOProductFilter.Size = new System.Drawing.Size(296, 20);
            this.lookUpEditMOProductFilter.StyleController = this.layoutControlManufacturingOrder;
            this.lookUpEditMOProductFilter.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup27
            // 
            this.layoutControlGroup27.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup27.GroupBordersVisible = false;
            this.layoutControlGroup27.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.splitterItem10,
            this.layoutControlGroup29,
            this.layoutControlGroup30,
            this.emptySpaceItem18,
            this.layoutControlItem31,
            this.emptySpaceItem19,
            this.layoutControlItem33,
            this.layoutControlItem32,
            this.emptySpaceItem11});
            this.layoutControlGroup27.Name = "Root";
            this.layoutControlGroup27.Size = new System.Drawing.Size(1228, 1282);
            // 
            // splitterItem10
            // 
            this.splitterItem10.AllowHotTrack = true;
            this.splitterItem10.Location = new System.Drawing.Point(0, 531);
            this.splitterItem10.Name = "splitterItem10";
            this.splitterItem10.Size = new System.Drawing.Size(1208, 10);
            // 
            // layoutControlGroup29
            // 
            this.layoutControlGroup29.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup29.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem26});
            this.layoutControlGroup29.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup29.Name = "layoutControlGroup29";
            this.layoutControlGroup29.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup29.Size = new System.Drawing.Size(1208, 505);
            this.layoutControlGroup29.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup29.Text = "Manufacturing Order";
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.gridControlManufacturingOrder;
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(1198, 470);
            this.layoutControlItem26.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem26.TextVisible = false;
            // 
            // layoutControlGroup30
            // 
            this.layoutControlGroup30.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup30.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem14});
            this.layoutControlGroup30.Location = new System.Drawing.Point(0, 541);
            this.layoutControlGroup30.Name = "layoutControlGroup30";
            this.layoutControlGroup30.Size = new System.Drawing.Size(1208, 721);
            this.layoutControlGroup30.Text = "Actions";
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(1184, 672);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem18
            // 
            this.emptySpaceItem18.AllowHotTrack = false;
            this.emptySpaceItem18.Location = new System.Drawing.Point(685, 0);
            this.emptySpaceItem18.Name = "emptySpaceItem18";
            this.emptySpaceItem18.Size = new System.Drawing.Size(523, 26);
            this.emptySpaceItem18.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.simpleButtonMOSave;
            this.layoutControlItem31.Location = new System.Drawing.Point(417, 0);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem31.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem31.TextVisible = false;
            // 
            // emptySpaceItem19
            // 
            this.emptySpaceItem19.AllowHotTrack = false;
            this.emptySpaceItem19.Location = new System.Drawing.Point(397, 0);
            this.emptySpaceItem19.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem19.MinSize = new System.Drawing.Size(20, 11);
            this.emptySpaceItem19.Name = "emptySpaceItem19";
            this.emptySpaceItem19.Size = new System.Drawing.Size(20, 26);
            this.emptySpaceItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem19.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.lookUpEditMOProductFilter;
            this.layoutControlItem33.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Size = new System.Drawing.Size(397, 26);
            this.layoutControlItem33.Text = "Select product:";
            this.layoutControlItem33.TextSize = new System.Drawing.Size(85, 14);
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Control = this.simpleButtonMOAddStep;
            this.layoutControlItem32.Location = new System.Drawing.Point(561, 0);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem32.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem32.TextVisible = false;
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(541, 0);
            this.emptySpaceItem11.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem11.MinSize = new System.Drawing.Size(20, 10);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(20, 26);
            this.emptySpaceItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.AutoScroll = true;
            this.tabNavigationPage2.Caption = "BOM";
            this.tabNavigationPage2.Controls.Add(this.panelControlBOM);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlBOM
            // 
            this.panelControlBOM.AutoSize = true;
            this.panelControlBOM.Controls.Add(this.layoutControl5);
            this.panelControlBOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBOM.Location = new System.Drawing.Point(0, 0);
            this.panelControlBOM.MinimumSize = new System.Drawing.Size(0, 1286);
            this.panelControlBOM.Name = "panelControlBOM";
            this.panelControlBOM.Size = new System.Drawing.Size(1232, 1286);
            this.panelControlBOM.TabIndex = 0;
            // 
            // layoutControl5
            // 
            this.layoutControl5.Controls.Add(this.simpleButtonBOMAddMaterial);
            this.layoutControl5.Controls.Add(this.simpleButton2);
            this.layoutControl5.Controls.Add(this.simpleButton1);
            this.layoutControl5.Controls.Add(this.gridControlBOM);
            this.layoutControl5.Controls.Add(this.tablePanel1);
            this.layoutControl5.Controls.Add(this.simpleButtonBOMAddProduct);
            this.layoutControl5.Controls.Add(this.searchControlBOM);
            this.layoutControl5.Controls.Add(this.dropDownButtonBOM);
            this.layoutControl5.Controls.Add(this.simpleButtonBOMSave);
            this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl5.Location = new System.Drawing.Point(2, 2);
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(565, 390, 650, 400);
            this.layoutControl5.Root = this.layoutControlGroup21;
            this.layoutControl5.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControl5.TabIndex = 7;
            this.layoutControl5.Text = "layoutControl5";
            // 
            // simpleButtonBOMAddMaterial
            // 
            this.simpleButtonBOMAddMaterial.Location = new System.Drawing.Point(689, 12);
            this.simpleButtonBOMAddMaterial.MaximumSize = new System.Drawing.Size(116, 0);
            this.simpleButtonBOMAddMaterial.Name = "simpleButtonBOMAddMaterial";
            this.simpleButtonBOMAddMaterial.Size = new System.Drawing.Size(107, 22);
            this.simpleButtonBOMAddMaterial.StyleController = this.layoutControl5;
            this.simpleButtonBOMAddMaterial.TabIndex = 4;
            this.simpleButtonBOMAddMaterial.Text = "Add material";
            this.simpleButtonBOMAddMaterial.Click += new System.EventHandler(this.simpleButtonBOMAddMaterial_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 1248);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(1204, 22);
            this.simpleButton2.StyleController = this.layoutControl5;
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 1222);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(1204, 22);
            this.simpleButton1.StyleController = this.layoutControl5;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 22.24F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37.76F)});
            this.tablePanel1.Controls.Add(this.linkLabel1);
            this.tablePanel1.Location = new System.Drawing.Point(24, 546);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1180, 270);
            this.tablePanel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.tablePanel1.SetColumn(this.linkLabel1, 0);
            this.linkLabel1.Location = new System.Drawing.Point(3, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.tablePanel1.SetRow(this.linkLabel1, 0);
            this.linkLabel1.Size = new System.Drawing.Size(99, 14);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open bulk editor";
            // 
            // simpleButtonBOMAddProduct
            // 
            this.simpleButtonBOMAddProduct.Location = new System.Drawing.Point(561, 12);
            this.simpleButtonBOMAddProduct.MaximumSize = new System.Drawing.Size(116, 0);
            this.simpleButtonBOMAddProduct.Name = "simpleButtonBOMAddProduct";
            this.simpleButtonBOMAddProduct.Size = new System.Drawing.Size(107, 22);
            this.simpleButtonBOMAddProduct.StyleController = this.layoutControl5;
            this.simpleButtonBOMAddProduct.TabIndex = 3;
            this.simpleButtonBOMAddProduct.Text = "Add Product";
            this.simpleButtonBOMAddProduct.Click += new System.EventHandler(this.simpleButtonBOMAddProduct_Click);
            // 
            // searchControlBOM
            // 
            this.searchControlBOM.Location = new System.Drawing.Point(245, 12);
            this.searchControlBOM.MenuManager = this.toolbarFormManager1;
            this.searchControlBOM.MinimumSize = new System.Drawing.Size(290, 0);
            this.searchControlBOM.Name = "searchControlBOM";
            this.searchControlBOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControlBOM.Size = new System.Drawing.Size(295, 20);
            this.searchControlBOM.StyleController = this.layoutControl5;
            this.searchControlBOM.TabIndex = 2;
            // 
            // dropDownButtonBOM
            // 
            this.dropDownButtonBOM.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButtonBOM.DropDownControl = this.viewPopupMenu;
            this.dropDownButtonBOM.Location = new System.Drawing.Point(12, 12);
            this.dropDownButtonBOM.MaximumSize = new System.Drawing.Size(210, 0);
            this.dropDownButtonBOM.MenuManager = this.toolbarFormManager1;
            this.dropDownButtonBOM.MinimumSize = new System.Drawing.Size(210, 0);
            this.dropDownButtonBOM.Name = "dropDownButtonBOM";
            this.dropDownButtonBOM.Size = new System.Drawing.Size(210, 22);
            this.dropDownButtonBOM.StyleController = this.layoutControl5;
            this.dropDownButtonBOM.TabIndex = 0;
            this.dropDownButtonBOM.Text = "dropDownButtonBOM";
            // 
            // simpleButtonBOMSave
            // 
            this.simpleButtonBOMSave.Location = new System.Drawing.Point(818, 12);
            this.simpleButtonBOMSave.MaximumSize = new System.Drawing.Size(116, 0);
            this.simpleButtonBOMSave.Name = "simpleButtonBOMSave";
            this.simpleButtonBOMSave.Size = new System.Drawing.Size(107, 22);
            this.simpleButtonBOMSave.StyleController = this.layoutControl5;
            this.simpleButtonBOMSave.TabIndex = 5;
            this.simpleButtonBOMSave.Text = "Save Changes";
            this.simpleButtonBOMSave.Click += new System.EventHandler(this.simpleButtonBOMSave_Click);
            // 
            // layoutControlGroup21
            // 
            this.layoutControlGroup21.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup21.GroupBordersVisible = false;
            this.layoutControlGroup21.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup22,
            this.layoutControlItem15,
            this.emptySpaceItem9,
            this.layoutControlItem17,
            this.emptySpaceItem10,
            this.layoutControlItem8,
            this.layoutControlItem19,
            this.layoutControlItem24,
            this.layoutControlItem25,
            this.emptySpaceItem7,
            this.emptySpaceItem13,
            this.layoutControlItem16,
            this.emptySpaceItem8});
            this.layoutControlGroup21.Name = "Root";
            this.layoutControlGroup21.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControlGroup21.TextVisible = false;
            // 
            // layoutControlGroup22
            // 
            this.layoutControlGroup22.CustomizationFormText = "Product Listing";
            this.layoutControlGroup22.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup22.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem23,
            this.emptySpaceItem12,
            this.splitterItem8,
            this.layoutControlGroup23});
            this.layoutControlGroup22.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup22.Name = "layoutControlGroup22";
            this.layoutControlGroup22.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup22.Size = new System.Drawing.Size(1208, 1184);
            this.layoutControlGroup22.Text = "Product Listing";
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.gridControlBOM;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(1196, 436);
            this.layoutControlItem23.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem23.TextVisible = false;
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(0, 767);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(1196, 380);
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem8
            // 
            this.splitterItem8.AllowHotTrack = true;
            this.splitterItem8.Location = new System.Drawing.Point(0, 436);
            this.splitterItem8.Name = "splitterItem8";
            this.splitterItem8.Size = new System.Drawing.Size(1196, 10);
            // 
            // layoutControlGroup23
            // 
            this.layoutControlGroup23.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup23.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup23.CustomizationFormText = "Quick Links";
            this.layoutControlGroup23.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup23.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem18,
            this.splitterItem9});
            this.layoutControlGroup23.Location = new System.Drawing.Point(0, 446);
            this.layoutControlGroup23.Name = "layoutControlGroup23";
            this.layoutControlGroup23.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup23.Size = new System.Drawing.Size(1196, 321);
            this.layoutControlGroup23.Text = "Actions";
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.tablePanel1;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(1184, 274);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // splitterItem9
            // 
            this.splitterItem9.AllowHotTrack = true;
            this.splitterItem9.Location = new System.Drawing.Point(0, 274);
            this.splitterItem9.Name = "splitterItem9";
            this.splitterItem9.Size = new System.Drawing.Size(1184, 10);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.dropDownButtonBOM;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(214, 26);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(214, 0);
            this.emptySpaceItem9.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem9.MinSize = new System.Drawing.Size(10, 11);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(19, 26);
            this.emptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.searchControlBOM;
            this.layoutControlItem17.Location = new System.Drawing.Point(233, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(299, 26);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem17.TextVisible = false;
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(532, 0);
            this.emptySpaceItem10.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem10.MinSize = new System.Drawing.Size(10, 11);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(17, 26);
            this.emptySpaceItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.simpleButtonBOMAddProduct;
            this.layoutControlItem8.Location = new System.Drawing.Point(549, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.simpleButton1;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 1210);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(1208, 26);
            this.layoutControlItem19.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem19.TextVisible = false;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.simpleButton2;
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 1236);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(1208, 26);
            this.layoutControlItem24.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem24.TextVisible = false;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.simpleButtonBOMAddMaterial;
            this.layoutControlItem25.Location = new System.Drawing.Point(677, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(660, 0);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(10, 11);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(17, 26);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(917, 0);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(291, 26);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.simpleButtonBOMSave;
            this.layoutControlItem16.Location = new System.Drawing.Point(806, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(788, 0);
            this.emptySpaceItem8.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem8.MinSize = new System.Drawing.Size(10, 11);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(18, 26);
            this.emptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabNavigationPage7
            // 
            this.tabNavigationPage7.AutoScroll = true;
            this.tabNavigationPage7.Caption = "Finished Goods Inventory";
            this.tabNavigationPage7.Controls.Add(this.panelControlFinishedGoodsInventory);
            this.tabNavigationPage7.Name = "tabNavigationPage7";
            this.tabNavigationPage7.PageText = "";
            this.tabNavigationPage7.Size = new System.Drawing.Size(1232, 581);
            // 
            // panelControlFinishedGoodsInventory
            // 
            this.panelControlFinishedGoodsInventory.AutoSize = true;
            this.panelControlFinishedGoodsInventory.Controls.Add(this.layoutControl6);
            this.panelControlFinishedGoodsInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlFinishedGoodsInventory.Location = new System.Drawing.Point(0, 0);
            this.panelControlFinishedGoodsInventory.MinimumSize = new System.Drawing.Size(0, 1286);
            this.panelControlFinishedGoodsInventory.Name = "panelControlFinishedGoodsInventory";
            this.panelControlFinishedGoodsInventory.Size = new System.Drawing.Size(1232, 1286);
            this.panelControlFinishedGoodsInventory.TabIndex = 7;
            // 
            // layoutControl6
            // 
            this.layoutControl6.Controls.Add(this.simpleButtonFinishedGoodsReserved);
            this.layoutControl6.Controls.Add(this.simpleButtonFinishedGoodsSave);
            this.layoutControl6.Controls.Add(this.gridControlFinishedGoods);
            this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl6.Location = new System.Drawing.Point(2, 2);
            this.layoutControl6.Name = "layoutControl6";
            this.layoutControl6.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(518, 413, 650, 400);
            this.layoutControl6.Root = this.layoutControlGroup25;
            this.layoutControl6.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControl6.TabIndex = 0;
            this.layoutControl6.Text = "layoutControl6";
            // 
            // simpleButtonFinishedGoodsReserved
            // 
            this.simpleButtonFinishedGoodsReserved.Location = new System.Drawing.Point(12, 12);
            this.simpleButtonFinishedGoodsReserved.MaximumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonFinishedGoodsReserved.MinimumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonFinishedGoodsReserved.Name = "simpleButtonFinishedGoodsReserved";
            this.simpleButtonFinishedGoodsReserved.Size = new System.Drawing.Size(120, 22);
            this.simpleButtonFinishedGoodsReserved.StyleController = this.layoutControl6;
            this.simpleButtonFinishedGoodsReserved.TabIndex = 15;
            this.simpleButtonFinishedGoodsReserved.Text = "(Reserved)";
            // 
            // simpleButtonFinishedGoodsSave
            // 
            this.simpleButtonFinishedGoodsSave.Location = new System.Drawing.Point(156, 12);
            this.simpleButtonFinishedGoodsSave.MaximumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonFinishedGoodsSave.MinimumSize = new System.Drawing.Size(120, 0);
            this.simpleButtonFinishedGoodsSave.Name = "simpleButtonFinishedGoodsSave";
            this.simpleButtonFinishedGoodsSave.Size = new System.Drawing.Size(120, 22);
            this.simpleButtonFinishedGoodsSave.StyleController = this.layoutControl6;
            this.simpleButtonFinishedGoodsSave.TabIndex = 15;
            this.simpleButtonFinishedGoodsSave.Text = "Save Changes";
            this.simpleButtonFinishedGoodsSave.Click += new System.EventHandler(this.simpleButtonFinishedGoodsSave_Click);
            // 
            // gridControlFinishedGoods
            // 
            this.gridControlFinishedGoods.DataSource = this.fINISHEDMSTBindingSource1;
            this.gridControlFinishedGoods.Location = new System.Drawing.Point(17, 68);
            this.gridControlFinishedGoods.MainView = this.gridViewFinishedGoods;
            this.gridControlFinishedGoods.Name = "gridControlFinishedGoods";
            this.gridControlFinishedGoods.Size = new System.Drawing.Size(1194, 457);
            this.gridControlFinishedGoods.TabIndex = 4;
            this.gridControlFinishedGoods.UseEmbeddedNavigator = true;
            this.gridControlFinishedGoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFinishedGoods});
            // 
            // fINISHEDMSTBindingSource1
            // 
            this.fINISHEDMSTBindingSource1.DataMember = "FINISHED_MST";
            this.fINISHEDMSTBindingSource1.DataSource = this.signes_MESDataSet;
            // 
            // gridViewFinishedGoods
            // 
            this.gridViewFinishedGoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDUID1,
            this.colEVENT_TIME,
            this.colQTY2,
            this.colPROD_ID4,
            this.colCREATE_USER,
            this.colCREATE_DATE4,
            this.colPROD_GROUP_ID3,
            this.colSITE_ID5,
            this.colPROC_ID5,
            this.colPROD_CLASS_CODE3,
            this.colPROD_NM3,
            this.colPROD_TYPE3,
            this.colSUB_PROD_TYPE,
            this.colPROD_GRADE3,
            this.colPROD_MODEL3});
            this.gridViewFinishedGoods.DetailHeight = 375;
            this.gridViewFinishedGoods.GridControl = this.gridControlFinishedGoods;
            this.gridViewFinishedGoods.Name = "gridViewFinishedGoods";
            this.gridViewFinishedGoods.OptionsView.ColumnAutoWidth = false;
            // 
            // colDUID1
            // 
            this.colDUID1.FieldName = "DUID";
            this.colDUID1.Name = "colDUID1";
            this.colDUID1.Visible = true;
            this.colDUID1.VisibleIndex = 0;
            // 
            // colEVENT_TIME
            // 
            this.colEVENT_TIME.FieldName = "EVENT_TIME";
            this.colEVENT_TIME.Name = "colEVENT_TIME";
            this.colEVENT_TIME.Visible = true;
            this.colEVENT_TIME.VisibleIndex = 1;
            // 
            // colQTY2
            // 
            this.colQTY2.FieldName = "QTY";
            this.colQTY2.Name = "colQTY2";
            this.colQTY2.Visible = true;
            this.colQTY2.VisibleIndex = 2;
            // 
            // colPROD_ID4
            // 
            this.colPROD_ID4.FieldName = "PROD_ID";
            this.colPROD_ID4.Name = "colPROD_ID4";
            this.colPROD_ID4.Visible = true;
            this.colPROD_ID4.VisibleIndex = 3;
            // 
            // colCREATE_USER
            // 
            this.colCREATE_USER.FieldName = "CREATE_USER";
            this.colCREATE_USER.Name = "colCREATE_USER";
            this.colCREATE_USER.Visible = true;
            this.colCREATE_USER.VisibleIndex = 4;
            // 
            // colCREATE_DATE4
            // 
            this.colCREATE_DATE4.FieldName = "CREATE_DATE";
            this.colCREATE_DATE4.Name = "colCREATE_DATE4";
            this.colCREATE_DATE4.Visible = true;
            this.colCREATE_DATE4.VisibleIndex = 5;
            // 
            // colPROD_GROUP_ID3
            // 
            this.colPROD_GROUP_ID3.FieldName = "PROD_GROUP_ID";
            this.colPROD_GROUP_ID3.Name = "colPROD_GROUP_ID3";
            this.colPROD_GROUP_ID3.OptionsColumn.AllowEdit = false;
            this.colPROD_GROUP_ID3.UnboundDataType = typeof(string);
            this.colPROD_GROUP_ID3.Visible = true;
            this.colPROD_GROUP_ID3.VisibleIndex = 6;
            // 
            // colSITE_ID5
            // 
            this.colSITE_ID5.FieldName = "SITE_ID";
            this.colSITE_ID5.Name = "colSITE_ID5";
            this.colSITE_ID5.OptionsColumn.AllowEdit = false;
            this.colSITE_ID5.UnboundDataType = typeof(string);
            this.colSITE_ID5.Visible = true;
            this.colSITE_ID5.VisibleIndex = 7;
            // 
            // colPROC_ID5
            // 
            this.colPROC_ID5.FieldName = "PROC_ID";
            this.colPROC_ID5.Name = "colPROC_ID5";
            this.colPROC_ID5.OptionsColumn.AllowEdit = false;
            this.colPROC_ID5.UnboundDataType = typeof(string);
            this.colPROC_ID5.Visible = true;
            this.colPROC_ID5.VisibleIndex = 8;
            // 
            // colPROD_CLASS_CODE3
            // 
            this.colPROD_CLASS_CODE3.FieldName = "PROD_CLASS_CODE";
            this.colPROD_CLASS_CODE3.Name = "colPROD_CLASS_CODE3";
            this.colPROD_CLASS_CODE3.OptionsColumn.AllowEdit = false;
            this.colPROD_CLASS_CODE3.UnboundDataType = typeof(string);
            this.colPROD_CLASS_CODE3.Visible = true;
            this.colPROD_CLASS_CODE3.VisibleIndex = 9;
            // 
            // colPROD_NM3
            // 
            this.colPROD_NM3.FieldName = "PROD_NM";
            this.colPROD_NM3.Name = "colPROD_NM3";
            this.colPROD_NM3.OptionsColumn.AllowEdit = false;
            this.colPROD_NM3.UnboundDataType = typeof(string);
            this.colPROD_NM3.Visible = true;
            this.colPROD_NM3.VisibleIndex = 10;
            // 
            // colPROD_TYPE3
            // 
            this.colPROD_TYPE3.FieldName = "PROD_TYPE";
            this.colPROD_TYPE3.Name = "colPROD_TYPE3";
            this.colPROD_TYPE3.OptionsColumn.AllowEdit = false;
            this.colPROD_TYPE3.UnboundDataType = typeof(string);
            this.colPROD_TYPE3.Visible = true;
            this.colPROD_TYPE3.VisibleIndex = 11;
            // 
            // colSUB_PROD_TYPE
            // 
            this.colSUB_PROD_TYPE.FieldName = "SUB_PROD_TYPE";
            this.colSUB_PROD_TYPE.Name = "colSUB_PROD_TYPE";
            this.colSUB_PROD_TYPE.OptionsColumn.AllowEdit = false;
            this.colSUB_PROD_TYPE.UnboundDataType = typeof(string);
            this.colSUB_PROD_TYPE.Visible = true;
            this.colSUB_PROD_TYPE.VisibleIndex = 12;
            // 
            // colPROD_GRADE3
            // 
            this.colPROD_GRADE3.FieldName = "PROD_GRADE";
            this.colPROD_GRADE3.Name = "colPROD_GRADE3";
            this.colPROD_GRADE3.OptionsColumn.AllowEdit = false;
            this.colPROD_GRADE3.UnboundDataType = typeof(string);
            this.colPROD_GRADE3.Visible = true;
            this.colPROD_GRADE3.VisibleIndex = 13;
            // 
            // colPROD_MODEL3
            // 
            this.colPROD_MODEL3.FieldName = "PROD_MODEL";
            this.colPROD_MODEL3.Name = "colPROD_MODEL3";
            this.colPROD_MODEL3.OptionsColumn.AllowEdit = false;
            this.colPROD_MODEL3.UnboundDataType = typeof(string);
            this.colPROD_MODEL3.Visible = true;
            this.colPROD_MODEL3.VisibleIndex = 14;
            // 
            // layoutControlGroup25
            // 
            this.layoutControlGroup25.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup25.GroupBordersVisible = false;
            this.layoutControlGroup25.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup17,
            this.layoutControlGroup28,
            this.splitterItem7,
            this.layoutControlItem28,
            this.emptySpaceItem5,
            this.layoutControlItem27,
            this.emptySpaceItem15});
            this.layoutControlGroup25.Name = "Root";
            this.layoutControlGroup25.Size = new System.Drawing.Size(1228, 1282);
            this.layoutControlGroup25.TextVisible = false;
            // 
            // layoutControlGroup17
            // 
            this.layoutControlGroup17.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup17.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem21});
            this.layoutControlGroup17.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup17.Name = "layoutControlGroup17";
            this.layoutControlGroup17.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup17.Size = new System.Drawing.Size(1208, 496);
            this.layoutControlGroup17.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup17.Text = "Finished Goods Inventory";
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.gridControlFinishedGoods;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(1198, 461);
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // layoutControlGroup28
            // 
            this.layoutControlGroup28.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup28.Location = new System.Drawing.Point(0, 532);
            this.layoutControlGroup28.Name = "layoutControlGroup28";
            this.layoutControlGroup28.Size = new System.Drawing.Size(1208, 730);
            this.layoutControlGroup28.Text = "Actions";
            // 
            // splitterItem7
            // 
            this.splitterItem7.AllowHotTrack = true;
            this.splitterItem7.Location = new System.Drawing.Point(0, 522);
            this.splitterItem7.Name = "splitterItem7";
            this.splitterItem7.Size = new System.Drawing.Size(1208, 10);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.simpleButtonFinishedGoodsReserved;
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem28.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem28.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(124, 0);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(20, 0);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(20, 11);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(20, 26);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.simpleButtonFinishedGoodsSave;
            this.layoutControlItem27.Location = new System.Drawing.Point(144, 0);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextVisible = false;
            // 
            // emptySpaceItem15
            // 
            this.emptySpaceItem15.AllowHotTrack = false;
            this.emptySpaceItem15.Location = new System.Drawing.Point(268, 0);
            this.emptySpaceItem15.Name = "emptySpaceItem15";
            this.emptySpaceItem15.Size = new System.Drawing.Size(940, 26);
            this.emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // mMPROCMSTBindingSource1
            // 
            this.mMPROCMSTBindingSource1.DataMember = "MM_PROC_MST";
            this.mMPROCMSTBindingSource1.DataSource = this.signes_MESDataSet;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Design mode";
            // 
            // fINISHEDMSTBindingSource
            // 
            this.fINISHEDMSTBindingSource.DataMember = "FINISHED_MST";
            this.fINISHEDMSTBindingSource.DataSource = this.signes_MESDataSet;
            // 
            // mMPROCSTEPBindingSource
            // 
            this.mMPROCSTEPBindingSource.DataMember = "MM_PROC_STEP";
            this.mMPROCSTEPBindingSource.DataSource = this.signes_MESDataSet;
            // 
            // colMATERIAL_ID
            // 
            this.colMATERIAL_ID.FieldName = "MATERIAL_ID";
            this.colMATERIAL_ID.Name = "colMATERIAL_ID";
            this.colMATERIAL_ID.Visible = true;
            this.colMATERIAL_ID.VisibleIndex = 0;
            // 
            // colMATERIAL_NAME
            // 
            this.colMATERIAL_NAME.FieldName = "MATERIAL_NAME";
            this.colMATERIAL_NAME.Name = "colMATERIAL_NAME";
            this.colMATERIAL_NAME.Visible = true;
            this.colMATERIAL_NAME.VisibleIndex = 1;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(160, 1);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // panelControlGanttChart
            // 
            this.panelControlGanttChart.Controls.Add(this.tabPane1);
            this.panelControlGanttChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGanttChart.Location = new System.Drawing.Point(0, 159);
            this.panelControlGanttChart.Name = "panelControlGanttChart";
            this.panelControlGanttChart.Size = new System.Drawing.Size(1236, 612);
            this.panelControlGanttChart.TabIndex = 1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FINISHED_MSTTableAdapter = null;
            this.tableAdapterManager.MATERIAL_MSTTableAdapter = null;
            this.tableAdapterManager.MM_DCOLTableAdapter = null;
            this.tableAdapterManager.MM_EQP_MSTTableAdapter = null;
            this.tableAdapterManager.MM_PROC_MSTTableAdapter = null;
            this.tableAdapterManager.MM_PROC_STEPTableAdapter = null;
            this.tableAdapterManager.PRODUCT_MSTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MES.Signes_MESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PRODUCT_MSTTableAdapter
            // 
            this.PRODUCT_MSTTableAdapter.ClearBeforeFill = true;
            // 
            // materiaL_MSTTableAdapter
            // 
            this.materiaL_MSTTableAdapter.ClearBeforeFill = true;
            // 
            // mM_PROC_STEPTableAdapter
            // 
            this.mM_PROC_STEPTableAdapter.ClearBeforeFill = true;
            // 
            // mM_PROC_MSTTableAdapter
            // 
            this.mM_PROC_MSTTableAdapter.ClearBeforeFill = true;
            // 
            // finisheD_MSTTableAdapter1
            // 
            this.finisheD_MSTTableAdapter1.ClearBeforeFill = true;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager3;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1280, 30);
            this.toolbarFormControl1.TabIndex = 16;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.skinPaletteDropDownButtonItem2);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager3
            // 
            this.toolbarFormManager3.DockControls.Add(this.barDockControl5);
            this.toolbarFormManager3.DockControls.Add(this.barDockControl6);
            this.toolbarFormManager3.DockControls.Add(this.barDockControl7);
            this.toolbarFormManager3.DockControls.Add(this.barDockControl8);
            this.toolbarFormManager3.Form = this;
            this.toolbarFormManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinPaletteDropDownButtonItem2});
            this.toolbarFormManager3.MaxItemId = 1;
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 30);
            this.barDockControl5.Manager = this.toolbarFormManager3;
            this.barDockControl5.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 771);
            this.barDockControl6.Manager = this.toolbarFormManager3;
            this.barDockControl6.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 30);
            this.barDockControl7.Manager = this.toolbarFormManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 741);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1280, 30);
            this.barDockControl8.Manager = this.toolbarFormManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 741);
            // 
            // skinPaletteDropDownButtonItem2
            // 
            this.skinPaletteDropDownButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinPaletteDropDownButtonItem2.Id = 0;
            this.skinPaletteDropDownButtonItem2.Name = "skinPaletteDropDownButtonItem2";
            // 
            // productPopupMenu
            // 
            this.productPopupMenu.Manager = this.toolbarFormManager1;
            this.productPopupMenu.Name = "productPopupMenu";
            // 
            // mMPROCMSTMMPROCSTEPBindingSource
            // 
            this.mMPROCMSTMMPROCSTEPBindingSource.DataMember = "MM_PROC_MST_MM_PROC_STEP";
            this.mMPROCMSTMMPROCSTEPBindingSource.DataSource = this.mMPROCMSTBindingSource;
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 771);
            this.Controls.Add(this.panelControlGanttChart);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.toolbarFormControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.Name = "MainForm";
            this.Text = "SigneS MES";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardViewMaterialDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPRODMSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signes_MESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewProcessStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlManufacturingOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCMSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManufacturingOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            this.panelControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabPane1.PerformLayout();
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOverview)).EndInit();
            this.panelControlOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControlOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.tabNavigationPage6.ResumeLayout(false);
            this.tabNavigationPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlProductionMonitor)).EndInit();
            this.panelControlProductionMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartSplitContainer.Panel1)).EndInit();
            this.ganttChartChartSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartSplitContainer.Panel2)).EndInit();
            this.ganttChartChartSplitContainer.Panel2.ResumeLayout(false);
            this.ganttChartChartSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartSplitContainer)).EndInit();
            this.ganttChartChartSplitContainer.ResumeLayout(false);
            this.ganttChartChartTreeListTableLayoutPanel.ResumeLayout(false);
            this.ganttChartChartTreeListTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ganttChartChartTreeList)).EndInit();
            this.ganttChartChartOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem5)).EndInit();
            this.tabNavigationPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMaterialInventory)).EndInit();
            this.panelControlMaterialInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERIAL_MSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialListing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlJobDispatch)).EndInit();
            this.panelControlJobDispatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerEventStackPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerEventStackPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlManufacturingOrder)).EndInit();
            this.panelControlManufacturingOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlManufacturingOrder)).EndInit();
            this.layoutControlManufacturingOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMOProductFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBOM)).EndInit();
            this.panelControlBOM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
            this.layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControlBOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            this.tabNavigationPage7.ResumeLayout(false);
            this.tabNavigationPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFinishedGoodsInventory)).EndInit();
            this.panelControlFinishedGoodsInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
            this.layoutControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFinishedGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINISHEDMSTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFinishedGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCMSTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINISHEDMSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCSTEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGanttChart)).EndInit();
            this.panelControlGanttChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMPROCMSTMMPROCSTEPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlTitle;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn StartDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn FinishDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Duration;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Complete;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Delay;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ParentID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn BaselineStartDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn BaselineEndDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLicense;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementGanttChart;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementTaskEditor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementGroupEditor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementInventory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementMaterialEditor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementViewRestocks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementEventManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementExportLogs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSetting;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementMain;
        private DevExpress.XtraBars.PopupMenu accountPopupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAccountSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLogout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.PopupMenu viewPopupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCardView;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGridView;
        private DevExpress.XtraBars.BarButtonItem barButtonIteLayoutView;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup24;
        private LayoutControlGroup layoutControlGroup26;
        private LayoutControlItem layoutControlItem20;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem;
        private DevExpress.XtraEditors.PanelControl panelControlGanttChart;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.PanelControl panelControlOverview;
        private LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TileControl tileControlOverview;
        private DevExpress.XtraEditors.TileGroup groupGanttChart;
        private DevExpress.XtraEditors.TileItem tileGanttChart;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileGroup groupInventory;
        private DevExpress.XtraEditors.TileItem tileInventory;
        private DevExpress.XtraEditors.TileItem tileEventM;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraGantt.GanttControl ganttControlOverview;
        private LayoutControlGroup layoutControlGroup8;
        private LayoutControlGroup layoutControlGroup9;
        private LayoutControlItem layoutControlItem5;
        private LayoutControlItem layoutControlItem6;
        private SplitterItem splitterItem2;
        private LayoutControlGroup layoutControlGroup10;
        private EmptySpaceItem emptySpaceItem2;
        private SplitterItem splitterItem1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage6;
        private DevExpress.XtraEditors.PanelControl panelControlProductionMonitor;
        private LayoutControl layoutControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl ganttChartHyperLinkLabelControl2;
        private DevExpress.XtraEditors.SplitContainerControl ganttChartChartSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ganttChartChartTreeListTableLayoutPanel;
        private DevExpress.XtraEditors.LabelControl ganttChartChartProjectLabel;
        private DevExpress.XtraTreeList.TreeList ganttChartChartTreeList;
        private System.Windows.Forms.Panel ganttChartChartOptionsPanel;
        private System.Windows.Forms.PropertyGrid m_TaskGrid;
        private Edcore.GanttChart.GanttChart ganttChartChart;
        private DevExpress.XtraEditors.HyperlinkLabelControl ganttChartHyperLinkLabelControl1;
        private DevExpress.XtraEditors.LabelControl ganttChartLabelControlQuickLinks;
        private LayoutControlGroup Root;
        private LayoutControlGroup layoutControlGroup7;
        private EmptySpaceItem emptySpaceItem1;
        private LayoutControlGroup layoutControlGroup5;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlGroup layoutControlGroup6;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem9;
        private LayoutControlItem layoutControlItem3;
        private SplitterItem splitterItem5;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private DevExpress.XtraEditors.PanelControl panelControlMaterialInventory;
        private LayoutControl layoutControl3;
        private DevExpress.XtraGrid.GridControl gridControlMaterialListing;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialListing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LayoutControlGroup layoutControlGroup11;
        private LayoutControlGroup layoutControlGroup18;
        private EmptySpaceItem emptySpaceItem6;
        private SplitterItem splitterItem6;
        private LayoutControlItem layoutControlItem14;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraEditors.PanelControl panelControlJobDispatch;
        private LayoutControl layoutControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.Utils.Layout.StackPanel eventManagerEventStackPanel2;
        private DevExpress.Utils.Layout.StackPanel eventManagerEventStackPanel1;
        private LayoutControlGroup layoutControlGroup12;
        private LayoutControlGroup layoutControlGroup13;
        private LayoutControlItem layoutControlItem10;
        private LayoutControlItem layoutControlItem11;
        private LayoutControlGroup layoutControlGroup19;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlGroup layoutControlGroup20;
        private LayoutControlItem layoutControlItem13;
        private SplitterItem splitterItem3;
        private LayoutControlGroup layoutControlGroup14;
        private EmptySpaceItem emptySpaceItem3;
        private LayoutControlGroup layoutControlGroup15;
        private EmptySpaceItem emptySpaceItem4;
        private SplitterItem splitterItem4;
        private LayoutControlItem layoutControlItem12;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.PanelControl panelControlManufacturingOrder;
        private LayoutControl layoutControlManufacturingOrder;
        private LayoutControlGroup layoutControlGroup27;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.PanelControl panelControlBOM;
        private LayoutControl layoutControl5;
        private DevExpress.XtraGrid.GridControl gridControlBOM;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBOMAddProduct;
        private DevExpress.XtraEditors.SearchControl searchControlBOM;
        private DevExpress.XtraEditors.DropDownButton dropDownButtonBOM;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBOMSave;
        private LayoutControlGroup layoutControlGroup21;
        private LayoutControlGroup layoutControlGroup22;
        private LayoutControlItem layoutControlItem23;
        private SplitterItem splitterItem8;
        private EmptySpaceItem emptySpaceItem12;
        private EmptySpaceItem emptySpaceItem8;
        private LayoutControlItem layoutControlItem15;
        private EmptySpaceItem emptySpaceItem9;
        private LayoutControlItem layoutControlItem17;
        private EmptySpaceItem emptySpaceItem10;
        private EmptySpaceItem emptySpaceItem7;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem16;
        private LayoutControlGroup layoutControlGroup23;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage7;
        private DevExpress.XtraEditors.PanelControl panelControlFinishedGoodsInventory;
        private LayoutControl layoutControl6;
        private DevExpress.XtraGrid.GridControl gridControlFinishedGoods;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFinishedGoods;
        private LayoutControlGroup layoutControlGroup25;
        private LayoutControlItem layoutControlItem21;
        private LayoutControlItem layoutControlItem2;
        private Signes_MESDataSet signes_MESDataSet;
        private Signes_MESDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_NAME;
        private System.Windows.Forms.BindingSource mMPRODMSTBindingSource;
        private Signes_MESDataSetTableAdapters.PRODUCT_MSTTableAdapter PRODUCT_MSTTableAdapter;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewMaterialDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductListing;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GROUP_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_CLASS_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_NM1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_TYPE1;
        private DevExpress.XtraGrid.Columns.GridColumn colSUB_PROD_TYPE1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GRADE1;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_MODEL1;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_YN1;
        private DevExpress.XtraGrid.Columns.GridColumn colREASON_CODE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCR1;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE1;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_USER_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_DATE1;
        private SplitterItem splitterItem9;
        private Signes_MESDataSetTableAdapters.MATERIAL_MSTTableAdapter materiaL_MSTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_NAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_MODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_CLASS_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GRADE;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GROUP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_VER;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colREASON_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCR;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_DATE;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBOMAddMaterial;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private LayoutControlItem layoutControlItem18;
        private LayoutControlItem layoutControlItem19;
        private LayoutControlItem layoutControlItem24;
        private LayoutControlItem layoutControlItem25;
        private EmptySpaceItem emptySpaceItem13;
        private System.Windows.Forms.BindingSource mATERIAL_MSTBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colMATERIAL_NAME2;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_NM2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_MODEL2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_TYPE2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_CLASS_CODE2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GRADE2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GROUP_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_VER1;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_YN2;
        private DevExpress.XtraGrid.Columns.GridColumn colREASON_CODE2;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCR2;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE2;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_USER_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_DATE2;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY1;
        private DevExpress.XtraGrid.GridControl gridControlManufacturingOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewManufacturingOrder;
        private LayoutControlItem layoutControlItem26;
        private EmptySpaceItem emptySpaceItem14;
        private SplitterItem splitterItem10;
        private Signes_MESDataSetTableAdapters.MM_PROC_STEPTableAdapter mM_PROC_STEPTableAdapter;
        private Signes_MESDataSetTableAdapters.MM_PROC_MSTTableAdapter mM_PROC_MSTTableAdapter;
        private System.Windows.Forms.BindingSource mMPROCMSTBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_VER2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_YN3;
        private DevExpress.XtraGrid.Columns.GridColumn colREASON_CODE3;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCR3;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE3;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_USER_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_DATE3;
        private System.Windows.Forms.BindingSource mMPROCSTEPBindingSource;
        private LayoutControlGroup layoutControlGroup17;
        private LayoutControlGroup layoutControlGroup28;
        private EmptySpaceItem emptySpaceItem5;
        private System.Windows.Forms.BindingSource fINISHEDMSTBindingSource;
        private System.Windows.Forms.BindingSource fINISHEDMSTBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colDUID1;
        private DevExpress.XtraGrid.Columns.GridColumn colEVENT_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY2;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_ID4;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE4;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GROUP_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE_ID5;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_ID5;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_CLASS_CODE3;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_NM3;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_TYPE3;
        private DevExpress.XtraGrid.Columns.GridColumn colSUB_PROD_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_GRADE3;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_MODEL3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFinishedGoodsReserved;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFinishedGoodsSave;
        private LayoutControlItem layoutControlItem27;
        private LayoutControlItem layoutControlItem28;
        private EmptySpaceItem emptySpaceItem15;
        private SplitterItem splitterItem7;
        private Signes_MESDataSetTableAdapters.FINISHED_MSTTableAdapter finisheD_MSTTableAdapter1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager3;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMaterialInventorySave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMaterialInventoryReserved;
        private LayoutControlItem layoutControlItem29;
        private LayoutControlItem layoutControlItem22;
        private LayoutControlGroup layoutControlGroup16;
        private LayoutControlItem layoutControlItem30;
        private EmptySpaceItem emptySpaceItem16;
        private EmptySpaceItem emptySpaceItem17;
        private LayoutControlGroup layoutControlGroup29;
        private LayoutControlGroup layoutControlGroup30;
        private EmptySpaceItem emptySpaceItem18;
        private DevExpress.XtraBars.PopupMenu productPopupMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMOSave;
        private LayoutControlItem layoutControlItem31;
        private EmptySpaceItem emptySpaceItem19;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpEditMOProductFilter;
        private System.Windows.Forms.BindingSource mMPROCMSTBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private LayoutControlItem layoutControlItem33;
        private System.Windows.Forms.BindingSource mMPROCMSTMMPROCSTEPBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMOAddStep;
        private LayoutControlItem layoutControlItem32;
        private EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewProcessStep;
        private DevExpress.XtraGrid.Columns.GridColumn colDUID;
        private DevExpress.XtraGrid.Columns.GridColumn colSITE_ID4;
        private DevExpress.XtraGrid.Columns.GridColumn colSTEP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTEP_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_ID4;
        private DevExpress.XtraGrid.Columns.GridColumn colPROC_VER3;
        private DevExpress.XtraGrid.Columns.GridColumn colEQP_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDCSPEC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDCOLL_MAND_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colDURABLE_USE_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSUM_USE_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colCHILD_PROC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCHILD_PROC_VER;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_YN4;
        private DevExpress.XtraGrid.Columns.GridColumn colREASON_CODE4;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCR4;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID4;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATE_DATE4;
    }
}

