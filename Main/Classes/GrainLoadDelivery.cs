using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    class GrainLoadDelivery
    {
        public Guid id_grainload { get; set; }
        public DateTime delivery_date { get; set;}
        public string delivery_ticket { get; set; }
        public Guid id_delivery_location { get; set;}
        public Int32 gross_delivery { get; set; }
        public Int32 tare_delivery { get; set; }
        public Int32 neto_delivery { get; set;}
        public Int32 weight { get; set; }
        public Int32 totalprice { get; set; }
        public Guid id_who { get; set; }
        public DateTime updateDate { get; set; }


    }
}
