using Resturant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Resturant
{
    public partial class ReportForm : Form
    {
        private Orders orders;
        public ReportForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            /*
             http://www.kettic.com/winforms_ui/csharp_guide/chart_series_types_pie.shtml
             */

            chart.Series.Clear();
            chart.Titles.Add("Total Income");
            Series series = chart.Series.Add("Total Income");
            series.ChartType = SeriesChartType.Line;
            series.Points.AddXY("September", 100);
            series.Points.AddXY("Obtober", 300);
            series.Points.AddXY("November", 800);
            series.Points.AddXY("December", 200);
            series.Points.AddXY("January", 600);
            series.Points.AddXY("February", 400);

            /*
            // Data arrays
            string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
            int[] pointsArray = { 2, 1, 7, 5 };

            // Set palette
            chart.Palette = ChartColorPalette.EarthTones;

            // Set title
            chart.Titles.Add("Animals");


            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = chart.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
            */



            /*
            chart.Titles.Add("Total Income");
            Series series = chart.Series.Add("Total Income");
            series.ChartType = SeriesChartType.Line;
            series.Points.AddXY("September", 100);
            series.Points.AddXY("Obtober", 300);
            series.Points.AddXY("November", 800);
            series.Points.AddXY("December", 200);
            series.Points.AddXY("January", 600);
            series.Points.AddXY("February", 400);
            */

            /*
                 var series = new Series("Finance");
                // Frist parameter is X-Axis and Second is Collection of Y- Axis
                series.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
                series.ChartType = SeriesChartType.Line;
                chart1.Series.Add(series);
             */


            dtp_start.ValueChanged += new EventHandler(start_date_picker_ValueChanged);
            dtp_end.ValueChanged += new EventHandler(end_date_picker_ValueChanged);

            orders = new Orders();
            this.FillGrid(orders.getOrders());
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgv_orders.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 14F, GraphicsUnit.Pixel);
            }
        }

        private void FillGrid(DataTable table)
        {
            string date = null;
            int counter = 0;
            List<string> items = new List<string>();
            Dictionary<string, double> data = new Dictionary<string, double>();
            dgv_orders.Rows.Clear();
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    if (data.Count > 0)
                    {
                        if (data.ContainsKey(row["id"].ToString()))
                        {
                            items.Add(row["item_name"].ToString());
                            if (table.Rows.Count - counter == 1)
                            {
                                int index = dgv_orders.Rows.Add();
                                dgv_orders.Rows[index].Cells["order_id"].Value = data.Keys.ElementAt(index);
                                dgv_orders.Rows[index].Cells["items"].Value = string.Join<string>(" | ", items);
                                dgv_orders.Rows[index].Cells["price"].Value = data.Values.ElementAt(index);
                                dgv_orders.Rows[index].Cells["date"].Value = DateTime.Parse(date).ToString("ddd dd MMM , yyyy hh:mm:ss:tt");
                            }
                        }
                        else
                        {
                            int index = dgv_orders.Rows.Add();
                            dgv_orders.Rows[index].Cells["order_id"].Value = data.Keys.ElementAt(index);
                            dgv_orders.Rows[index].Cells["items"].Value = string.Join<string>(" | ", items);
                            dgv_orders.Rows[index].Cells["price"].Value = data.Values.ElementAt(index);
                            dgv_orders.Rows[index].Cells["date"].Value = DateTime.Parse(date).ToString("ddd dd MMM , yyyy hh:mm:ss:tt");
                            date = null;
                            items.Clear();

                            date = row["created_at"].ToString();
                            data.Add(row["id"].ToString(), Convert.ToDouble(row["amount_received"].ToString()));
                            items.Add(row["item_name"].ToString());
                        }
                    }
                    else
                    {
                        date = row["created_at"].ToString();
                        data.Add(row["id"].ToString(), Convert.ToDouble(row["amount_received"].ToString()));
                        items.Add(row["item_name"].ToString());
                    }
                    counter++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            lbl_total.Text = data.Sum(x => x.Value).ToString();
            this.UpdateFont();
        }

        private void end_date_picker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (dtp_start.Value.Date < dtp.Value.Date)
            {
                this.FillGrid(orders.getOrders(dtp_start.Value.ToString("yyyy-MM-dd"), dtp_end.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                MessageBox.Show("End date must be less than start date", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dtp_end.Value = DateTime.Today;
            }
        }

        private void start_date_picker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (dtp.Value.Date < dtp_end.Value.Date)
            {
                this.FillGrid( orders.getOrders(dtp_start.Value.ToString("yyyy-MM-dd"), dtp_end.Value.ToString("yyyy-MM-dd")) );
            }
            else
            {
                MessageBox.Show("Start date must be greater than end date","Alert",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                dtp_start.Value = DateTime.Today;
            }
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }
    }
}
