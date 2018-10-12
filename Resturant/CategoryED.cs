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

namespace Resturant
{
    public partial class CategoryED : Form
    {
        private bool is_edit;

        private string category_id;
        public CategoryED()
        {
            InitializeComponent();

            txtc_name.KeyPress += PressEnterOccure;
            this.is_edit = false;
            this.Text = "Add Category";
        }



        public CategoryED(string category_id)
        {
            InitializeComponent();

            txtc_name.KeyPress += PressEnterOccure;
            this.is_edit = true;
            btnc_add.Text = "UPDATE";
            btnc_cancel.Text = "DELETE";

            try
            {
                Category category = new Category(category_id);
                DataTable data = category.getCategoryById();
                this.category_id = data.Rows[0]["id"].ToString();
                this.Text = data.Rows[0]["name"].ToString();
                txtc_name.Text = data.Rows[0]["name"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void PressEnterOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                string category_name = Encrption.trim(txtc_name.Text.ToString());
                if (category_name.Length > 0)
                {
                    if (category_name.Length > 191)
                    {
                        MessageBox.Show("Category name is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (int.TryParse(category_name, out int result))
                        {
                            MessageBox.Show("Category name must be alphabetic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (this.is_edit.Equals(true))
                            {
                                Category category = new Category(this.category_id, category_name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                if (Convert.ToBoolean(category.updateCategory()).Equals(true))
                                {
                                    MessageBox.Show("Category has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                Category category = new Category(category_name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                if (Convert.ToBoolean(category.addCategory()).Equals(true))
                                {
                                    MessageBox.Show("Category has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnc_add_Click(object sender, EventArgs e)
        {
            string category_name = Encrption.trim(txtc_name.Text.ToString());
            if (category_name.Length > 0)
            {
                if (category_name.Length > 191)
                {
                    MessageBox.Show("Category name is too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.TryParse(category_name, out int result))
                    {
                        MessageBox.Show("Category name must be alphabetic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (this.is_edit.Equals(true))
                        {
                            Category category = new Category(this.category_id, category_name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            if (Convert.ToBoolean(category.updateCategory()).Equals(true))
                            {
                                MessageBox.Show("Category has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            Category category = new Category(category_name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            if (Convert.ToBoolean(category.addCategory()).Equals(true))
                            {
                                MessageBox.Show("Category has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter category","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnc_cancel_Click(object sender, EventArgs e)
        {
            if (this.is_edit.Equals(true))
            {
                var confirm = MessageBox.Show("Are you sure..","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(confirm == DialogResult.Yes)
                {
                    Category category = new Category(this.category_id);
                    if (Convert.ToBoolean(category.deleteCategory() ).Equals(true))
                    {
                        MessageBox.Show("Category has deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
