using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.GrainLoad


{
    class GrainLoad
    {
        public string Status { get; set; }
        public string Release { get; set; }
        public string Factura { get; set; }
        public DateTime Pickup_Date { get; set; }
        public string Customer { get; set; }
        public string Pickup_Ticket { get; set; }
        public string Pickup_Location { get; set; }
        public int Gross_Pickup { get; set; }
        public int Tare_Pickup { get; set; }
        public int Neto_Pickup { get; set; }
        public DateTime Delivery_Date { get; set;  }
        public string   Delivery_Ticket {get; set;}
        public string Delivery_Location { get; set; }
        public int Gross_Delivery { get; set; }
        public int Tare_Delivery { get; set; }
        public int Neto_Delivery { get; set; }
        public float Weight { get; set;  }
        public string Type { get; set;  }
        public string DriverList { get; set; }
        public float TotalPrice { get; set; }
        public string Period { get; set; }
        public string Notes { get; set; }


    }
}
