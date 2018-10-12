using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class Tables : crudHandler
    {

        private string id;
        private string floor_id;
        private string table_zone_id;
        private string table_name;
        private string num_seats;

        public Tables()
        {
            this.id = null;
        }

        public Tables(string table_id)
        {
            this.id = table_id;
        }

        public Tables(string floor_id,string tableZone_id,string table_name,string num_seats)
        {
            this.floor_id = floor_id;
            this.table_zone_id = tableZone_id;
            this.table_name = table_name;
            this.num_seats = num_seats;
        }

        public Tables(string table_id,string floor_id, string tableZone_id, string table_name, string num_seats)
        {
            this.id = table_id;
            this.floor_id = floor_id;
            this.table_zone_id = tableZone_id;
            this.table_name = table_name;
            this.num_seats = num_seats;
        }

        public DataTable getTableById()
        {
            List<Tuple<string, string>> whereClause = new List<Tuple<string, string>>();
            whereClause.Add(Tuple.Create("id",this.id));
            return this.select("table_seats", whereClause);
        }

        public DataTable getTables()
        {
            string querey = "SELECT table_seats.id,floors.id as f_id, floors.name as floorname ,";
            querey += "table_zones.id as tz_id,table_zones.name as tablezone , table_seats.name , table_seats.num_seats from table_seats inner join table_zones on table_seats.zone_id = table_zones.id inner ";
            querey += "join floors on table_zones.floor_id = floors.id order by table_seats.name";
            return this.executeQuerey(querey);
        }

        public DataTable getTables(string floor_id,string zone_id)
        {
            return this.executeQuerey("select * from table_seats where floor_id = " + floor_id + " and zone_id = " + zone_id);
        }

        public int addTable()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("floor_id", this.floor_id));
            Columns.Add(Tuple.Create("zone_id", this.table_zone_id));
            Columns.Add(Tuple.Create("name", "\'" + this.table_name + "\'"));
            Columns.Add(Tuple.Create("num_seats", this.num_seats));
            return this.insert("table_seats", Columns);
        }
        public DataTable searchTable(string keyword,string type)
        {
            if(type.Equals("Table"))
            {
                string querey = "SELECT table_seats.id,floors.id as f_id, floors.name as floorname ,";
                querey += "table_zones.id as tz_id,table_zones.name as tablezone , table_seats.name , table_seats.num_seats from table_seats inner join table_zones on table_seats.zone_id = table_zones.id inner ";
                querey += "join floors on table_zones.floor_id = floors.id where table_seats.name like '%"+keyword+"%'";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Seat"))
            {
                string querey = "SELECT table_seats.id,floors.id as f_id, floors.name as floorname ,";
                querey += "table_zones.id as tz_id,table_zones.name as tablezone , table_seats.name , table_seats.num_seats from table_seats inner join table_zones on table_seats.zone_id = table_zones.id inner ";
                querey += "join floors on table_zones.floor_id = floors.id where table_seats.num_seats like '" + keyword + "'";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Floor"))
            {
                string querey = "SELECT table_seats.id,floors.id as f_id, floors.name as floorname ,";
                querey += "table_zones.id as tz_id,table_zones.name as tablezone , table_seats.name , table_seats.num_seats from table_seats inner join table_zones on table_seats.zone_id = table_zones.id inner ";
                querey += "join floors on table_zones.floor_id = floors.id where floors.name like '%" + keyword + "%'";
                return this.executeQuerey(querey);
            }
            else if(type.Equals("Zone"))
            {
                string querey = "SELECT table_seats.id,floors.id as f_id, floors.name as floorname ,";
                querey += "table_zones.id as tz_id,table_zones.name as tablezone , table_seats.name , table_seats.num_seats from table_seats inner join table_zones on table_seats.zone_id = table_zones.id inner ";
                querey += "join floors on table_zones.floor_id = floors.id where table_zones.name like '%" + keyword + "%'";
                return this.executeQuerey(querey);
            }
            else
            {
                return new DataTable();
            }
        }
        public int updateTable()
        {

            Hashtable columns = new Hashtable();
            columns.Add("floor_id", this.floor_id);
            columns.Add("zone_id", this.table_zone_id);
            columns.Add("num_seats", this.num_seats);
            columns.Add("name", "\'" + this.table_name + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return this.update("table_seats", columns, whereClause);
        }

        public int deleteTable()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);
            return this.delete("table_seats", whereClause);
        }





    }
}
