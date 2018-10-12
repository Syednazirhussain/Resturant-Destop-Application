using Resturant.Model;
using Resturant.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class OrderPrePaymentPrint : Form
    {
        List<OrderReceipt> list;

        Dictionary<string, string> item;

        public OrderPrePaymentPrint(List<OrderReceipt> dataSource, Dictionary<string, string> _item)
        {
            InitializeComponent();
            this.list = dataSource;
            this.item = _item;
        }

        private void OrderPrePaymentPrint_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string date = dateTime.ToString("f");

            reportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[] 
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pServerName",item["server_name"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pSumQty",item["sum_qty"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",item["total"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pUser",item["user_name"]),
                new Microsoft.Reporting.WinForms.ReportParameter("date",date)
            };
            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", OrderPrePaymentPrint.ToDataTable(this.list) ));
            this.reportViewer.LocalReport.SetParameters(parameters);
            this.reportViewer.RefreshReport();
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

    }
}
