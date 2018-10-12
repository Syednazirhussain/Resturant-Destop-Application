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
    public partial class KitchenReceiptPrint : Form
    {
        List<KitchenReceipt> _list;
        Dictionary<string, string> param;
        public KitchenReceiptPrint(List<KitchenReceipt> dataSource, Dictionary<string, string> _param)
        {
            InitializeComponent();
            _list = dataSource;
            this.param = _param;
        }

        private void KitchenReceipt_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            reportViewer.LocalReport.DataSources.Clear();

            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",dateTime.ToString("f")),
                new Microsoft.Reporting.WinForms.ReportParameter("pServerName",this.param["server_name"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pUser",this.param["user_name"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderType",this.param["order_type"])
            };

            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ds", KitchenReceiptPrint.ToDataTable(_list) ) );
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
