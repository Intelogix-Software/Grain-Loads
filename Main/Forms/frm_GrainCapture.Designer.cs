
namespace Main
{
    partial class Grain_Capture
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grain_Capture));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.grc_GrainLoads = new DevExpress.XtraGrid.GridControl();
            this.SDS_GrainLoadsGRID = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.grv_Grainloads = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DeleteColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRelease = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickup_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickup_Ticket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Pickup_Location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickupLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGross_Pickup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTare_Pickup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeto_Pickup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelivery_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelivery_Ticket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Delivery_Location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGross_Delivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTare_Delivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeto_Delivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_GrainType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrainType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Driver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_GrainLoad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_created_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_created_by_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_updated_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_updated_by_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoad_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dedt_Top = new DevExpress.XtraEditors.DateEdit();
            this.dedt_Low = new DevExpress.XtraEditors.DateEdit();
            this.lue_dateFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.list_GrainLoads_DateColumnsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_DateColumns = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.list_GrainLoads_DateColumnsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.list_GrainLoads_DateColumnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grc_GrainLoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Grainloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Top.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Top.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Low.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Low.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_dateFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoads_DateColumnsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoads_DateColumnsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoads_DateColumnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grc_GrainLoads
            // 
            this.grc_GrainLoads.DataMember = "List_GrainLoads";
            this.grc_GrainLoads.DataSource = this.SDS_GrainLoadsGRID;
            this.grc_GrainLoads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_GrainLoads.Location = new System.Drawing.Point(0, 0);
            this.grc_GrainLoads.MainView = this.grv_Grainloads;
            this.grc_GrainLoads.Name = "grc_GrainLoads";
            this.grc_GrainLoads.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.grc_GrainLoads.Size = new System.Drawing.Size(1065, 234);
            this.grc_GrainLoads.TabIndex = 0;
            this.grc_GrainLoads.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Grainloads});
            // 
            // SDS_GrainLoadsGRID
            // 
            this.SDS_GrainLoadsGRID.ConnectionName = "_ITXLoadsTracking_Connection";
            this.SDS_GrainLoadsGRID.Name = "SDS_GrainLoadsGRID";
            storedProcQuery3.Name = "List_GrainLoads";
            queryParameter4.Name = "@SDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("TODAY()", typeof(System.DateTime));
            queryParameter5.Name = "@EDate";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("TODAY()", typeof(System.DateTime));
            queryParameter6.Name = "@DateColumn";
            queryParameter6.Type = typeof(string);
            queryParameter6.ValueInfo = "_created_date";
            storedProcQuery3.Parameters.Add(queryParameter4);
            storedProcQuery3.Parameters.Add(queryParameter5);
            storedProcQuery3.Parameters.Add(queryParameter6);
            storedProcQuery3.StoredProcName = "List_GrainLoads";
            this.SDS_GrainLoadsGRID.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.SDS_GrainLoadsGRID.ResultSchemaSerializable = resources.GetString("SDS_GrainLoadsGRID.ResultSchemaSerializable");
            // 
            // grv_Grainloads
            // 
            this.grv_Grainloads.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DeleteColumn,
            this.colStatus,
            this.colRelease,
            this.colFactura,
            this.colPickup_Date,
            this.colID_Customer,
            this.colCustomerName,
            this.colPickup_Ticket,
            this.colID_Pickup_Location,
            this.colPickupLocation,
            this.colGross_Pickup,
            this.colTare_Pickup,
            this.colNeto_Pickup,
            this.colDelivery_Date,
            this.colDelivery_Ticket,
            this.colID_Delivery_Location,
            this.colDeliveryLocation,
            this.colGross_Delivery,
            this.colTare_Delivery,
            this.colNeto_Delivery,
            this.colWeight,
            this.colID_GrainType,
            this.colGrainType,
            this.colID_Driver,
            this.colDriver,
            this.colDriverNotes,
            this.colTotalPrice,
            this.colPeriod,
            this.colNotes,
            this.colID_GrainLoad,
            this.col_created_by,
            this.col_created_by_date,
            this.col_updated_by,
            this.col_updated_by_date,
            this.colLoad_Status});
            this.grv_Grainloads.CustomizationFormBounds = new System.Drawing.Rectangle(1201, 536, 252, 357);
            this.grv_Grainloads.GridControl = this.grc_GrainLoads;
            this.grv_Grainloads.Name = "grv_Grainloads";
            this.grv_Grainloads.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grv_Grainloads_SelectionChanged);
            this.grv_Grainloads.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grv_Grainloads_FocusedRowChanged);
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Caption = "Delete";
            this.DeleteColumn.ColumnEdit = this.repositoryItemButtonEdit1;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Visible = true;
            this.DeleteColumn.VisibleIndex = 0;
            this.DeleteColumn.Width = 41;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 1;
            this.colStatus.Width = 47;
            // 
            // colRelease
            // 
            this.colRelease.FieldName = "Release";
            this.colRelease.Name = "colRelease";
            this.colRelease.Visible = true;
            this.colRelease.VisibleIndex = 2;
            this.colRelease.Width = 47;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 3;
            this.colFactura.Width = 47;
            // 
            // colPickup_Date
            // 
            this.colPickup_Date.FieldName = "Pickup_Date";
            this.colPickup_Date.Name = "colPickup_Date";
            this.colPickup_Date.Visible = true;
            this.colPickup_Date.VisibleIndex = 4;
            this.colPickup_Date.Width = 47;
            // 
            // colID_Customer
            // 
            this.colID_Customer.FieldName = "ID_Customer";
            this.colID_Customer.Name = "colID_Customer";
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            this.colCustomerName.Width = 47;
            // 
            // colPickup_Ticket
            // 
            this.colPickup_Ticket.FieldName = "Pickup_Ticket";
            this.colPickup_Ticket.Name = "colPickup_Ticket";
            this.colPickup_Ticket.Visible = true;
            this.colPickup_Ticket.VisibleIndex = 6;
            this.colPickup_Ticket.Width = 47;
            // 
            // colID_Pickup_Location
            // 
            this.colID_Pickup_Location.FieldName = "ID_Pickup_Location";
            this.colID_Pickup_Location.Name = "colID_Pickup_Location";
            // 
            // colPickupLocation
            // 
            this.colPickupLocation.FieldName = "PickupLocation";
            this.colPickupLocation.Name = "colPickupLocation";
            this.colPickupLocation.Visible = true;
            this.colPickupLocation.VisibleIndex = 7;
            this.colPickupLocation.Width = 111;
            // 
            // colGross_Pickup
            // 
            this.colGross_Pickup.FieldName = "Gross_Pickup";
            this.colGross_Pickup.Name = "colGross_Pickup";
            this.colGross_Pickup.Visible = true;
            this.colGross_Pickup.VisibleIndex = 8;
            this.colGross_Pickup.Width = 43;
            // 
            // colTare_Pickup
            // 
            this.colTare_Pickup.FieldName = "Tare_Pickup";
            this.colTare_Pickup.Name = "colTare_Pickup";
            this.colTare_Pickup.Visible = true;
            this.colTare_Pickup.VisibleIndex = 9;
            this.colTare_Pickup.Width = 85;
            // 
            // colNeto_Pickup
            // 
            this.colNeto_Pickup.FieldName = "Neto_Pickup";
            this.colNeto_Pickup.Name = "colNeto_Pickup";
            this.colNeto_Pickup.Visible = true;
            this.colNeto_Pickup.VisibleIndex = 10;
            this.colNeto_Pickup.Width = 40;
            // 
            // colDelivery_Date
            // 
            this.colDelivery_Date.FieldName = "Delivery_Date";
            this.colDelivery_Date.Name = "colDelivery_Date";
            this.colDelivery_Date.Visible = true;
            this.colDelivery_Date.VisibleIndex = 11;
            this.colDelivery_Date.Width = 79;
            // 
            // colDelivery_Ticket
            // 
            this.colDelivery_Ticket.FieldName = "Delivery_Ticket";
            this.colDelivery_Ticket.Name = "colDelivery_Ticket";
            this.colDelivery_Ticket.Visible = true;
            this.colDelivery_Ticket.VisibleIndex = 12;
            this.colDelivery_Ticket.Width = 74;
            // 
            // colID_Delivery_Location
            // 
            this.colID_Delivery_Location.FieldName = "ID_Delivery_Location";
            this.colID_Delivery_Location.Name = "colID_Delivery_Location";
            // 
            // colDeliveryLocation
            // 
            this.colDeliveryLocation.FieldName = "DeliveryLocation";
            this.colDeliveryLocation.Name = "colDeliveryLocation";
            this.colDeliveryLocation.Visible = true;
            this.colDeliveryLocation.VisibleIndex = 13;
            this.colDeliveryLocation.Width = 32;
            // 
            // colGross_Delivery
            // 
            this.colGross_Delivery.FieldName = "Gross_Delivery";
            this.colGross_Delivery.Name = "colGross_Delivery";
            this.colGross_Delivery.Visible = true;
            this.colGross_Delivery.VisibleIndex = 14;
            this.colGross_Delivery.Width = 32;
            // 
            // colTare_Delivery
            // 
            this.colTare_Delivery.FieldName = "Tare_Delivery";
            this.colTare_Delivery.Name = "colTare_Delivery";
            this.colTare_Delivery.Visible = true;
            this.colTare_Delivery.VisibleIndex = 15;
            this.colTare_Delivery.Width = 32;
            // 
            // colNeto_Delivery
            // 
            this.colNeto_Delivery.FieldName = "Neto_Delivery";
            this.colNeto_Delivery.Name = "colNeto_Delivery";
            this.colNeto_Delivery.Visible = true;
            this.colNeto_Delivery.VisibleIndex = 16;
            this.colNeto_Delivery.Width = 32;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 17;
            this.colWeight.Width = 32;
            // 
            // colID_GrainType
            // 
            this.colID_GrainType.FieldName = "ID_GrainType";
            this.colID_GrainType.Name = "colID_GrainType";
            // 
            // colGrainType
            // 
            this.colGrainType.FieldName = "GrainType";
            this.colGrainType.Name = "colGrainType";
            this.colGrainType.Visible = true;
            this.colGrainType.VisibleIndex = 18;
            this.colGrainType.Width = 32;
            // 
            // colID_Driver
            // 
            this.colID_Driver.FieldName = "ID_Driver";
            this.colID_Driver.Name = "colID_Driver";
            // 
            // colDriver
            // 
            this.colDriver.FieldName = "Driver";
            this.colDriver.Name = "colDriver";
            this.colDriver.Visible = true;
            this.colDriver.VisibleIndex = 19;
            this.colDriver.Width = 71;
            // 
            // colDriverNotes
            // 
            this.colDriverNotes.FieldName = "DriverNotes";
            this.colDriverNotes.Name = "colDriverNotes";
            this.colDriverNotes.Visible = true;
            this.colDriverNotes.VisibleIndex = 20;
            this.colDriverNotes.Width = 57;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 21;
            this.colTotalPrice.Width = 20;
            // 
            // colPeriod
            // 
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.Visible = true;
            this.colPeriod.VisibleIndex = 22;
            this.colPeriod.Width = 20;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 23;
            this.colNotes.Width = 76;
            // 
            // colID_GrainLoad
            // 
            this.colID_GrainLoad.FieldName = "ID_GrainLoad";
            this.colID_GrainLoad.Name = "colID_GrainLoad";
            // 
            // col_created_by
            // 
            this.col_created_by.FieldName = "_created_by";
            this.col_created_by.Name = "col_created_by";
            // 
            // col_created_by_date
            // 
            this.col_created_by_date.FieldName = "_created_by_date";
            this.col_created_by_date.Name = "col_created_by_date";
            // 
            // col_updated_by
            // 
            this.col_updated_by.FieldName = "_updated_by";
            this.col_updated_by.Name = "col_updated_by";
            // 
            // col_updated_by_date
            // 
            this.col_updated_by_date.FieldName = "_updated_by_date";
            this.col_updated_by_date.Name = "col_updated_by_date";
            // 
            // colLoad_Status
            // 
            this.colLoad_Status.FieldName = "Load_Status";
            this.colLoad_Status.Name = "colLoad_Status";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.dedt_Top);
            this.splitContainerControl2.Panel1.Controls.Add(this.dedt_Low);
            this.splitContainerControl2.Panel1.Controls.Add(this.lue_dateFilter);
            this.splitContainerControl2.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl2.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl2.Panel1.Controls.Add(this.simpleButton4);
            this.splitContainerControl2.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.pictureEdit1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1065, 126);
            this.splitContainerControl2.SplitterPosition = 574;
            this.splitContainerControl2.TabIndex = 26;
            // 
            // dedt_Top
            // 
            this.dedt_Top.EditValue = null;
            this.dedt_Top.Location = new System.Drawing.Point(278, 7);
            this.dedt_Top.Name = "dedt_Top";
            this.dedt_Top.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedt_Top.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedt_Top.Properties.NullText = "Top Date";
            this.dedt_Top.Size = new System.Drawing.Size(130, 20);
            this.dedt_Top.TabIndex = 28;
            this.dedt_Top.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.dateEdit2_Closed);
            // 
            // dedt_Low
            // 
            this.dedt_Low.EditValue = null;
            this.dedt_Low.Location = new System.Drawing.Point(142, 7);
            this.dedt_Low.Name = "dedt_Low";
            this.dedt_Low.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedt_Low.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedt_Low.Properties.NullText = "Low Date";
            this.dedt_Low.Size = new System.Drawing.Size(130, 20);
            this.dedt_Low.TabIndex = 27;
            this.dedt_Low.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.dateEdit1_Closed);
            // 
            // lue_dateFilter
            // 
            this.lue_dateFilter.Location = new System.Drawing.Point(6, 7);
            this.lue_dateFilter.Name = "lue_dateFilter";
            this.lue_dateFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_dateFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("column_name", "column_name", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_dateFilter.Properties.DataSource = this.list_GrainLoads_DateColumnsBindingSource2;
            this.lue_dateFilter.Properties.DisplayMember = "column_name";
            this.lue_dateFilter.Properties.NullText = "Date Filter";
            this.lue_dateFilter.Properties.NullValuePrompt = "Date Filter";
            this.lue_dateFilter.Properties.ValueMember = "column_name";
            this.lue_dateFilter.Size = new System.Drawing.Size(130, 20);
            this.lue_dateFilter.TabIndex = 26;
            this.lue_dateFilter.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.lue_dateFilter_Closed);
            // 
            // list_GrainLoads_DateColumnsBindingSource2
            // 
            this.list_GrainLoads_DateColumnsBindingSource2.DataMember = "List_GrainLoads_DateColumns";
            this.list_GrainLoads_DateColumnsBindingSource2.DataSource = this.SDS_DateColumns;
            // 
            // SDS_DateColumns
            // 
            this.SDS_DateColumns.ConnectionName = "_ITXLoadsTracking_Connection";
            this.SDS_DateColumns.Name = "SDS_DateColumns";
            storedProcQuery4.Name = "List_GrainLoads_DateColumns";
            storedProcQuery4.StoredProcName = "List_GrainLoads_DateColumns";
            this.SDS_DateColumns.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery4});
            this.SDS_DateColumns.ResultSchemaSerializable = resources.GetString("SDS_DateColumns.ResultSchemaSerializable");
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 60);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Pickup";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(414, 33);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(130, 60);
            this.simpleButton3.TabIndex = 22;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(278, 33);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(130, 60);
            this.simpleButton4.TabIndex = 25;
            this.simpleButton4.Text = "Notes ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(142, 33);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(130, 60);
            this.simpleButton2.TabIndex = 24;
            this.simpleButton2.Text = "Delivery";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(485, 126);
            this.pictureEdit1.TabIndex = 14;
            // 
            // list_GrainLoads_DateColumnsBindingSource1
            // 
            this.list_GrainLoads_DateColumnsBindingSource1.DataMember = "List_GrainLoads_DateColumns";
            this.list_GrainLoads_DateColumnsBindingSource1.DataSource = this.SDS_DateColumns;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.grc_GrainLoads);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1065, 366);
            this.splitContainerControl1.SplitterPosition = 126;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // list_GrainLoads_DateColumnsBindingSource
            // 
            this.list_GrainLoads_DateColumnsBindingSource.DataMember = "List_GrainLoads_DateColumns";
            this.list_GrainLoads_DateColumnsBindingSource.DataSource = this.SDS_DateColumns;
            // 
            // Grain_Capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 366);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Grain_Capture";
            this.Text = "Grain_Capture";
            ((System.ComponentModel.ISupportInitialize)(this.grc_GrainLoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Grainloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Top.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Top.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Low.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_Low.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_dateFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoads_DateColumnsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoads_DateColumnsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoads_DateColumnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grc_GrainLoads;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Grainloads;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.DateEdit dedt_Top;
        private DevExpress.XtraEditors.DateEdit dedt_Low;
        private DevExpress.XtraEditors.LookUpEdit lue_dateFilter;
        private System.Windows.Forms.BindingSource list_GrainLoads_DateColumnsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_DateColumns;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_GrainLoadsGRID;
        private DevExpress.XtraGrid.Columns.GridColumn DeleteColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRelease;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colPickup_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Customer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPickup_Ticket;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pickup_Location;
        private DevExpress.XtraGrid.Columns.GridColumn colPickupLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colGross_Pickup;
        private DevExpress.XtraGrid.Columns.GridColumn colTare_Pickup;
        private DevExpress.XtraGrid.Columns.GridColumn colNeto_Pickup;
        private DevExpress.XtraGrid.Columns.GridColumn colDelivery_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDelivery_Ticket;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Delivery_Location;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colGross_Delivery;
        private DevExpress.XtraGrid.Columns.GridColumn colTare_Delivery;
        private DevExpress.XtraGrid.Columns.GridColumn colNeto_Delivery;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colID_GrainType;
        private DevExpress.XtraGrid.Columns.GridColumn colGrainType;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Driver;
        private DevExpress.XtraGrid.Columns.GridColumn colDriver;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colID_GrainLoad;
        private DevExpress.XtraGrid.Columns.GridColumn col_created_by;
        private DevExpress.XtraGrid.Columns.GridColumn col_created_by_date;
        private DevExpress.XtraGrid.Columns.GridColumn col_updated_by;
        private DevExpress.XtraGrid.Columns.GridColumn col_updated_by_date;
        private DevExpress.XtraGrid.Columns.GridColumn colLoad_Status;
        private System.Windows.Forms.BindingSource list_GrainLoads_DateColumnsBindingSource1;
        private System.Windows.Forms.BindingSource list_GrainLoads_DateColumnsBindingSource2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}