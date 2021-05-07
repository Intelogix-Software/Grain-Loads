using DevExpress.XtraEditors;
using Main.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Grain_Capture : DevExpress.XtraEditors.XtraForm
    {
        public Grain_Capture()
        {
            InitializeComponent();
 
        }

        private void splitContainerControl1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_PickupCapture it = new frm_PickupCapture();
            it.ShowDialog();
            if (it.DialogResult== DialogResult.OK)
            {
                Console.WriteLine(it.newentry.id_customer.ToString());
            }
        }
    }
}