using DevExpress.XtraEditors;
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
    public partial class frm_DeliveryCapt : DevExpress.XtraEditors.XtraForm 
    {
        public GrainLoadDelivery extentry { get; set; }

        public GrainLoadPickup GLP { get; set; }

        public frm_DeliveryCapt(GrainLoadPickup sglp)
        {
            InitializeComponent();
            Console.WriteLine(sglp.id_grainload);
            GLP = sglp;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void frm_DeliveryCapt_Load(object sender, EventArgs e)
        {
            edt_release.Text = GLP.release;
            edt_factura.Text = GLP.factura;
            lue_driver.EditValue = GLP.id_driver;
            dte_Pickup.EditValue = GLP.pickup_date;
            lue_customer.EditValue = GLP.id_customer;
            edt_pickupticket.Text = GLP.pickup_ticket;
            lue_locationPickup.EditValue = GLP.id_pickup_location;
            lue_GrainType.EditValue = GLP.id_grainType;
            edt_grossPickup.Text=GLP.gross_pickup.ToString();
            edt_tarePickup.Text = GLP.tare_pickup.ToString();
            edt_netoPickup.Text = GLP.neto_pickup.ToString();

            lue_driver.Text = GLP.id_driver.ToString();
            dte_Pickup.Text = GLP.pickup_date.ToString();
            lue_customer.Text = GLP.id_customer.ToString();
            lue_locationPickup.Text = GLP.id_pickup_location.ToString();
            lue_GrainType.Text = GLP.id_grainType.ToString();

            lbl_release.Text = edt_release.Text;
            lbl_Factura.Text = edt_factura.Text;
            lbl_driver.Text = lue_driver.Text;
            lbl_Customer.Text = lue_customer.Text;
            lbl_type.Text = lue_GrainType.Text;
        }

        private void btn_SavePickup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}