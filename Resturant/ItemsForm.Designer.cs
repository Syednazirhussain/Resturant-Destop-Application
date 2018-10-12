namespace Resturant
{
    partial class ItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabpanel = new System.Windows.Forms.TabControl();
            this.tab_category = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddCat = new System.Windows.Forms.Panel();
            this.btnc_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtc_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_items = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.isno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apply_discount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apply_tax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.is_kitchen_item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearchItem = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAddItem = new System.Windows.Forms.Panel();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.main_menu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabpanel.SuspendLayout();
            this.tab_category.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelAddCat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.tab_items.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.panelSearchItem.SuspendLayout();
            this.panelAddItem.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabpanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottomRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTopLeft, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabpanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabpanel, 2);
            this.tabpanel.Controls.Add(this.tab_category);
            this.tabpanel.Controls.Add(this.tab_items);
            this.tabpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpanel.ItemSize = new System.Drawing.Size(100, 30);
            this.tabpanel.Location = new System.Drawing.Point(3, 72);
            this.tabpanel.Name = "tabpanel";
            this.tabpanel.SelectedIndex = 0;
            this.tabpanel.Size = new System.Drawing.Size(827, 339);
            this.tabpanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabpanel.TabIndex = 1;
            // 
            // tab_category
            // 
            this.tab_category.Controls.Add(this.tableLayoutPanel2);
            this.tab_category.Location = new System.Drawing.Point(4, 34);
            this.tab_category.Name = "tab_category";
            this.tab_category.Padding = new System.Windows.Forms.Padding(3);
            this.tab_category.Size = new System.Drawing.Size(819, 301);
            this.tab_category.TabIndex = 1;
            this.tab_category.Text = "Category";
            this.tab_category.UseVisualStyleBackColor = true;
            this.tab_category.Enter += new System.EventHandler(this.tab_category_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelAddCat, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgv_category, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(813, 295);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // panelAddCat
            // 
            this.panelAddCat.Controls.Add(this.btnc_add);
            this.panelAddCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddCat.Location = new System.Drawing.Point(3, 3);
            this.panelAddCat.Name = "panelAddCat";
            this.panelAddCat.Size = new System.Drawing.Size(400, 67);
            this.panelAddCat.TabIndex = 9;
            // 
            // btnc_add
            // 
            this.btnc_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnc_add.AutoSize = true;
            this.btnc_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc_add.Location = new System.Drawing.Point(0, 26);
            this.btnc_add.Name = "btnc_add";
            this.btnc_add.Size = new System.Drawing.Size(75, 27);
            this.btnc_add.TabIndex = 2;
            this.btnc_add.Text = "ADD";
            this.btnc_add.UseVisualStyleBackColor = true;
            this.btnc_add.Click += new System.EventHandler(this.btnc_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtc_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(409, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 67);
            this.panel1.TabIndex = 10;
            // 
            // txtc_search
            // 
            this.txtc_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtc_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_search.Location = new System.Drawing.Point(223, 28);
            this.txtc_search.Name = "txtc_search";
            this.txtc_search.Size = new System.Drawing.Size(178, 25);
            this.txtc_search.TabIndex = 3;
            this.txtc_search.TextChanged += new System.EventHandler(this.txtc_search_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.AllowUserToDeleteRows = false;
            this.dgv_category.AllowUserToResizeColumns = false;
            this.dgv_category.AllowUserToResizeRows = false;
            this.dgv_category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.ccategory_id,
            this.cname});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_category, 2);
            this.dgv_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_category.Location = new System.Drawing.Point(3, 76);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.ReadOnly = true;
            this.dgv_category.RowHeadersVisible = false;
            this.dgv_category.Size = new System.Drawing.Size(807, 216);
            this.dgv_category.TabIndex = 11;
            this.dgv_category.TabStop = false;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            // 
            // sno
            // 
            this.sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sno.HeaderText = "#";
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            this.sno.Width = 41;
            // 
            // ccategory_id
            // 
            this.ccategory_id.HeaderText = "ID";
            this.ccategory_id.Name = "ccategory_id";
            this.ccategory_id.ReadOnly = true;
            this.ccategory_id.Visible = false;
            // 
            // cname
            // 
            this.cname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cname.HeaderText = "Category Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            // 
            // tab_items
            // 
            this.tab_items.Controls.Add(this.tableLayoutPanel3);
            this.tab_items.Location = new System.Drawing.Point(4, 34);
            this.tab_items.Name = "tab_items";
            this.tab_items.Padding = new System.Windows.Forms.Padding(3);
            this.tab_items.Size = new System.Drawing.Size(819, 301);
            this.tab_items.TabIndex = 2;
            this.tab_items.Text = "Items";
            this.tab_items.UseVisualStyleBackColor = true;
            this.tab_items.Enter += new System.EventHandler(this.tab_items_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgv_items, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelSearchItem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelAddItem, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(813, 295);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AllowUserToResizeColumns = false;
            this.dgv_items.AllowUserToResizeRows = false;
            this.dgv_items.BackgroundColor = System.Drawing.Color.White;
            this.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isno,
            this.image,
            this.id,
            this.category_id,
            this.name,
            this.category_name,
            this.description,
            this.sale_price,
            this.purchase_price,
            this.discount,
            this.apply_discount,
            this.apply_tax,
            this.is_kitchen_item,
            this.created_at,
            this.updated_at});
            this.tableLayoutPanel3.SetColumnSpan(this.dgv_items, 2);
            this.dgv_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_items.Location = new System.Drawing.Point(3, 76);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            this.dgv_items.RowHeadersVisible = false;
            this.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_items.Size = new System.Drawing.Size(807, 216);
            this.dgv_items.TabIndex = 0;
            this.dgv_items.TabStop = false;
            this.dgv_items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_items_CellClick);
            // 
            // isno
            // 
            this.isno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isno.HeaderText = "#";
            this.isno.Name = "isno";
            this.isno.ReadOnly = true;
            this.isno.Width = 41;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.image.HeaderText = "";
            this.image.Image = global::Resturant.Properties.Resources.download2;
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.Width = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // category_id
            // 
            this.category_id.HeaderText = "Category Id";
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            this.category_id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 68;
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.category_name.HeaderText = "Category";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category_name.Width = 86;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // sale_price
            // 
            this.sale_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sale_price.HeaderText = "Sale Price";
            this.sale_price.Name = "sale_price";
            this.sale_price.ReadOnly = true;
            this.sale_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sale_price.Width = 89;
            // 
            // purchase_price
            // 
            this.purchase_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.purchase_price.HeaderText = "Purchase Price";
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.ReadOnly = true;
            this.purchase_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.purchase_price.Visible = false;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.discount.Visible = false;
            // 
            // apply_discount
            // 
            this.apply_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apply_discount.HeaderText = "Apply Discount";
            this.apply_discount.Name = "apply_discount";
            this.apply_discount.ReadOnly = true;
            this.apply_discount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apply_discount.Visible = false;
            // 
            // apply_tax
            // 
            this.apply_tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apply_tax.HeaderText = "Apply Tax";
            this.apply_tax.Name = "apply_tax";
            this.apply_tax.ReadOnly = true;
            this.apply_tax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apply_tax.Visible = false;
            // 
            // is_kitchen_item
            // 
            this.is_kitchen_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.is_kitchen_item.HeaderText = "Is Kitchen Item";
            this.is_kitchen_item.Name = "is_kitchen_item";
            this.is_kitchen_item.ReadOnly = true;
            this.is_kitchen_item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.is_kitchen_item.Visible = false;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_at.HeaderText = "Date Registered";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // updated_at
            // 
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.updated_at.HeaderText = "Updated At";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.updated_at.Visible = false;
            // 
            // panelSearchItem
            // 
            this.panelSearchItem.Controls.Add(this.btn_clear);
            this.panelSearchItem.Controls.Add(this.btn_search);
            this.panelSearchItem.Controls.Add(this.cb_search);
            this.panelSearchItem.Controls.Add(this.txt_search);
            this.panelSearchItem.Controls.Add(this.label3);
            this.panelSearchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchItem.Location = new System.Drawing.Point(409, 3);
            this.panelSearchItem.Name = "panelSearchItem";
            this.panelSearchItem.Size = new System.Drawing.Size(401, 67);
            this.panelSearchItem.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackgroundImage = global::Resturant.Properties.Resources.icons8_delete_50;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(55, 27);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(32, 25);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.AutoSize = true;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(357, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 27);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "GO";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_search
            // 
            this.cb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(256, 27);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(95, 25);
            this.cb_search.TabIndex = 11;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(146, 27);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(104, 25);
            this.txt_search.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // panelAddItem
            // 
            this.panelAddItem.Controls.Add(this.btn_addItem);
            this.panelAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddItem.Location = new System.Drawing.Point(3, 3);
            this.panelAddItem.Name = "panelAddItem";
            this.panelAddItem.Size = new System.Drawing.Size(400, 67);
            this.panelAddItem.TabIndex = 2;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addItem.AutoSize = true;
            this.btn_addItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(0, 25);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(75, 27);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "ADD";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.lbl_userType);
            this.panelTopRight.Controls.Add(this.lbl_clock);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(419, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(411, 63);
            this.panelTopRight.TabIndex = 1;
            // 
            // lbl_userType
            // 
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.Location = new System.Drawing.Point(124, 37);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(0, 17);
            this.lbl_userType.TabIndex = 1;
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.Location = new System.Drawing.Point(124, 5);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(0, 21);
            this.lbl_clock.TabIndex = 0;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(419, 417);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(411, 40);
            this.panelBottomRight.TabIndex = 2;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.main_menu);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(410, 63);
            this.panelTopLeft.TabIndex = 3;
            // 
            // main_menu
            // 
            this.main_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu.ForeColor = System.Drawing.Color.Blue;
            this.main_menu.Location = new System.Drawing.Point(7, 26);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(112, 28);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "Main Menu";
            this.main_menu.UseVisualStyleBackColor = true;
            this.main_menu.Click += new System.EventHandler(this.main_menu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "Item Image";
            this.dataGridViewImageColumn1.Image = global::Resturant.Properties.Resources.download2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabpanel.ResumeLayout(false);
            this.tab_category.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelAddCat.ResumeLayout(false);
            this.panelAddCat.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.tab_items.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.panelSearchItem.ResumeLayout(false);
            this.panelSearchItem.PerformLayout();
            this.panelAddItem.ResumeLayout(false);
            this.panelAddItem.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.panelTopLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabpanel;
        private System.Windows.Forms.TabPage tab_category;
        private System.Windows.Forms.TabPage tab_items;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Button main_menu;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelAddCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtc_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnc_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelSearchItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAddItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn isno;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn apply_discount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn apply_tax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_kitchen_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Button btn_clear;
    }
}