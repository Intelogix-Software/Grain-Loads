﻿
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery15 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PickupCapture));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery16 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.edt_tarePickup = new DevExpress.XtraEditors.TextEdit();
            this.edt_grossPickup = new DevExpress.XtraEditors.TextEdit();
            this.lue_locationPickup = new DevExpress.XtraEditors.LookUpEdit();
            this.lue_customer = new DevExpress.XtraEditors.LookUpEdit();
            this.dte_Pickup = new DevExpress.XtraEditors.DateEdit();
            this.edt_factura = new DevExpress.XtraEditors.TextEdit();
            this.edt_release = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.SDS_DriversList = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.SDS_Customer = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tarePickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_grossPickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationPickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_factura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_release.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(586, 448);
            this.splitContainerControl1.SplitterPosition = 221;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.lookUpEdit3);
            this.panelControl1.Controls.Add(this.lookUpEdit2);
            this.panelControl1.Controls.Add(this.textEdit7);
            this.panelControl1.Controls.Add(this.textEdit6);
            this.panelControl1.Controls.Add(this.edt_tarePickup);
            this.panelControl1.Controls.Add(this.edt_grossPickup);
            this.panelControl1.Controls.Add(this.lue_locationPickup);
            this.panelControl1.Controls.Add(this.lue_customer);
            this.panelControl1.Controls.Add(this.dte_Pickup);
            this.panelControl1.Controls.Add(this.edt_factura);
            this.panelControl1.Controls.Add(this.edt_release);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(221, 448);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(28, 377);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 38);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(28, 62);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.DisplayMember = "Driver";
            this.lookUpEdit3.Properties.NullText = "Driver";
            this.lookUpEdit3.Properties.ValueMember = "IDDriver";
            this.lookUpEdit3.Size = new System.Drawing.Size(168, 20);
            this.lookUpEdit3.TabIndex = 3;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(28, 192);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.NullText = "Type";
            this.lookUpEdit2.Size = new System.Drawing.Size(168, 20);
            this.lookUpEdit2.TabIndex = 8;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(28, 140);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.NullText = "Pickup Ticket";
            this.textEdit7.Size = new System.Drawing.Size(168, 20);
            this.textEdit7.TabIndex = 6;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(28, 270);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.NullText = "Neto";
            this.textEdit6.Size = new System.Drawing.Size(168, 20);
            this.textEdit6.TabIndex = 11;
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
            this.lue_locationPickup.Properties.NullText = "Pickup Location";
            this.lue_locationPickup.Size = new System.Drawing.Size(168, 20);
            this.lue_locationPickup.TabIndex = 7;
            // 
            // lue_customer
            // 
            this.lue_customer.Location = new System.Drawing.Point(28, 114);
            this.lue_customer.Name = "lue_customer";
            this.lue_customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_customer.Properties.DisplayMember = "Customer";
            this.lue_customer.Properties.NullText = "Customer";
            this.lue_customer.Properties.ValueMember = "IDCustomer";
            this.lue_customer.Size = new System.Drawing.Size(168, 20);
            this.lue_customer.TabIndex = 5;
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
            this.dte_Pickup.Size = new System.Drawing.Size(168, 20);
            this.dte_Pickup.TabIndex = 4;
            // 
            // edt_factura
            // 
            this.edt_factura.Location = new System.Drawing.Point(28, 36);
            this.edt_factura.Name = "edt_factura";
            this.edt_factura.Properties.NullText = "Factura";
            this.edt_factura.Size = new System.Drawing.Size(168, 20);
            this.edt_factura.TabIndex = 2;
            // 
            // edt_release
            // 
            this.edt_release.Location = new System.Drawing.Point(-149, 85);
            this.edt_release.Name = "edt_release";
            this.edt_release.Properties.NullText = "Release";
            this.edt_release.Properties.NullValuePrompt = "Release";
            this.edt_release.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.edt_release.Size = new System.Drawing.Size(100, 20);
            this.edt_release.TabIndex = 21;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(355, 444);
            this.pictureEdit1.TabIndex = 13;
            this.pictureEdit1.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(28, 10);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.NullText = "Release";
            this.textEdit1.Properties.NullValuePrompt = "Release";
            this.textEdit1.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.textEdit1.Size = new System.Drawing.Size(168, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // SDS_DriversList
            // 
            this.SDS_DriversList.ConnectionName = "_ICCManager_Connection";
            this.SDS_DriversList.Name = "SDS_DriversList";
            storedProcQuery15.Name = "List_GrainLoadsDrivers";
            storedProcQuery15.StoredProcName = "List_GrainLoadsDrivers";
            this.SDS_DriversList.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery15});
            this.SDS_DriversList.ResultSchemaSerializable = resources.GetString("SDS_DriversList.ResultSchemaSerializable");
            // 
            // SDS_Customer
            // 
            this.SDS_Customer.ConnectionName = "_ICCManager_Connection";
            this.SDS_Customer.Name = "SDS_Customer";
            storedProcQuery16.Name = "List_GrainLoadsCustomers";
            storedProcQuery16.StoredProcName = "List_GrainLoadsCustomers";
            this.SDS_Customer.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery16});
            this.SDS_Customer.ResultSchemaSerializable = resources.GetString("SDS_Customer.ResultSchemaSerializable");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(359, 448);
            this.panelControl2.TabIndex = 14;
            // 
            // frm_PickupCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 448);
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
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tarePickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_grossPickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationPickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dte_Pickup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_factura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_release.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit edt_tarePickup;
        private DevExpress.XtraEditors.TextEdit edt_grossPickup;
        private DevExpress.XtraEditors.LookUpEdit lue_locationPickup;
        private DevExpress.XtraEditors.LookUpEdit lue_customer;
        private DevExpress.XtraEditors.DateEdit dte_Pickup;
        private DevExpress.XtraEditors.TextEdit edt_factura;
        private DevExpress.XtraEditors.TextEdit edt_release;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_DriversList;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Customer;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}