using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public class Card
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int PersonCount { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime InDate { get; set; }
        public Image Picture { get; set; }
    }
}
