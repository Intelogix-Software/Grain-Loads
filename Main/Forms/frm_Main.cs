using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ITXFramework;

namespace Main
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static ITXFramework.ITXFramework ITX = new ITXFramework.ITXFramework();
        public frm_Main()
        {
            InitializeComponent();
        }

       

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grain_Capture it = new Grain_Capture();
            ITX.cfrm_InsertForm(it, pnl_conteiner);
        }
    }
}
