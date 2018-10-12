using Resturant.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class OrderForm : Form
    {

        //private MessageSnatcher _snatcher;

        private OrderType orderType;

        private DataTable dt_OrderTypes;

        private Floor floor;

        private TableZone tableZone;

        private Tables table;

        private Orders orders;

        private string floor_id, zone_id,floor_name,zone_name;

        private string selectedTable;

        private bool isTableSelected;


        private string orderType_id, orderType_name;


        public OrderForm()
        {
            InitializeComponent();

            this.isTableSelected = false;
            this.selectedTable = "";

            orderType = new OrderType();
            this.dt_OrderTypes = orderType.getOrderTypes();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();

            var results = this.dt_OrderTypes.Select("").FirstOrDefault(x => x["code"].ToString().Equals("dine_in"));
            if (results != null)
            {
                this.orderType_id = results["id"].ToString();
                this.orderType_name = results["code"].ToString();
            }

            floor = new Floor();
            cb_floor.DataSource = floor.getFloor();
            cb_floor.ValueMember = "id";
            cb_floor.DisplayMember = "name";
            cb_floor.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            mainPanel.Owner = this;
            this.Hide();
            mainPanel.Show();
        }

        private void tab_delievery_Enter(object sender, EventArgs e)
        {
            this.showDelieveryOrder();
        }

        private void btn_addDelieveryOrder_Click(object sender, EventArgs e)
        {
            var results = this.dt_OrderTypes.Select("").FirstOrDefault(x => x["code"].ToString().Equals("home_delivery"));
            if (results != null)
            {
                this.orderType_id = results["id"].ToString();
                this.orderType_name = results["code"].ToString();

                Hashtable orderData = new Hashtable();
                orderData.Add("orderTypeID", this.orderType_id);
                orderData.Add("orderTypeName", this.orderType_name);

                using (OrderED order = new OrderED(orderData))
                {
                    if (order.ShowDialog() != DialogResult.OK)
                    {

                    }
                }
            }
        }

        private void showDelieveryOrder()
        {
            flp_delievery.Controls.Clear();
            this.orders = new Orders();
            DataTable data = this.orders.getDelieveryOrder();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row["order_status_id"].ToString().Equals("1"))
                    {
                        DateTime dateTime = DateTime.Parse(row["created_at"].ToString());
                        string btnText = String.Format("Code: {0}\n\n{1}", row["id"].ToString(), dateTime.ToString("hh:mm tt"));

                        Button btn = new Button();
                        btn.Size = new Size(100, 75);
                        btn.ForeColor = Color.White;
                        btn.Font = new Font(btn.Font.FontFamily, 10);
                        btn.BackColor = Color.Green;
                        btn.Text = btnText;
                        btn.Name = row["id"].ToString();
                        btn.Click += delieveryOrder;
                        flp_delievery.Controls.Add(btn);
                    }

                }
            }
        }

        private void delieveryOrder(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            using (OrderED order = new OrderED(btn.Name))
            {
                if (order.ShowDialog() != DialogResult.OK)
                {
                    // do some thing 
                }
            }
        }
        private void btn_addTakeAwayOrder_Click(object sender, EventArgs e)
        {
            var results = this.dt_OrderTypes.Select("").FirstOrDefault(x => x["code"].ToString().Equals("take_away"));
            if (results != null)
            {
                this.orderType_id = results["id"].ToString();
                this.orderType_name = results["code"].ToString();

                Hashtable orderData = new Hashtable();
                orderData.Add("orderTypeID", this.orderType_id);
                orderData.Add("orderTypeName", this.orderType_name);

                using (OrderED order = new OrderED(orderData))
                {
                    if (order.ShowDialog() != DialogResult.OK)
                    {
                        this.showTakeAwayOrder();
                    }
                }
            }
        }
        private void tab_takeAway_Enter(object sender, EventArgs e)
        {
            this.showTakeAwayOrder();
        }

        private void showTakeAwayOrder()
        {
            flp_takeAway.Controls.Clear();
            this.orders = new Orders();
            DataTable data = this.orders.getTakeAwayOrders();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    if( row["order_status_id"].ToString().Equals("1") )
                    {
                        DateTime dateTime = DateTime.Parse(row["created_at"].ToString());
                        string btnText = String.Format("Code: {0}\n\n{1}", row["id"].ToString(), dateTime.ToString("hh:mm tt"));

                        Button btn = new Button();
                        btn.Size = new Size(100, 75);
                        btn.ForeColor = Color.White;
                        btn.Font = new Font(btn.Font.FontFamily, 10);
                        btn.BackColor = Color.Green;
                        btn.Text = btnText;
                        flp_takeAway.Controls.Add(btn);
                        btn.Name = row["id"].ToString();
                        btn.Click += takeAwayOrder;
                    }
                }
            }
        }

        private void takeAwayOrder(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            using (OrderED order = new OrderED(btn.Name))
            {
                if (order.ShowDialog() != DialogResult.OK)
                {
                    // do some thing 
                }
            }
        }

        private void tab_dinen_Enter(object sender, EventArgs e)
        {
            var results = this.dt_OrderTypes.Select("").FirstOrDefault(x => x["code"].ToString().Equals("dine_in"));
            if (results != null)
            {
                this.orderType_id = results["id"].ToString();
                this.orderType_name = results["code"].ToString();
            }

            floor = new Floor();
            cb_floor.DataSource = floor.getFloor();
            cb_floor.ValueMember = "id";
            cb_floor.DisplayMember = "name";
            cb_floor.SelectedIndex = 0;
            
        }

        private void cb_floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (int.TryParse(cb_floor.SelectedValue.ToString(), out int number))
            {
                this.floor_id = cb_floor.SelectedValue.ToString();
                this.floor_name = cb.Text;

                tableZone = new TableZone();
                DataTable dataZone = tableZone.getZoneByFloorId(this.floor_id);

                if (dataZone.Rows.Count > 0)
                {
                    cb_zone.DataSource = dataZone;
                    cb_zone.ValueMember = "id";
                    cb_zone.DisplayMember = "name";
                }
                else
                {
                    FLP_tables.Controls.Clear();
                    this.cb_zone.SelectedIndexChanged -= new EventHandler(cb_zone_SelectedIndexChanged);
                    cb_zone.DataSource = null;
                    cb_zone.Items.Clear();
                    this.cb_zone.SelectedIndexChanged += new EventHandler(cb_zone_SelectedIndexChanged);
                }

            }
        }

        private void cb_zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb_zone.Items.Count > 0)
            {
                if (int.TryParse(cb_zone.SelectedValue.ToString(), out int number))
                {
                    this.zone_id = cb_zone.SelectedValue.ToString();
                    this.zone_name = cb.Text;

                    table = new Tables();
                    DataTable dataTables = table.getTables(floor_id, zone_id);

                    this.orders = new Orders();

                    FLP_tables.Controls.Clear();
                    foreach (DataRow row in dataTables.Rows)
                    {
                        Button button = new Button();
                        button.Name = row["id"].ToString();
                        button.Text = row["name"].ToString();
                        button.Size = new Size(150, 75);

                        this.orders.Table_id = row["id"].ToString();
                        if (this.orders.isTableNotFree())
                        {
                            button.BackgroundImage = new Bitmap(Properties.Resources.table_unavailable);
                        }
                        else
                        {
                            button.BackgroundImage = new Bitmap(Properties.Resources.table_available);
                        }

                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.ImageAlign = ContentAlignment.TopCenter;
                        button.TextAlign = ContentAlignment.TopCenter;
                        button.TextImageRelation = TextImageRelation.TextBeforeImage;
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderColor = Color.WhiteSmoke;
                        button.FlatAppearance.BorderSize = 5;
                        button.Cursor = Cursors.Hand;
                        button.Click += Button_Click;
                        button.MouseHover += Button_MouseHover;
                        button.MouseLeave += Button_MouseLeave;
                        FLP_tables.Controls.Add(button);
                    }

                }
            }
            else
            {
                FLP_tables.Controls.Clear();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            this.isTableSelected = true;
            this.selectedTable = btn.Name;

            this.orders = new Orders();
            this.orders.Table_id = btn.Name;
            if (this.orders.isTableNotFree())
            {
                using (OrderED order = new OrderED(this.orders.getOrderIdByTable()))
                {
                    if (order.ShowDialog() != DialogResult.OK)
                    {
                        // do some thing 
                    }
                }
            }
            else
            {
                Hashtable orderData = new Hashtable();
                orderData.Add("orderTypeID", this.orderType_id);
                orderData.Add("orderTypeName", this.orderType_name);
                orderData.Add("floor_id", this.floor_id);
                orderData.Add("floor_name", this.floor_name);
                orderData.Add("zone_id", this.zone_id);
                orderData.Add("zone_name", this.zone_name);
                orderData.Add("table_id", btn.Name);
                orderData.Add("table_name", btn.Text);

                using (OrderED order = new OrderED(orderData))
                {
                    if (order.ShowDialog() != DialogResult.OK)
                    {
                        // do some thing 
                    }
                }
            }


            
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(this.isTableSelected)
            {
                if(this.selectedTable.Equals(btn.Name))
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.Yellow;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.Black;
            btn.ForeColor = Color.Yellow;
        }


    }
}
