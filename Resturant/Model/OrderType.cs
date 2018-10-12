using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class OrderType : crudHandler
    {
        
        public DataTable getOrderTypes()
        {
            return this.select("order_type");
        }


    }
}
