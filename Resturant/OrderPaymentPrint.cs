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
    public partial class OrderPaymentPrint : Form
    {

        private Orders orders;
        public OrderPaymentPrint(List<OrderReceipt> dataSource,Dictionary<string,string> item_list)
        {
            InitializeComponent();

            DateTime dateTime = DateTime.UtcNow.Date;
            reportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", item_list["total"] ),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiscount",item_list["discount"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderNo",item_list["order_id"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderType",item_list["order_type"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pBarCode",item_list["barcode_image"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pPaymentReceived",item_list["payment_received"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pCashBack",item_list["cash_back"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pSumQty",item_list["sum_qty"]),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",dateTime.ToString("f"))
            };
            reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ds", OrderPaymentPrint.ToDataTable(dataSource)));
            this.reportViewer.LocalReport.SetParameters(parameters);
            this.reportViewer.RefreshReport();
        }

        private void OrderPaymentPrint_Load(object sender, EventArgs e)
        {
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
