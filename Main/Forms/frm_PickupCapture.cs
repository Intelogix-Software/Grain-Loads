﻿using DevExpress.XtraEditors;
using Main.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Forms
{
    public partial class frm_PickupCapture : DevExpress.XtraEditors.XtraForm
    {
        public GrainLoadPickup newentry { get; set;}
        public frm_PickupCapture()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_Drivers.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_Customers.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_GrainType.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_PickupLocations.FillAsync();
        }
        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            //openImageViewer
        }
        private void btn_SavePickup_Click(object sender, EventArgs e)
        {
            newentry = new GrainLoadPickup();
            newentry.release = edt_release.Text;
            newentry.factura = edt_factura.Text;
            newentry.id_driver = (Guid)lue_driver.EditValue;
            newentry.pickup_date = (DateTime)dte_Pickup.EditValue;
            newentry.id_customer = (Guid)lue_customer.EditValue;
            newentry.pickup_ticket = edt_pickupticket.Text;
            newentry.id_pickup_location = (Guid)lue_locationPickup.EditValue;
            newentry.id_grainType = (Guid)lue_GrainType.EditValue;
            newentry.gross_pickup = Convert.ToInt32( edt_grossPickup.Text);
            newentry.tare_pickup = Convert.ToInt32(edt_tarePickup.Text);
            newentry.neto_pickup = Convert.ToInt32(edt_netoPickup.Text);
            newentry.regdate = DateTime.Now;
            this.DialogResult=DialogResult.OK;
            this.Close();
        }

        private void btn_CancelPickup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}