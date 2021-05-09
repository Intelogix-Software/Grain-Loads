using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    public class GrainLoadPickup
    {
        public Guid id_grainload { get; set; }
        public Guid id_customer { get; set; }
        public Guid id_pickup_location { get; set; }
        public Guid id_grainType { get; set; }
        public Guid id_driver { get; set; }
        public Guid id_who { get; set; }
        public DateTime regdate { get; set; }
        public string release { get; set; }
        public string factura { get; set; }
        public DateTime pickup_date { get; set; }
        public string pickup_ticket { get; set; }
        public Int32 gross_pickup { get; set; }
        public Int32 tare_pickup { get; set; }
        public Int32 neto_pickup { get; set; }
    }
}