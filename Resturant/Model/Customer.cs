using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Customer : crudHandler
    {
        private string id { get; set; }
        private string name { get; set; }
        private string phone { get; set; }
        private string address { get; set; }
        private string email { get; set; }
        private string additional_info { get; set; }
        private string created_at { get; set; }
        private string updated_at { get; set; }

        public Customer()
        {
            this.id = null;
            this.name = null;
            this.phone = null;
            this.address = null;
            this.email = null;
            this.additional_info = null;
            this.created_at = null;
            this.updated_at = null;
        }

        public Customer(string customer_id)
        {
            this.id = customer_id;
        }

        public Customer(int customer_id, string name, string phone, string address, string email, string additional_info, string updated_at)
        {
            this.id = customer_id.ToString();
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.additional_info = additional_info;
            this.updated_at = updated_at;
        }

        public Customer(string name, string phone, string address, string email, string additional_info, string created_at, string updated_at)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.additional_info = additional_info;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }



        public DataTable getCustomer()
        {
            return this.select("customers");
        }

        public DataTable getCustomerById()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("id", this.id));

            return this.select("customers", whereClause, new string[] { "*" });
        }

        public int addCustomer()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("name", "\'" + this.name + "\'"));
            Columns.Add(Tuple.Create("email", "\'" + this.email + "\'"));
            Columns.Add(Tuple.Create("phone", "\'" + this.phone + "\'"));
            Columns.Add(Tuple.Create("address", "\'" + this.address + "\'"));
            Columns.Add(Tuple.Create("additional_info", "\'" + this.additional_info + "\'"));
            Columns.Add(Tuple.Create("created_at", "\'" + this.created_at + "\'"));
            Columns.Add(Tuple.Create("updated_at", "\'" + this.updated_at + "\'"));

            return this.insert("customers", Columns);

        }

        public bool checkPhoneAlreadyExist(string phone)
        {
            DataTable data = this.executeQuerey("select * from customers where phone = '"+phone+"'");
            if(data.Rows.Count > 0 && data.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int updateCustomer()
        {
            Hashtable Columns = new Hashtable();
            Columns.Add("name", "\'" + this.name + "\'");
            Columns.Add("email", "\'" + this.email + "\'");
            Columns.Add("phone", "\'" + this.phone + "\'");
            Columns.Add("address", "\'" + this.address + "\'");
            Columns.Add("additional_info", "\'" + this.additional_info + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id",this.id);

            return this.update("customers", Columns, whereClause);
        }

        public int deleteCustomer()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);
            return this.delete("customers",whereClause);
        }

        public DataTable searchCustomer(string keyword,string type)
        {
            if(type.Equals("Name"))
            {
                string querey = "select * from customers where name like '%" + keyword + "%'";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Phone"))
            {
                string querey = "select * from customers where phone like '" + keyword + "%'";
                return this.executeQuerey(querey);
            }
            else
            {
                return new DataTable();
            }
        }



    }
}
