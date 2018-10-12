namespace Resturant
{
    partial class KitchenForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_kitchen = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_kitchen = new System.Windows.Forms.DataGridView();
            this.panelleft = new System.Windows.Forms.Panel();
            this.btn_addKitchen = new System.Windows.Forms.Button();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.main_menu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchen_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_kitchen.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitchen)).BeginInit();
            this.panelleft.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottomRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTopLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.mainPanel, 2);
            this.mainPanel.Controls.Add(this.tabControl1);
            this.mainPanel.Location = new System.Drawing.Point(3, 72);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(828, 339);
            this.mainPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_kitchen);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 341);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tab_kitchen
            // 
            this.tab_kitchen.Controls.Add(this.tableLayoutPanel2);
            this.tab_kitchen.Location = new System.Drawing.Point(4, 34);
            this.tab_kitchen.Name = "tab_kitchen";
            this.tab_kitchen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_kitchen.Size = new System.Drawing.Size(822, 303);
            this.tab_kitchen.TabIndex = 0;
            this.tab_kitchen.Text = "Kitchen";
            this.tab_kitchen.UseVisualStyleBackColor = true;
            this.tab_kitchen.Enter += new System.EventHandler(this.tab_kitchen_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_kitchen, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelleft, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 297);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgv_kitchen
            // 
            this.dgv_kitchen.AllowUserToAddRows = false;
            this.dgv_kitchen.AllowUserToDeleteRows = false;
            this.dgv_kitchen.BackgroundColor = System.Drawing.Color.White;
            this.dgv_kitchen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_kitchen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.id,
            this.kitchen_name,
            this.categories});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_kitchen, 2);
            this.dgv_kitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_kitchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_kitchen.Location = new System.Drawing.Point(3, 77);
            this.dgv_kitchen.Name = "dgv_kitchen";
            this.dgv_kitchen.ReadOnly = true;
            this.dgv_kitchen.RowHeadersVisible = false;
            this.dgv_kitchen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kitchen.Size = new System.Drawing.Size(810, 217);
            this.dgv_kitchen.TabIndex = 0;
            this.dgv_kitchen.TabStop = false;
            this.dgv_kitchen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kitchen_CellClick);
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.btn_addKitchen);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelleft.Location = new System.Drawing.Point(3, 3);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(402, 68);
            this.panelleft.TabIndex = 2;
            // 
            // btn_addKitchen
            // 
            this.btn_addKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addKitchen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addKitchen.Location = new System.Drawing.Point(0, 31);
            this.btn_addKitchen.Name = "btn_addKitchen";
            this.btn_addKitchen.Size = new System.Drawing.Size(75, 25);
            this.btn_addKitchen.TabIndex = 2;
            this.btn_addKitchen.Text = "ADD";
            this.btn_addKitchen.UseVisualStyleBackColor = true;
            this.btn_addKitchen.Click += new System.EventHandler(this.btn_addKitchen_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopRight.Controls.Add(this.lbl_userType);
            this.panelTopRight.Controls.Add(this.lbl_clock);
            this.panelTopRight.Location = new System.Drawing.Point(420, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(411, 63);
            this.panelTopRight.TabIndex = 1;
            // 
            // lbl_userType
            // 
            this.lbl_userType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.Location = new System.Drawing.Point(186, 38);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(0, 17);
            this.lbl_userType.TabIndex = 3;
            // 
            // lbl_clock
            // 
            this.lbl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.Location = new System.Drawing.Point(186, 6);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(0, 21);
            this.lbl_clock.TabIndex = 2;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottomRight.Location = new System.Drawing.Point(420, 417);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(411, 41);
            this.panelBottomRight.TabIndex = 2;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.main_menu);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(411, 63);
            this.panelTopLeft.TabIndex = 3;
            // 
            // main_menu
            // 
            this.main_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu.ForeColor = System.Drawing.Color.Blue;
            this.main_menu.Location = new System.Drawing.Point(10, 18);
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
            // sno
            // 
            this.sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sno.HeaderText = "#";
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            this.sno.Width = 41;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // kitchen_name
            // 
            this.kitchen_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kitchen_name.HeaderText = "Kitchen Name";
            this.kitchen_name.Name = "kitchen_name";
            this.kitchen_name.ReadOnly = true;
            this.kitchen_name.Width = 114;
            // 
            // categories
            // 
            this.categories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categories.HeaderText = "Categories";
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KitchenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_kitchen.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitchen)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.panelTopLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_kitchen;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Button main_menu;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_kitchen;
        private System.Windows.Forms.Button btn_addKitchen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchen_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories;
    }
}