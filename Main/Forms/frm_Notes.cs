using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.Classes;
using System.Web.UI;
using DevExpress.DataAccess.Sql.DataApi;

namespace Main
{
    public partial class frm_Notes : DevExpress.XtraEditors.XtraForm
    {
        public Guid ID_grainload { get; set; }
        public GrainLoadNotes extentry { get; set; }
        public frm_Notes(Guid id)
        {
            InitializeComponent();
            ID_grainload = id;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btn_notes_Click(object sender, EventArgs e)
        {
            extentry = new GrainLoadNotes();
            extentry.id_grainload =(Guid) ID_grainload;
            extentry.Notes = richEditControl1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frm_Notes_Load(object sender, EventArgs e)
        {
            SDS_note.ClearRows();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "@id_grainload";
            queryParameter1.Type = typeof(Guid);
            queryParameter1.Value = (Guid)ID_grainload;
            SDS_note.Queries[0].Parameters.Clear();
            SDS_note.Queries[0].Parameters.Add(queryParameter1);
            SDS_note.Fill();
            
        }
    }
}