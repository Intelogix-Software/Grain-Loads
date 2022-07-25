﻿
namespace Main.Forms
{
    partial class frm_DeliveryCapt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DeliveryCapt));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery9 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery10 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery11 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery12 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pnl_Pickup = new DevExpress.XtraEditors.PanelControl();
            this.btn_SaveDelivery = new DevExpress.XtraEditors.SimpleButton();
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
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lbl_type = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Customer = new DevExpress.XtraEditors.LabelControl();
            this.lbl_driver = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Factura = new DevExpress.XtraEditors.LabelControl();
            this.lbl_release = new DevExpress.XtraEditors.LabelControl();
            this.edt_totalPrice = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_weight = new DevExpress.XtraEditors.TextEdit();
            this.edt_netoDelivery = new DevExpress.XtraEditors.TextEdit();
            this.edt_tareDelivery = new DevExpress.XtraEditors.TextEdit();
            this.edt_grossDelivery = new DevExpress.XtraEditors.TextEdit();
            this.lue_deliveryLocation = new DevExpress.XtraEditors.LookUpEdit();
            this.list_GlobalEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.edt_DeliveryTicket = new DevExpress.XtraEditors.TextEdit();
            this.dedt_DeliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Main.Forms.WaitForm2), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Pickup)).BeginInit();
            this.pnl_Pickup.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).BeginInit();
            this.splitContainerControl3.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).BeginInit();
            this.splitContainerControl3.Panel2.SuspendLayout();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_totalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_weight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_netoDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tareDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_grossDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_deliveryLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GlobalEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_DeliveryTicket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_DeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_DeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.pnl_Pickup);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(746, 448);
            this.splitContainerControl1.SplitterPosition = 218;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // pnl_Pickup
            // 
            this.pnl_Pickup.Controls.Add(this.btn_SaveDelivery);
            this.pnl_Pickup.Controls.Add(this.btn_CancelPickup);
            this.pnl_Pickup.Controls.Add(this.edt_release);
            this.pnl_Pickup.Controls.Add(this.btn_pickupDropbox);
            this.pnl_Pickup.Controls.Add(this.lue_driver);
            this.pnl_Pickup.Controls.Add(this.lue_GrainType);
            this.pnl_Pickup.Controls.Add(this.edt_pickupticket);
            this.pnl_Pickup.Controls.Add(this.edt_netoPickup);
            this.pnl_Pickup.Controls.Add(this.edt_tarePickup);
            this.pnl_Pickup.Controls.Add(this.edt_grossPickup);
            this.pnl_Pickup.Controls.Add(this.lue_locationPickup);
            this.pnl_Pickup.Controls.Add(this.lue_customer);
            this.pnl_Pickup.Controls.Add(this.dte_Pickup);
            this.pnl_Pickup.Controls.Add(this.edt_factura);
            this.pnl_Pickup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Pickup.Location = new System.Drawing.Point(0, 0);
            this.pnl_Pickup.Name = "pnl_Pickup";
            this.pnl_Pickup.Size = new System.Drawing.Size(218, 448);
            this.pnl_Pickup.TabIndex = 1;
            // 
            // btn_SaveDelivery
            // 
            this.btn_SaveDelivery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveDelivery.ImageOptions.Image")));
            this.btn_SaveDelivery.Location = new System.Drawing.Point(28, 340);
            this.btn_SaveDelivery.Name = "btn_SaveDelivery";
            this.btn_SaveDelivery.Size = new System.Drawing.Size(168, 50);
            this.btn_SaveDelivery.TabIndex = 25;
            this.btn_SaveDelivery.Text = "Save";
            this.btn_SaveDelivery.Click += new System.EventHandler(this.btn_SaveDelivery_Click);
            // 
            // btn_CancelPickup
            // 
            this.btn_CancelPickup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelPickup.ImageOptions.Image")));
            this.btn_CancelPickup.Location = new System.Drawing.Point(28, 396);
            this.btn_CancelPickup.Name = "btn_CancelPickup";
            this.btn_CancelPickup.Size = new System.Drawing.Size(168, 30);
            this.btn_CancelPickup.TabIndex = 24;
            this.btn_CancelPickup.Text = "Cancel";
            // 
            // edt_release
            // 
            this.edt_release.Enabled = false;
            this.edt_release.Location = new System.Drawing.Point(28, 10);
            this.edt_release.Name = "edt_release";
            this.edt_release.Properties.NullText = "Release";
            this.edt_release.Properties.NullValuePrompt = "Release";
            this.edt_release.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.edt_release.Size = new System.Drawing.Size(168, 20);
            this.edt_release.TabIndex = 1;
            // 
            // btn_pickupDropbox
            // 
            this.btn_pickupDropbox.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pickupDropbox.ImageOptions.Image")));
            this.btn_pickupDropbox.Location = new System.Drawing.Point(28, 296);
            this.btn_pickupDropbox.Name = "btn_pickupDropbox";
            this.btn_pickupDropbox.Size = new System.Drawing.Size(168, 38);
            this.btn_pickupDropbox.TabIndex = 12;
            this.btn_pickupDropbox.Text = "Upload Pickup Photo";
            this.btn_pickupDropbox.Click += new System.EventHandler(this.btn_pickupDropbox_Click);
            // 
            // lue_driver
            // 
            this.lue_driver.Enabled = false;
            this.lue_driver.Location = new System.Drawing.Point(28, 62);
            this.lue_driver.Name = "lue_driver";
            this.lue_driver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_driver.Properties.DataSource = this.list_GrainLoadsDriversBindingSource;
            this.lue_driver.Properties.DisplayMember = "Driver";
            this.lue_driver.Properties.NullText = "Driver";
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
            this.lue_GrainType.Enabled = false;
            this.lue_GrainType.Location = new System.Drawing.Point(28, 192);
            this.lue_GrainType.Name = "lue_GrainType";
            this.lue_GrainType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_GrainType.Properties.DataSource = this.list_GrainLoadsGrainTypesBindingSource;
            this.lue_GrainType.Properties.DisplayMember = "GrainType";
            this.lue_GrainType.Properties.NullText = "GrainType";
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
            this.edt_pickupticket.Enabled = false;
            this.edt_pickupticket.Location = new System.Drawing.Point(28, 140);
            this.edt_pickupticket.Name = "edt_pickupticket";
            this.edt_pickupticket.Properties.NullText = "Pickup Ticket";
            this.edt_pickupticket.Size = new System.Drawing.Size(168, 20);
            this.edt_pickupticket.TabIndex = 6;
            // 
            // edt_netoPickup
            // 
            this.edt_netoPickup.Enabled = false;
            this.edt_netoPickup.Location = new System.Drawing.Point(28, 270);
            this.edt_netoPickup.Name = "edt_netoPickup";
            this.edt_netoPickup.Properties.NullText = "Neto";
            this.edt_netoPickup.Size = new System.Drawing.Size(168, 20);
            this.edt_netoPickup.TabIndex = 11;
            // 
            // edt_tarePickup
            // 
            this.edt_tarePickup.Enabled = false;
            this.edt_tarePickup.Location = new System.Drawing.Point(28, 244);
            this.edt_tarePickup.Name = "edt_tarePickup";
            this.edt_tarePickup.Properties.NullText = "Tare";
            this.edt_tarePickup.Size = new System.Drawing.Size(168, 20);
            this.edt_tarePickup.TabIndex = 10;
            // 
            // edt_grossPickup
            // 
            this.edt_grossPickup.Enabled = false;
            this.edt_grossPickup.Location = new System.Drawing.Point(28, 218);
            this.edt_grossPickup.Name = "edt_grossPickup";
            this.edt_grossPickup.Properties.NullText = "Gross";
            this.edt_grossPickup.Size = new System.Drawing.Size(168, 20);
            this.edt_grossPickup.TabIndex = 9;
            // 
            // lue_locationPickup
            // 
            this.lue_locationPickup.Enabled = false;
            this.lue_locationPickup.Location = new System.Drawing.Point(28, 166);
            this.lue_locationPickup.Name = "lue_locationPickup";
            this.lue_locationPickup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_locationPickup.Properties.DataSource = this.list_GlobalEntitiesBindingSource;
            this.lue_locationPickup.Properties.DisplayMember = "Description";
            this.lue_locationPickup.Properties.NullText = "Pickup Location";
            this.lue_locationPickup.Properties.ValueMember = "ID_Location";
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
            storedProcQuery11.StoredProcName = "List_GlobalLocations";
            this.SDS_PickupLocations.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery11});
            this.SDS_PickupLocations.ResultSchemaSerializable = resources.GetString("SDS_PickupLocations.ResultSchemaSerializable");
            // 
            // lue_customer
            // 
            this.lue_customer.Enabled = false;
            this.lue_customer.Location = new System.Drawing.Point(28, 114);
            this.lue_customer.Name = "lue_customer";
            this.lue_customer.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.lue_customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_customer.Properties.DataSource = this.list_GrainLoadsCustomersBindingSource;
            this.lue_customer.Properties.DisplayMember = "CustomerName";
            this.lue_customer.Properties.KeyMember = "(none";
            this.lue_customer.Properties.NullText = "Customer";
            this.lue_customer.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
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
            this.dte_Pickup.Enabled = false;
            this.dte_Pickup.Location = new System.Drawing.Point(28, 88);
            this.dte_Pickup.Name = "dte_Pickup";
            this.dte_Pickup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Pickup.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dte_Pickup.Properties.NullText = "Pickup Date";
            this.dte_Pickup.Size = new System.Drawing.Size(168, 20);
            this.dte_Pickup.TabIndex = 4;
            // 
            // edt_factura
            // 
            this.edt_factura.Enabled = false;
            this.edt_factura.Location = new System.Drawing.Point(28, 36);
            this.edt_factura.Name = "edt_factura";
            this.edt_factura.Properties.NullText = "Factura";
            this.edt_factura.Size = new System.Drawing.Size(168, 20);
            this.edt_factura.TabIndex = 2;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            // 
            // splitContainerControl3.Panel1
            // 
            this.splitContainerControl3.Panel1.Controls.Add(this.lbl_type);
            this.splitContainerControl3.Panel1.Controls.Add(this.lbl_Customer);
            this.splitContainerControl3.Panel1.Controls.Add(this.lbl_driver);
            this.splitContainerControl3.Panel1.Controls.Add(this.lbl_Factura);
            this.splitContainerControl3.Panel1.Controls.Add(this.lbl_release);
            this.splitContainerControl3.Panel1.Controls.Add(this.edt_totalPrice);
            this.splitContainerControl3.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl3.Panel1.Controls.Add(this.edt_weight);
            this.splitContainerControl3.Panel1.Controls.Add(this.edt_netoDelivery);
            this.splitContainerControl3.Panel1.Controls.Add(this.edt_tareDelivery);
            this.splitContainerControl3.Panel1.Controls.Add(this.edt_grossDelivery);
            this.splitContainerControl3.Panel1.Controls.Add(this.lue_deliveryLocation);
            this.splitContainerControl3.Panel1.Controls.Add(this.edt_DeliveryTicket);
            this.splitContainerControl3.Panel1.Controls.Add(this.dedt_DeliveryDate);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            // 
            // splitContainerControl3.Panel2
            // 
            this.splitContainerControl3.Panel2.Controls.Add(this.pictureEdit2);
            this.splitContainerControl3.Panel2.Controls.Add(this.pictureEdit1);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(522, 448);
            this.splitContainerControl3.SplitterPosition = 215;
            this.splitContainerControl3.TabIndex = 0;
            // 
            // lbl_type
            // 
            this.lbl_type.Location = new System.Drawing.Point(23, 195);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(63, 13);
            this.lbl_type.TabIndex = 27;
            this.lbl_type.Text = "labelControl5";
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.Location = new System.Drawing.Point(23, 117);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(63, 13);
            this.lbl_Customer.TabIndex = 26;
            this.lbl_Customer.Text = "labelControl4";
            // 
            // lbl_driver
            // 
            this.lbl_driver.Location = new System.Drawing.Point(23, 65);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(63, 13);
            this.lbl_driver.TabIndex = 25;
            this.lbl_driver.Text = "labelControl3";
            // 
            // lbl_Factura
            // 
            this.lbl_Factura.Location = new System.Drawing.Point(23, 39);
            this.lbl_Factura.Name = "lbl_Factura";
            this.lbl_Factura.Size = new System.Drawing.Size(63, 13);
            this.lbl_Factura.TabIndex = 24;
            this.lbl_Factura.Text = "labelControl2";
            // 
            // lbl_release
            // 
            this.lbl_release.Location = new System.Drawing.Point(23, 13);
            this.lbl_release.Name = "lbl_release";
            this.lbl_release.Size = new System.Drawing.Size(63, 13);
            this.lbl_release.TabIndex = 23;
            this.lbl_release.Text = "labelControl1";
            // 
            // edt_totalPrice
            // 
            this.edt_totalPrice.Location = new System.Drawing.Point(23, 322);
            this.edt_totalPrice.Name = "edt_totalPrice";
            this.edt_totalPrice.Properties.NullText = "Total Price";
            this.edt_totalPrice.Size = new System.Drawing.Size(176, 20);
            this.edt_totalPrice.TabIndex = 21;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(23, 352);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 38);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Upload Delivery Photo";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // edt_weight
            // 
            this.edt_weight.Location = new System.Drawing.Point(23, 296);
            this.edt_weight.Name = "edt_weight";
            this.edt_weight.Properties.NullText = "Weight";
            this.edt_weight.Size = new System.Drawing.Size(176, 20);
            this.edt_weight.TabIndex = 20;
            // 
            // edt_netoDelivery
            // 
            this.edt_netoDelivery.Location = new System.Drawing.Point(23, 270);
            this.edt_netoDelivery.Name = "edt_netoDelivery";
            this.edt_netoDelivery.Properties.NullText = "Neto";
            this.edt_netoDelivery.Size = new System.Drawing.Size(176, 20);
            this.edt_netoDelivery.TabIndex = 19;
            this.edt_netoDelivery.EditValueChanged += new System.EventHandler(this.edt_netoDelivery_EditValueChanged);
            // 
            // edt_tareDelivery
            // 
            this.edt_tareDelivery.Location = new System.Drawing.Point(23, 244);
            this.edt_tareDelivery.Name = "edt_tareDelivery";
            this.edt_tareDelivery.Properties.NullText = "Tare";
            this.edt_tareDelivery.Size = new System.Drawing.Size(176, 20);
            this.edt_tareDelivery.TabIndex = 18;
            // 
            // edt_grossDelivery
            // 
            this.edt_grossDelivery.Location = new System.Drawing.Point(23, 218);
            this.edt_grossDelivery.Name = "edt_grossDelivery";
            this.edt_grossDelivery.Properties.NullText = "Gross";
            this.edt_grossDelivery.Size = new System.Drawing.Size(176, 20);
            this.edt_grossDelivery.TabIndex = 17;
            // 
            // lue_deliveryLocation
            // 
            this.lue_deliveryLocation.Location = new System.Drawing.Point(23, 166);
            this.lue_deliveryLocation.Name = "lue_deliveryLocation";
            this.lue_deliveryLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_deliveryLocation.Properties.DataSource = this.list_GlobalEntitiesBindingSource1;
            this.lue_deliveryLocation.Properties.DisplayMember = "Description";
            this.lue_deliveryLocation.Properties.NullText = "Delivery Location";
            this.lue_deliveryLocation.Properties.ValueMember = "ID_Location";
            this.lue_deliveryLocation.Size = new System.Drawing.Size(176, 20);
            this.lue_deliveryLocation.TabIndex = 16;
            // 
            // list_GlobalEntitiesBindingSource1
            // 
            this.list_GlobalEntitiesBindingSource1.DataMember = "List_GlobalEntities";
            this.list_GlobalEntitiesBindingSource1.DataSource = this.SDS_PickupLocations;
            // 
            // edt_DeliveryTicket
            // 
            this.edt_DeliveryTicket.Location = new System.Drawing.Point(23, 140);
            this.edt_DeliveryTicket.Name = "edt_DeliveryTicket";
            this.edt_DeliveryTicket.Properties.NullText = "Delivery Ticket";
            this.edt_DeliveryTicket.Size = new System.Drawing.Size(176, 20);
            this.edt_DeliveryTicket.TabIndex = 15;
            // 
            // dedt_DeliveryDate
            // 
            this.dedt_DeliveryDate.EditValue = null;
            this.dedt_DeliveryDate.Location = new System.Drawing.Point(23, 88);
            this.dedt_DeliveryDate.Name = "dedt_DeliveryDate";
            this.dedt_DeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedt_DeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedt_DeliveryDate.Properties.NullText = "Delivery Date";
            this.dedt_DeliveryDate.Size = new System.Drawing.Size(176, 20);
            this.dedt_DeliveryDate.TabIndex = 14;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit2.Location = new System.Drawing.Point(0, 225);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(301, 223);
            this.pictureEdit2.TabIndex = 23;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(301, 225);
            this.pictureEdit1.TabIndex = 13;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frm_DeliveryCapt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 448);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frm_DeliveryCapt";
            this.Text = "frm_DeliveryCapt";
            this.Load += new System.EventHandler(this.frm_DeliveryCapt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Pickup)).EndInit();
            this.pnl_Pickup.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).EndInit();
            this.splitContainerControl3.Panel1.ResumeLayout(false);
            this.splitContainerControl3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).EndInit();
            this.splitContainerControl3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_totalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_weight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_netoDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tareDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_grossDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_deliveryLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_GlobalEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_DeliveryTicket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_DeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedt_DeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.DateEdit dedt_DeliveryDate;
        private DevExpress.XtraEditors.TextEdit edt_DeliveryTicket;
        private DevExpress.XtraEditors.LookUpEdit lue_deliveryLocation;
        private DevExpress.XtraEditors.TextEdit edt_grossDelivery;
        private DevExpress.XtraEditors.TextEdit edt_tareDelivery;
        private DevExpress.XtraEditors.TextEdit edt_netoDelivery;
        private DevExpress.XtraEditors.TextEdit edt_weight;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit edt_totalPrice;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl pnl_Pickup;
        private DevExpress.XtraEditors.TextEdit edt_release;
        private DevExpress.XtraEditors.SimpleButton btn_pickupDropbox;
        private DevExpress.XtraEditors.LookUpEdit lue_driver;
        private DevExpress.XtraEditors.LookUpEdit lue_GrainType;
        private DevExpress.XtraEditors.TextEdit edt_pickupticket;
        private DevExpress.XtraEditors.TextEdit edt_netoPickup;
        private DevExpress.XtraEditors.TextEdit edt_tarePickup;
        private DevExpress.XtraEditors.TextEdit edt_grossPickup;
        private DevExpress.XtraEditors.LookUpEdit lue_locationPickup;
        private DevExpress.XtraEditors.DateEdit dte_Pickup;
        private DevExpress.XtraEditors.TextEdit edt_factura;
        private DevExpress.XtraEditors.LabelControl lbl_type;
        private DevExpress.XtraEditors.LabelControl lbl_Customer;
        private DevExpress.XtraEditors.LabelControl lbl_driver;
        private DevExpress.XtraEditors.LabelControl lbl_Factura;
        private DevExpress.XtraEditors.LabelControl lbl_release;
        private DevExpress.XtraEditors.SimpleButton btn_SaveDelivery;
        private DevExpress.XtraEditors.SimpleButton btn_CancelPickup;
        public DevExpress.XtraEditors.LookUpEdit lue_customer;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Customers;
        private System.Windows.Forms.BindingSource list_GrainLoadsCustomersBindingSource;
        private System.Windows.Forms.BindingSource list_GrainLoadsDriversBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Drivers;
        private System.Windows.Forms.BindingSource list_GlobalEntitiesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_PickupLocations;
        private System.Windows.Forms.BindingSource list_GrainLoadsGrainTypesBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_GrainType;
        private System.Windows.Forms.BindingSource list_GlobalEntitiesBindingSource1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}