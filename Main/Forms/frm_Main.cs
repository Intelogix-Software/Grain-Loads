using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DropboxITX;
using ITXFramework;
using Main.Forms;

namespace Main
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static ITXFramework.ITXFramework ITX = new ITXFramework.ITXFramework();
        public frm_Main()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grain_Capture it = new Grain_Capture();
            frm_PickupCapture itt = new frm_PickupCapture();
            ITX.cfrm_InsertForm(it, this.pnl_control);

        }
        private void pnl_control_SizeChanged(object sender, EventArgs e)
        {
            ITX.RefreshForms(this.pnl_control);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DropITX.ConfigApp("MyAppp", "sdslxym3u57958i");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}