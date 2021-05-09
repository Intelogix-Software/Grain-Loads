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

        public Guid SIDL { get; set; }

        public frm_DeliveryCapt(Guid SelectedIDLoad)
        {
            InitializeComponent();
            Console.WriteLine(SelectedIDLoad.ToString());
            SIDL = SelectedIDLoad;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void frm_DeliveryCapt_Load(object sender, EventArgs e)
        {
            lbl_release.Text = edt_release.Text;
            lbl_Factura.Text = edt_factura.Text;
            lbl_driver.Text = lue_driver.Text;
            lbl_Customer.Text = lue_customer.Text;
            lbl_type.Text = lue_grainType.Text;
        }

        private void btn_SavePickup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}