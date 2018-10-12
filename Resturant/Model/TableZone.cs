using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant.Model
{
    class TableZone : crudHandler
    {

        private string id,floor_id,name;

        public TableZone()
        {
            this.id = null;
        }

        public TableZone(string zone_id)
        {
            this.id = zone_id;
        }

        public TableZone(string floorId,string zoneName)
        {
            this.floor_id = floorId;
            this.name = zoneName;
        }

        public TableZone(string zoneId,string floorId, string zoneName)
        {
            this.id = zoneId;
            this.floor_id = floorId;
            this.name = zoneName;
        }

        public DataTable getTableZoneById()
        {
            List<Tuple<string, string>> columns = new List<Tuple<string, string>>();
            columns.Add(Tuple.Create("id", this.id));

            return this.select("table_zones", columns);
        }


        public DataTable getZoneByFloorId(string floor_id)
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("floor_id", floor_id));
            return this.select("table_zones", Columns);
        }

        public DataTable searchZone(string keyword,string type)
        {
            if(type.Equals("Floor"))
            {
                return this.executeQuerey("select table_zones.id as t_id , table_zones.name as t_name, floors.id  as f_id, floors.name as f_name from table_zones inner join floors where table_zones.floor_id = floors.id and floors.name like '%"+keyword+"%'");
            }
            else if(type.Equals("Zone"))
            {
                return this.executeQuerey("select table_zones.id as t_id , table_zones.name as t_name, floors.id  as f_id, floors.name as f_name from table_zones inner join floors where table_zones.floor_id = floors.id and table_zones.name like '%" + keyword + "%'");
            }
            else
            {
                return new DataTable();
            }
        }

        public DataTable getZone()
        {
            return this.select("table_zones");
        }

        public DataTable getTableZone()
        {
            string querey = "select table_zones.id as t_id , table_zones.name as t_name, floors.id  as f_id, floors.name as f_name from table_zones inner join floors where table_zones.floor_id = floors.id";
            return this.executeQuerey(querey);
        }

        public int addTableZone()
        {
            List<Tuple<string, string>> Columns = new List<Tuple<string, string>>();
            Columns.Add(Tuple.Create("floor_id", "\'" + this.floor_id + "\'"));
            Columns.Add(Tuple.Create("name", "\'" + this.name + "\'"));
            return this.insert("table_zones", Columns);
        }

        public int updateTableZone()
        {

            Hashtable columns = new Hashtable();
            columns.Add("floor_id", this.floor_id);
            columns.Add("name", "\'" + this.name + "\'");

            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);

            return this.update("table_zones", columns, whereClause);
        }

        public int deleteTableZone()
        {
            Hashtable whereClause = new Hashtable();
            whereClause.Add("id", this.id);
            return this.delete("table_zones", whereClause);
        }
    }
}
