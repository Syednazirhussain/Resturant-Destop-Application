using Resturant.Model;
using System;
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
    public partial class ItemED : Form
    {
        private Items items;

        private Category category;

        private string filePath,fileExt,appPath,previousImage;

        private bool isEditItem;

        private string itemId;


        public ItemED()
        {
            InitializeComponent();

            txt_name.KeyPress += PressEnterEventOccure;
            txt_desc.KeyPress += PressEnterEventOccure;
            txt_saleprice.KeyPress += PressEnterEventOccure;
            txt_purchase.KeyPress += PressEnterEventOccure;
            txt_discount.KeyPress += PressEnterEventOccure;
            chk_ad.KeyPress += PressEnterEventOccure;
            chk_at.KeyPress += PressEnterEventOccure;
            chk_ktch.KeyPress += PressEnterEventOccure;



            category = new Category();
            cb_category.DataSource = category.getCategory();
            cb_category.ValueMember = "id";
            cb_category.DisplayMember = "name";

            this.filePath = "";
            this.previousImage = "";
            this.fileExt = "";
            this.isEditItem = false;
            btn_removeImg.Visible = false;
            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ItemsImages\";
        }
        public ItemED(string item_id)
        {
            InitializeComponent();

            txt_name.KeyPress += PressEnterEventOccure;
            txt_desc.KeyPress += PressEnterEventOccure;
            txt_saleprice.KeyPress += PressEnterEventOccure;
            txt_purchase.KeyPress += PressEnterEventOccure;
            txt_discount.KeyPress += PressEnterEventOccure;
            chk_ad.KeyPress += PressEnterEventOccure;
            chk_at.KeyPress += PressEnterEventOccure;
            chk_ktch.KeyPress += PressEnterEventOccure;

            this.itemId = item_id;
            this.filePath = "";
            this.fileExt = "";
            this.previousImage = "";
            this.isEditItem = true;
            btn_removeImg.Visible = true;
            btn_add.Text = "UPDATE";
            btn_cancel.Text = "DELETE";

            this.appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ItemsImages\";

            category = new Category();
            items = new Items(item_id);
            DataTable dataItem = items.getItemById();

            cb_category.DataSource = category.getCategory();
            cb_category.ValueMember = "id";
            cb_category.DisplayMember = "name";


            if (dataItem.Rows.Count > 0)
            {
                double sale_price = Convert.ToDouble(dataItem.Rows[0]["sale_price"].ToString());
                double purchase_price = Convert.ToDouble(dataItem.Rows[0]["purchase_price"].ToString());
                double discount = Convert.ToDouble(dataItem.Rows[0]["discount"].ToString());

                txt_name.Text = dataItem.Rows[0]["name"].ToString();
                txt_desc.Text = dataItem.Rows[0]["description"].ToString();
                txt_saleprice.Text = sale_price.ToString("0.##");
                txt_purchase.Text = purchase_price.ToString("0.##");
                txt_discount.Text = discount.ToString("0.##");
                cb_category.SelectedValue = dataItem.Rows[0]["category_id"].ToString();

                if(!dataItem.Rows[0]["item_image"].ToString().Equals(""))
                {
                    try
                    {
                        image.Image = Bitmap.FromFile(Path.Combine(this.appPath, dataItem.Rows[0]["item_image"].ToString()));
                        this.previousImage = dataItem.Rows[0]["item_image"].ToString();
                    }
                    catch(Exception ex)
                    {
                        // Handle error here
                    }

                }

                if (dataItem.Rows[0]["apply_discount"].ToString().Equals("True"))
                {
                    chk_ad.Checked = true;
                }
                else
                {
                    chk_ad.Checked = false;
                }

                if (dataItem.Rows[0]["apply_tax"].ToString().Equals("True"))
                {
                    chk_at.Checked = true;
                }
                else
                {
                    chk_at.Checked = false;
                }

                if (dataItem.Rows[0]["is_kitchen_item"].ToString().Equals("True"))
                {
                    chk_ktch.Checked = true;
                }
                else
                {
                    chk_ktch.Checked = false;
                }


            }
            if (this.previousImage.Equals(""))
            {
                btn_removeImg.Visible = false;
            }

        }

        private void PressEnterEventOccure(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Return)
            {
                if (this.validateInput())
                {
                    string name = Encrption.trim(txt_name.Text.ToString());
                    string categoryId = cb_category.SelectedValue.ToString();
                    string desc = Encrption.trim(txt_desc.Text.ToString());
                    string sale_price = Encrption.trim(txt_saleprice.Text.ToString());
                    string purchase_price = Encrption.trim(txt_purchase.Text.ToString());
                    string discount = Encrption.trim(txt_discount.Text.ToString());
                    string apply_discount = "0";

                    if (chk_ad.Checked == true)
                    {
                        apply_discount = "1";
                    }
                    string apply_tax = "0";
                    if (chk_at.Checked == true)
                    {
                        apply_tax = "1";
                    }
                    string is_kitchen = "0";
                    if (chk_ktch.Checked == true)
                    {
                        is_kitchen = "1";
                    }

                    string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (isEditItem == true)
                    {
                        try
                        {
                            string file;
                            if (this.filePath.Equals(""))
                            {
                                file = this.previousImage;
                                items = new Items(
                                   this.itemId,
                                   categoryId,
                                   name,
                                   desc,
                                   sale_price,
                                   purchase_price,
                                   discount,
                                   apply_discount,
                                   apply_tax,
                                   is_kitchen,
                                   file,
                                   created_at,
                                   updated_at
                                   );
                                int result = items.updateItem();
                                if (result > 0)
                                {
                                    MessageBox.Show("Item has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                file = Guid.NewGuid() + "_" + this.itemId + this.fileExt;
                                items = new Items(
                                   this.itemId,
                                   categoryId,
                                   name,
                                   desc,
                                   sale_price,
                                   purchase_price,
                                   discount,
                                   apply_discount,
                                   apply_tax,
                                   is_kitchen,
                                   file,
                                   created_at,
                                   updated_at
                                   );
                                int result = items.updateItem();
                                if (result > 0)
                                {
                                    MessageBox.Show("Item has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    string checkFilePath = this.appPath + file;
                                    File.Copy(this.filePath, checkFilePath, true);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        string imagePath = "";
                        items = new Items(
                            categoryId,
                            name,
                            desc,
                            sale_price,
                            purchase_price,
                            discount,
                            apply_discount,
                            apply_tax,
                            is_kitchen,
                            imagePath,
                            created_at,
                            updated_at
                            );
                        int result = items.addItem();
                        if (result > 0)
                        {
                            if (this.filePath.Equals("") && this.fileExt.Equals(""))
                            {
                                MessageBox.Show("Item has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.nullInputFied();
                                this.Close();
                            }
                            else
                            {
                                string itemId = items.getLastInsertedItemId();
                                string file = Guid.NewGuid() + "_" + itemId + this.fileExt;
                                this.appPath = this.appPath + file;
                                File.Copy(this.filePath, this.appPath);

                                items = null;
                                items = new Items(itemId, file);
                                int check = items.updateItemImage();
                                if (check > 0)
                                {
                                    MessageBox.Show("Item has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.nullInputFied();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_removeImg_Click(object sender, EventArgs e)
        {
            image.Image = new Bitmap(Properties.Resources.download2);
            this.previousImage = "";
            if(this.previousImage.Equals(""))
            {
                btn_removeImg.Visible = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(this.validateInput())
            {
                string name = Encrption.trim(txt_name.Text.ToString());
                string categoryId = cb_category.SelectedValue.ToString();
                string desc = Encrption.trim(txt_desc.Text.ToString());
                string sale_price = Encrption.trim(txt_saleprice.Text.ToString());
                string purchase_price = Encrption.trim(txt_purchase.Text.ToString());
                string discount = Encrption.trim(txt_discount.Text.ToString());
                string apply_discount = "0";

                if (chk_ad.Checked == true)
                {
                    apply_discount = "1";
                }
                string apply_tax = "0";
                if (chk_at.Checked == true)
                {
                    apply_tax = "1";
                }
                string is_kitchen = "0";
                if (chk_ktch.Checked == true)
                {
                    is_kitchen = "1";
                }

                string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (isEditItem == true)
                {
                    try
                    {
                        string file;
                        if (this.filePath.Equals(""))
                        {
                            file = this.previousImage;
                            items = new Items(this.itemId,categoryId,name,desc,sale_price,purchase_price,discount,apply_discount,apply_tax,is_kitchen,file, created_at,updated_at);
                            int result = items.updateItem();
                            if (result > 0)
                            {
                                MessageBox.Show("Item has updated successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                        else
                        {
                            file = Guid.NewGuid()+"_"+this.itemId+ this.fileExt;
                            items = new Items(this.itemId,categoryId,name, desc, sale_price, purchase_price, discount, apply_discount, apply_tax, is_kitchen, file, created_at, updated_at);
                            int result = items.updateItem();
                            if (result > 0)
                            {
                                MessageBox.Show("Item has updated successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                string checkFilePath = this.appPath + file;
                                File.Copy(this.filePath, checkFilePath, true);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    string imagePath = "";
                    items = new Items(categoryId, name, desc, sale_price, purchase_price, discount, apply_discount, apply_tax, is_kitchen, imagePath, created_at, updated_at);
                    int result = items.addItem();
                    if (result > 0)
                    {
                        if (this.filePath.Equals("") && this.fileExt.Equals(""))
                        {
                            MessageBox.Show("Item has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.nullInputFied();
                            this.Close();
                        }
                        else
                        {
                            string itemId = items.getLastInsertedItemId();
                            string file = Guid.NewGuid() + "_" + itemId + this.fileExt;
                            this.appPath = this.appPath + file;
                            File.Copy(this.filePath, this.appPath);

                            items = null;
                            items = new Items(itemId, file);
                            int check = items.updateItemImage();
                            if (check > 0)
                            {
                                MessageBox.Show("Item has created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.nullInputFied();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(isEditItem == true)
            {
                try
                {
                    var confirm = MessageBox.Show("Are you sure..","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if(confirm == DialogResult.Yes)
                    {
                        items = new Items(this.itemId);
                        int result = items.deleteItem();
                        if (result > 0)
                        {
                            MessageBox.Show("Item has been deleted successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(String.Format("Error {0}",ex.Message));
                }
                finally
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        private void nullInputFied()
        {
            txt_name.Clear();
            txt_desc.Clear();
            txt_saleprice.Clear();
            txt_purchase.Clear();
            txt_discount.Clear();
        }


        private bool validateInput()
        {
            int isError = 0;
            StringBuilder builder = new StringBuilder();

            if (txt_name.Text.ToString().Length > 0)
            {
                if (txt_name.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("Name is too long").AppendLine();
                }
                else
                {
                    if(int.TryParse(txt_name.Text.ToString(),out int result))
                    {
                        isError++;
                        builder.Append("Name must be alphabetic").AppendLine();
                    }
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter name").AppendLine();
            }

            if (txt_desc.Text.ToString().Length > 0)
            {
                if(txt_desc.Text.ToString().Length > 191)
                {
                    isError++;
                    builder.Append("Description is too long").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter description").AppendLine();
            }

            if (txt_saleprice.Text.ToString().Length > 0)
            {
                if ( double.TryParse(txt_saleprice.Text.ToString(),out double result) )
                {
                    if(result < 0)
                    {
                        builder.Append("Sale price must be positive").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Sale price must be numeric").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter sale price").AppendLine();
            }


            if (txt_purchase.Text.ToString().Length > 0)
            {
                if ( double.TryParse(txt_purchase.Text.ToString(),out double result) )
                {
                    if(result < 0)
                    {
                        isError++;
                        builder.Append("Purchase price must be positive").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Purchase price must be numeric").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter purchase price").AppendLine();
            }


            if (txt_discount.Text.ToString().Length > 0)
            {
                if ( double.TryParse(txt_discount.Text.ToString(),out double result) )
                {
                    if(result < 0)
                    {
                        isError++;
                        builder.Append("Discount price must be positive").AppendLine();
                    }
                }
                else
                {
                    isError++;
                    builder.Append("Discount price must be numeric").AppendLine();
                }
            }
            else
            {
                isError++;
                builder.Append("Please enter purchase price").AppendLine();
            }

            if (isError > 0)
            {
                MessageBox.Show(builder.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool isImageSet(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        private void btn_changeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select an Image";
            opFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
           

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (Directory.Exists(this.appPath) == false)
                    {
                        Directory.CreateDirectory(this.appPath);
                    }
                    //string iName = opFile.SafeFileName;   
                    this.filePath = opFile.FileName;
                    this.fileExt = Path.GetExtension(opFile.FileName);
                    image.Image = new Bitmap(opFile.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
            
        }

    }
}
