using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class PaymentMethod : crudHandler 
    {
        private string id;
        private string name;
        private string code;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }




        public DataTable getPaymentMethod()
        {
            return this.select("payment_methods");
        }

        public string getPaymentMethod(string code)
        {
            string query = "select * from payment_methods where code = '"+code+"'";
            return this.executeQuerey(query).Rows[0]["code"].ToString();
        }
    }
}
