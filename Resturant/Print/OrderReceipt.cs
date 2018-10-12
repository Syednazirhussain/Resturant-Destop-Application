using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Print
{
    public class OrderReceipt
    {
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string item_qty { get; set; }
        public string price { get; set; }
        public string item_discount { get; set; }
        public string item_total { get; set; }

    }
}
