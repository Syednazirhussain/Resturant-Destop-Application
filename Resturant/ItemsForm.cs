using Resturant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class ItemsForm : Form
    {
        private Items items;

        private Category category;

        private string appPath;

        public ItemsForm()
        {
            InitializeComponent();
            lbl_userType.Text = "User Type : " + Login.user_role.ToUpper();
            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ItemsImages\";
            category = new Category();

            cb_search.Items.Add("Name");
            cb_search.Items.Add("Category");
            cb_search.SelectedIndex = 0;

            btn_clear.Hide();

        }

        #region General

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
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

        #endregion

        #region Category

        private void refreshCategory(DataTable data)
        {
            dgv_category.Rows.Clear();
            int sno = 0;
            foreach (DataRow row in data.Rows)
            {
                int index = dgv_category.Rows.Add();
                dgv_category.Rows[index].Cells["sno"].Value = String.Format(" {0} ", ++sno);
                dgv_category.Rows[index].Cells["ccategory_id"].Value = row["id"].ToString();
                dgv_category.Rows[index].Cells["cname"].Value = row["name"].ToString();
            }
        }
        private void tab_category_Enter(object sender, EventArgs e)
        {
            refreshCategory(category.getCategory());
        }
        private void btnc_add_Click(object sender, EventArgs e)
        {
            using (CategoryED categoryED = new CategoryED())
            {
                if (categoryED.ShowDialog() != DialogResult.OK)
                {
                    refreshCategory(category.getCategory());
                }
            }
        }
        private void txtc_search_TextChanged(object sender, EventArgs e)
        {
            string name = txtc_search.Text.ToString();
            if (name.Length > 0)
            {
                Category category = new Category();
                DataTable data = category.searchCategory(name);
                if (data.Rows.Count > 0)
                {
                    dgv_category.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int index = dgv_category.Rows.Add();
                        dgv_category.Rows[index].Cells["ccategory_id"].Value = row["id"].ToString();
                        dgv_category.Rows[index].Cells["cname"].Value = row["name"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshCategory(category.getCategory());
                    txtc_search.Clear();
                }
            }
            else
            {
                refreshCategory(category.getCategory());
            }
        }
        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    string category_id = dgv_category.Rows[e.RowIndex].Cells["ccategory_id"].Value.ToString();
                    using (CategoryED categoryED = new CategoryED(category_id))
                    {
                        if (categoryED.ShowDialog() != DialogResult.Cancel)
                        {
                            txtc_search.Clear();
                            refreshCategory(category.getCategory());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Items
        private void tab_items_Enter(object sender, EventArgs e)
        {
            items = new Items();
            LoadItems(items.getItems());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            items = new Items();
            if (txt_search.Text.ToString().Length > 0)
            {
                DataTable data = items.searchItem(Encrption.trim(txt_search.Text.ToString()), cb_search.SelectedItem.ToString());
                if (data.Rows.Count > 0)
                {
                    btn_clear.Show();
                    LoadItems(data);
                }
                else
                {
                    MessageBox.Show("No record(s) found", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(String.Format("Please enter keyword to search by {0}", cb_search.SelectedItem.ToString()), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_search.Focus();
                LoadItems(items.getItems());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        /*
            string name = txt_searchItem.Text.ToString();
            if (name.Length > 0)
            {
                items = new Items();
                this.itemsGridViewFormatting(items.searchItem(name));
            }
            else
            {
                this.loadItems();
            } 
        */

        private void LoadItems(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                dgv_items.Rows.Clear();
                dgv_items.RowTemplate.Height = 100;
                dgv_items.Columns["image"].Width = 10;

                try
                {
                    int sno = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var index = dgv_items.Rows.Add();

                        DateTime created_at = DateTime.Parse(row["created_at"].ToString());
                        DateTime updated_at = DateTime.Parse(row["updated_at"].ToString());

                        dgv_items.Rows[index].Cells["isno"].Value = String.Format(" {0} ", ++sno);
                        dgv_items.Rows[index].Cells["name"].Value = row["name"].ToString();
                        if (this.ContainColumn("category_name", dataTable))
                        {
                            dgv_items.Rows[index].Cells["category_name"].Value = row["category_name"].ToString();
                        }
                        else
                        {
                            dgv_items.Rows[index].Cells["category_name"].Value = row["name1"].ToString();
                        }
                        dgv_items.Rows[index].Cells["description"].Value = row["description"].ToString();
                        dgv_items.Rows[index].Cells["sale_price"].Value = row["sale_price"].ToString();
                        dgv_items.Rows[index].Cells["purchase_price"].Value = row["purchase_price"].ToString();
                        dgv_items.Rows[index].Cells["discount"].Value = row["discount"].ToString();
                        dgv_items.Rows[index].Cells["apply_discount"].Value = row["apply_discount"].ToString();
                        dgv_items.Rows[index].Cells["apply_tax"].Value = row["apply_tax"].ToString();
                        dgv_items.Rows[index].Cells["is_kitchen_item"].Value = row["is_kitchen_item"].ToString();
                        dgv_items.Rows[index].Cells["created_at"].Value = created_at.ToString("ddd dd MMM , yyyy hh:mm:ss:tt");
                        dgv_items.Rows[index].Cells["updated_at"].Value = updated_at.ToString("ddd dd MMM , yyyy hh:mm:ss:tt");
                        dgv_items.Rows[index].Cells["id"].Value = row["id"].ToString();
                        dgv_items.Rows[index].Cells["category_id"].Value = row["category_id"].ToString();
                        if (!row["item_image"].ToString().Equals(""))
                        {
                            try
                            {
                                dgv_items.Rows[index].Cells["image"].Value = new Bitmap(Bitmap.FromFile(Path.Combine(this.appPath, row["item_image"].ToString())), 100, 50);

                            }
                            catch (Exception ex)
                            {
                                // Handle error here
                            }
                        }
                        else
                        {
                            dgv_items.Rows[index].Cells["image"].Value = new Bitmap(Properties.Resources.download2, 100, 50);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("System error {0}", ex.Message));
                }
                finally
                {
                    dataTable = new DataTable();
                    dataTable.Clear();
                }
                dgv_items.Columns["sale_price"].Resizable = DataGridViewTriState.False;
                dgv_items.Columns["sale_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgv_items.Columns["created_at"].Resizable = DataGridViewTriState.False;
                dgv_items.Columns["created_at"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.removeUnwantedImage();

            }
        }

        private void dgv_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    string item_id = dgv_items.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    using (ItemED item = new ItemED(item_id))
                    {
                        if (item.ShowDialog() != DialogResult.Cancel)
                        {
                            txt_search.Clear();
                            items = new Items();
                            LoadItems(items.getItems());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeUnwantedImage()
        {
            DirectoryInfo dir = new DirectoryInfo(this.appPath);
            FileInfo[] Files = dir.GetFiles();

            List<string> imageRemoveList = new List<string>();
            List<string> image = new List<string>();

            items = new Items();
            if (items.getAllItemImages().Count > 0)
            {
                foreach (string img in items.getAllItemImages())
                {
                    foreach (FileInfo file in Files)
                    {
                        if (img.Equals(file.Name))
                        {
                            if (imageRemoveList.Contains(file.Name))
                            {
                                imageRemoveList.Remove(file.Name);
                                image.Add(file.Name);
                            }
                            else
                            {
                                image.Add(file.Name);
                            }

                        }
                        else
                        {
                            if (image.Contains(file.Name))
                            {
                                if (imageRemoveList.Contains(file.Name))
                                {
                                    imageRemoveList.Remove(file.Name);
                                }
                            }
                            else
                            {
                                if (image.Contains(file.Name))
                                {
                                    continue;
                                }
                                else
                                {
                                    imageRemoveList.Add(file.Name);
                                }
                            }
                        }
                    }
                }
            }

            if (imageRemoveList.Count > 0)
            {
                foreach (string img in imageRemoveList)
                {
                    if (image.Contains(img))
                    {
                        continue;
                    }
                    else
                    {
                        string filePath = this.appPath + img;
                        if (File.Exists(filePath))
                        {
                            try
                            {
                                File.Delete(filePath);
                            }
                            catch (Exception ex)
                            {
                                // Handle error here
                            }
                        }
                    }
                }
            }

        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            using (ItemED item = new ItemED())
            {
                if (item.ShowDialog() != DialogResult.OK)
                {
                    items = new Items();
                    LoadItems(items.getItems());
                }
            }
        }

        //private void loadItems()
        //{
        //    items = new Items();
        //    this.LoadItems(items.getItems());
        //    this.removeUnwantedImage();
        //}

        private bool ContainColumn(string columnName, DataTable table)
        {
            DataColumnCollection columns = table.Columns;
            return columns.Contains(columnName);
        }



        #endregion


    }
}
