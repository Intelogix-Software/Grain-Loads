
namespace Main.Forms
{
    partial class frm_PickupCapture
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery9 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PickupCapture));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery10 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery11 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery12 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_SavePickup = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CancelPickup = new DevExpress.XtraEditors.SimpleButton();
            this.edt_release = new DevExpress.XtraEditors.TextEdit();
            this.btn_pickupDropbox = new DevExpress.XtraEditors.SimpleButton();
            this.lue_driver = new DevExpress.XtraEditors.LookUpEdit();
            this.list_GrainLoadsDriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Drivers = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lue_GrainType = new DevExpress.XtraEditors.LookUpEdit();
            this.list_GrainLoadsGrainTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_GrainType = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.edt_pickupticket = new DevExpress.XtraEditors.TextEdit();
            this.edt_netoPickup = new DevExpress.XtraEditors.TextEdit();
            this.edt_tarePickup = new DevExpress.XtraEditors.TextEdit();
            this.edt_grossPickup = new DevExpress.XtraEditors.TextEdit();
            this.lue_locationPickup = new DevExpress.XtraEditors.LookUpEdit();
            this.list_GlobalEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_PickupLocations = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lue_customer = new DevExpress.XtraEditors.LookUpEdit();
            this.list_GrainLoadsCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Customers = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dte_Pickup = new DevExpress.XtraEditors.DateEdit();
            this.edt_factura = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_release.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_driver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoadsDriversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_GrainType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoadsGrainTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_pickupticket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_netoPickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tarePickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_grossPickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationPickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GlobalEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoadsCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_factura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(535, 448);
            this.splitContainerControl1.SplitterPosition = 218;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_SavePickup);
            this.panelControl1.Controls.Add(this.btn_CancelPickup);
            this.panelControl1.Controls.Add(this.edt_release);
            this.panelControl1.Controls.Add(this.btn_pickupDropbox);
            this.panelControl1.Controls.Add(this.lue_driver);
            this.panelControl1.Controls.Add(this.lue_GrainType);
            this.panelControl1.Controls.Add(this.edt_pickupticket);
            this.panelControl1.Controls.Add(this.edt_netoPickup);
            this.panelControl1.Controls.Add(this.edt_tarePickup);
            this.panelControl1.Controls.Add(this.edt_grossPickup);
            this.panelControl1.Controls.Add(this.lue_locationPickup);
            this.panelControl1.Controls.Add(this.lue_customer);
            this.panelControl1.Controls.Add(this.dte_Pickup);
            this.panelControl1.Controls.Add(this.edt_factura);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(218, 448);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_SavePickup
            // 
            this.btn_SavePickup.Location = new System.Drawing.Point(28, 340);
            this.btn_SavePickup.Name = "btn_SavePickup";
            this.btn_SavePickup.Size = new System.Drawing.Size(168, 50);
            this.btn_SavePickup.TabIndex = 13;
            this.btn_SavePickup.Text = "Save";
            this.btn_SavePickup.Click += new System.EventHandler(this.btn_SavePickup_Click);
            // 
            // btn_CancelPickup
            // 
            this.btn_CancelPickup.Location = new System.Drawing.Point(28, 396);
            this.btn_CancelPickup.Name = "btn_CancelPickup";
            this.btn_CancelPickup.Size = new System.Drawing.Size(168, 30);
            this.btn_CancelPickup.TabIndex = 14;
            this.btn_CancelPickup.Text = "Cancel";
            this.btn_CancelPickup.Click += new System.EventHandler(this.btn_CancelPickup_Click);
            // 
            // edt_release
            // 
            this.edt_release.Location = new System.Drawing.Point(28, 10);
            this.edt_release.Name = "edt_release";
            this.edt_release.Properties.NullText = "Release";
            this.edt_release.Properties.NullValuePrompt = "Release";
            this.edt_release.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.edt_release.Size = new System.Drawing.Size(168, 20);
            this.edt_release.TabIndex = 1;
            this.edt_release.ToolTip = "Release";
            this.edt_release.ToolTipTitle = "Release";
            // 
            // btn_pickupDropbox
            // 
            this.btn_pickupDropbox.Location = new System.Drawing.Point(28, 296);
            this.btn_pickupDropbox.Name = "btn_pickupDropbox";
            this.btn_pickupDropbox.Size = new System.Drawing.Size(168, 38);
            this.btn_pickupDropbox.TabIndex = 12;
            this.btn_pickupDropbox.Text = "Upload Pickup Photo";
            // 
            // lue_driver
            // 
            this.lue_driver.Location = new System.Drawing.Point(28, 62);
            this.lue_driver.Name = "lue_driver";
            this.lue_driver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_driver.Properties.CascadingMember = "Driver;Notes";
            this.lue_driver.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Driver", "Driver", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Notes", "Notes", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Driver", "ID_Driver", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_driver.Properties.DataSource = this.list_GrainLoadsDriversBindingSource;
            this.lue_driver.Properties.DisplayMember = "Driver";
            this.lue_driver.Properties.KeyMember = "Driver;Notes";
            this.lue_driver.Properties.NullText = "Driver";
            this.lue_driver.Properties.NullValuePrompt = "Driver";
            this.lue_driver.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lue_driver.Properties.ValueMember = "ID_Driver";
            this.lue_driver.Size = new System.Drawing.Size(168, 20);
            this.lue_driver.TabIndex = 3;
            // 
            // list_GrainLoadsDriversBindingSource
            // 
            this.list_GrainLoadsDriversBindingSource.DataMember = "List_GrainLoadsDrivers";
            this.list_GrainLoadsDriversBindingSource.DataSource = this.SDS_Drivers;
            // 
            // SDS_Drivers
            // 
            this.SDS_Drivers.ConnectionName = "_ITXLoadsTracking_Connection";
            this.SDS_Drivers.Name = "SDS_Drivers";
            storedProcQuery9.Name = "List_GrainLoadsDrivers";
            storedProcQuery9.StoredProcName = "List_GrainLoadsDrivers";
            this.SDS_Drivers.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery9});
            this.SDS_Drivers.ResultSchemaSerializable = resources.GetString("SDS_Drivers.ResultSchemaSerializable");
            // 
            // lue_GrainType
            // 
            this.lue_GrainType.Location = new System.Drawing.Point(28, 192);
            this.lue_GrainType.Name = "lue_GrainType";
            this.lue_GrainType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_GrainType.Properties.CascadingMember = "GrainType;Description";
            this.lue_GrainType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_GrainType", "ID_Grain Type", 78, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GrainType", "Grain Type", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_GrainType.Properties.DataSource = this.list_GrainLoadsGrainTypesBindingSource;
            this.lue_GrainType.Properties.DisplayMember = "GrainType";
            this.lue_GrainType.Properties.KeyMember = "GrainType;Description";
            this.lue_GrainType.Properties.NullText = "GrainType";
            this.lue_GrainType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lue_GrainType.Properties.ValueMember = "ID_GrainType";
            this.lue_GrainType.Size = new System.Drawing.Size(168, 20);
            this.lue_GrainType.TabIndex = 8;
            // 
            // list_GrainLoadsGrainTypesBindingSource
            // 
            this.list_GrainLoadsGrainTypesBindingSource.DataMember = "List_GrainLoadsGrainTypes";
            this.list_GrainLoadsGrainTypesBindingSource.DataSource = this.SDS_GrainType;
            // 
            // SDS_GrainType
            // 
            this.SDS_GrainType.ConnectionName = "_ITXLoadsTracking_Connection";
            this.SDS_GrainType.Name = "SDS_GrainType";
            storedProcQuery10.Name = "List_GrainLoadsGrainTypes";
            storedProcQuery10.StoredProcName = "List_GrainLoadsGrainTypes";
            this.SDS_GrainType.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery10});
            this.SDS_GrainType.ResultSchemaSerializable = resources.GetString("SDS_GrainType.ResultSchemaSerializable");
            // 
            // edt_pickupticket
            // 
            this.edt_pickupticket.Location = new System.Drawing.Point(28, 140);
            this.edt_pickupticket.Name = "edt_pickupticket";
            this.edt_pickupticket.Properties.NullText = "Pickup Ticket";
            this.edt_pickupticket.Size = new System.Drawing.Size(168, 20);
            this.edt_pickupticket.TabIndex = 6;
            // 
            // edt_netoPickup
            // 
            this.edt_netoPickup.Location = new System.Drawing.Point(28, 270);
            this.edt_netoPickup.Name = "edt_netoPickup";
            this.edt_netoPickup.Properties.NullText = "Neto";
            this.edt_netoPickup.Size = new System.Drawing.Size(168, 20);
            this.edt_netoPickup.TabIndex = 11;
            // 
            // edt_tarePickup
            // 
            this.edt_tarePickup.Location = new System.Drawing.Point(28, 244);
            this.edt_tarePickup.Name = "edt_tarePickup";
            this.edt_tarePickup.Properties.NullText = "Tare";
            this.edt_tarePickup.Size = new System.Drawing.Size(168, 20);
            this.edt_tarePickup.TabIndex = 10;
            // 
            // edt_grossPickup
            // 
            this.edt_grossPickup.Location = new System.Drawing.Point(28, 218);
            this.edt_grossPickup.Name = "edt_grossPickup";
            this.edt_grossPickup.Properties.NullText = "Gross";
            this.edt_grossPickup.Size = new System.Drawing.Size(168, 20);
            this.edt_grossPickup.TabIndex = 9;
            // 
            // lue_locationPickup
            // 
            this.lue_locationPickup.Location = new System.Drawing.Point(28, 166);
            this.lue_locationPickup.Name = "lue_locationPickup";
            this.lue_locationPickup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_locationPickup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Entity", "ID_Entity", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_locationPickup.Properties.DataSource = this.list_GlobalEntitiesBindingSource;
            this.lue_locationPickup.Properties.DisplayMember = "Description";
            this.lue_locationPickup.Properties.NullText = "Pickup Location";
            this.lue_locationPickup.Properties.ValueMember = "ID_Entity";
            this.lue_locationPickup.Size = new System.Drawing.Size(168, 20);
            this.lue_locationPickup.TabIndex = 7;
            // 
            // list_GlobalEntitiesBindingSource
            // 
            this.list_GlobalEntitiesBindingSource.DataMember = "List_GlobalEntities";
            this.list_GlobalEntitiesBindingSource.DataSource = this.SDS_PickupLocations;
            // 
            // SDS_PickupLocations
            // 
            this.SDS_PickupLocations.ConnectionName = "_ITXLoadsTracking_Connection";
            this.SDS_PickupLocations.Name = "SDS_PickupLocations";
            storedProcQuery11.Name = "List_GlobalEntities";
            storedProcQuery11.StoredProcName = "List_GlobalEntities";
            this.SDS_PickupLocations.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery11});
            this.SDS_PickupLocations.ResultSchemaSerializable = resources.GetString("SDS_PickupLocations.ResultSchemaSerializable");
            // 
            // lue_customer
            // 
            this.lue_customer.Location = new System.Drawing.Point(28, 114);
            this.lue_customer.Name = "lue_customer";
            this.lue_customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_customer.Properties.CascadingMember = "CustomerName;Cust_";
            this.lue_customer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cust_", "Cust_", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_GrainCustomer", "ID_Grain Customer", 100, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_customer.Properties.DataSource = this.list_GrainLoadsCustomersBindingSource;
            this.lue_customer.Properties.DisplayMember = "Cust_";
            this.lue_customer.Properties.KeyMember = "CustomerName;Cust_";
            this.lue_customer.Properties.NullText = "Customer";
            this.lue_customer.Properties.NullValuePrompt = "Customer";
            this.lue_customer.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lue_customer.Properties.ValueMember = "ID_GrainCustomer";
            this.lue_customer.Size = new System.Drawing.Size(168, 20);
            this.lue_customer.TabIndex = 5;
            // 
            // list_GrainLoadsCustomersBindingSource
            // 
            this.list_GrainLoadsCustomersBindingSource.DataMember = "List_GrainLoadsCustomers";
            this.list_GrainLoadsCustomersBindingSource.DataSource = this.SDS_Customers;
            // 
            // SDS_Customers
            // 
            this.SDS_Customers.ConnectionName = "_ITXLoadsTracking_Connection";
            this.SDS_Customers.Name = "SDS_Customers";
            storedProcQuery12.Name = "List_GrainLoadsCustomers";
            storedProcQuery12.StoredProcName = "List_GrainLoadsCustomers";
            this.SDS_Customers.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery12});
            this.SDS_Customers.ResultSchemaSerializable = resources.GetString("SDS_Customers.ResultSchemaSerializable");
            // 
            // dte_Pickup
            // 
            this.dte_Pickup.EditValue = null;
            this.dte_Pickup.Location = new System.Drawing.Point(28, 88);
            this.dte_Pickup.Name = "dte_Pickup";
            this.dte_Pickup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Pickup.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Pickup.Properties.NullText = "Pickup Date";
            this.dte_Pickup.Properties.NullValuePrompt = "Pickup Date";
            this.dte_Pickup.Size = new System.Drawing.Size(168, 20);
            this.dte_Pickup.TabIndex = 4;
            // 
            // edt_factura
            // 
            this.edt_factura.Location = new System.Drawing.Point(28, 36);
            this.edt_factura.Name = "edt_factura";
            this.edt_factura.Properties.NullText = "Factura";
            this.edt_factura.Properties.NullValuePrompt = "Factura";
            this.edt_factura.Size = new System.Drawing.Size(168, 20);
            this.edt_factura.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(311, 448);
            this.panelControl2.TabIndex = 14;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(307, 444);
            this.pictureEdit1.TabIndex = 13;
            this.pictureEdit1.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // frm_PickupCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 448);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frm_PickupCapture";
            this.Text = "frm_PickupCapture";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_release.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_driver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoadsDriversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_GrainType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoadsGrainTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_pickupticket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_netoPickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tarePickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_grossPickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationPickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GlobalEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GrainLoadsCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_factura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_pickupDropbox;
        private DevExpress.XtraEditors.LookUpEdit lue_driver;
        private DevExpress.XtraEditors.LookUpEdit lue_GrainType;
        private DevExpress.XtraEditors.TextEdit edt_pickupticket;
        private DevExpress.XtraEditors.TextEdit edt_netoPickup;
        private DevExpress.XtraEditors.TextEdit edt_tarePickup;
        private DevExpress.XtraEditors.TextEdit edt_grossPickup;
        private DevExpress.XtraEditors.LookUpEdit lue_locationPickup;
        private DevExpress.XtraEditors.LookUpEdit lue_customer;
        private DevExpress.XtraEditors.DateEdit dte_Pickup;
        private DevExpress.XtraEditors.TextEdit edt_factura;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit edt_release;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_CancelPickup;
        private DevExpress.XtraEditors.SimpleButton btn_SavePickup;
        private System.Windows.Forms.BindingSource list_GrainLoadsDriversBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Drivers;
        private System.Windows.Forms.BindingSource list_GrainLoadsCustomersBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Customers;
        private System.Windows.Forms.BindingSource list_GrainLoadsGrainTypesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_GrainType;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_PickupLocations;
        private System.Windows.Forms.BindingSource list_GlobalEntitiesBindingSource;
    }
}