﻿using DevExpress.XtraEditors;
using Main.Classes;
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
        public GrainLoadPickup newentry { get; set; }


        /// <summary>
        /// declarar Grain Load(usar la estrucura en pickupcapture para ser enviado a delivery por medio del row seleccionado.
        /// </summary>
        public Grain_Capture()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_DateColumns.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_GrainLoadsGRID.FillAsync();
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
                SQL.SQlCon conn = new SQL.SQlCon();

                conn.sendPickupToSQL(it.newentry);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            int idr;
            idr = gridView1.GetFocusedDataSourceRowIndex();
            Console.WriteLine(idr);
            Guid idg = (Guid)gridView1.GetFocusedRowCellValue("ID_GrainLoad");
            Console.WriteLine(idg.ToString());
        }
        private void setPickupLoad()
        {
            /*
            newentry = new GrainLoadPickup();
            newentry.release = edt_release.Text;
            newentry.factura = edt_factura.Text;
            newentry.id_driver = (Guid)lue_driver.EditValue;
            newentry.pickup_date = (DateTime)dte_Pickup.EditValue;
            newentry.id_customer = (Guid)lue_customer.EditValue;
            newentry.pickup_ticket = edt_pickupticket.Text;
            newentry.id_pickup_location = (Guid)lue_locationPickup.EditValue;
            newentry.id_grainType = (Guid)lue_GrainType.EditValue;
            newentry.gross_pickup = Convert.ToInt32(edt_grossPickup.Text);
            newentry.tare_pickup = Convert.ToInt32(edt_tarePickup.Text);
            newentry.neto_pickup = Convert.ToInt32(edt_netoPickup.Text);
            newentry.regdate = DateTime.Now;*/
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                Guid idg = (Guid)gridView1.GetFocusedRowCellValue("ID_GrainLoad");
                frm_DeliveryCapt it2 = new frm_DeliveryCapt(idg);
                it2.ShowDialog();
                if (it2.DialogResult == DialogResult.OK)
                {
                    Console.WriteLine(it2.SIDL);
                }



            }
            else
            {
                MessageBox.Show("Test");
            }
        }
    }
}