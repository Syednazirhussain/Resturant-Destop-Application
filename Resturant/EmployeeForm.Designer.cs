namespace Resturant
{
    partial class EmployeeForm
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
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_employees = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.btn_addEmployees = new System.Windows.Forms.Button();
            this.panel_addBtn = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.main_menu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.father_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnic_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_role_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_employees.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.panel_addBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottomRight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
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
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.lbl_userType);
            this.panelTopRight.Controls.Add(this.lbl_clock);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(421, 3);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(410, 63);
            this.panelTopRight.TabIndex = 5;
            // 
            // lbl_userType
            // 
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.Location = new System.Drawing.Point(108, 40);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(0, 17);
            this.lbl_userType.TabIndex = 1;
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.Location = new System.Drawing.Point(108, 8);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(0, 21);
            this.lbl_clock.TabIndex = 0;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(421, 417);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(410, 41);
            this.panelBottomRight.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tab_employees);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(3, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 339);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tab_employees
            // 
            this.tab_employees.Controls.Add(this.tableLayoutPanel2);
            this.tab_employees.Location = new System.Drawing.Point(4, 34);
            this.tab_employees.Name = "tab_employees";
            this.tab_employees.Padding = new System.Windows.Forms.Padding(3);
            this.tab_employees.Size = new System.Drawing.Size(820, 301);
            this.tab_employees.TabIndex = 0;
            this.tab_employees.Text = "Employees";
            this.tab_employees.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel_search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_addBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgv_employee, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 295);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.btn_addEmployees);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search.Location = new System.Drawing.Point(3, 3);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(401, 67);
            this.panel_search.TabIndex = 4;
            // 
            // btn_addEmployees
            // 
            this.btn_addEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addEmployees.AutoSize = true;
            this.btn_addEmployees.Location = new System.Drawing.Point(0, 28);
            this.btn_addEmployees.Name = "btn_addEmployees";
            this.btn_addEmployees.Size = new System.Drawing.Size(75, 27);
            this.btn_addEmployees.TabIndex = 2;
            this.btn_addEmployees.Text = "ADD";
            this.btn_addEmployees.UseVisualStyleBackColor = true;
            this.btn_addEmployees.Click += new System.EventHandler(this.btn_addEmployees_Click);
            // 
            // panel_addBtn
            // 
            this.panel_addBtn.Controls.Add(this.btn_clear);
            this.panel_addBtn.Controls.Add(this.btn_search);
            this.panel_addBtn.Controls.Add(this.cb_search);
            this.panel_addBtn.Controls.Add(this.txt_search);
            this.panel_addBtn.Controls.Add(this.label1);
            this.panel_addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_addBtn.Location = new System.Drawing.Point(410, 3);
            this.panel_addBtn.Name = "panel_addBtn";
            this.panel_addBtn.Size = new System.Drawing.Size(401, 67);
            this.panel_addBtn.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackgroundImage = global::Resturant.Properties.Resources.icons8_delete_50;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(48, 30);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(32, 25);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(362, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(39, 27);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "GO";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_search
            // 
            this.cb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(267, 30);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(89, 25);
            this.cb_search.TabIndex = 4;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(140, 30);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 25);
            this.txt_search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.AllowUserToResizeColumns = false;
            this.dgv_employee.AllowUserToResizeRows = false;
            this.dgv_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_employee.BackgroundColor = System.Drawing.Color.White;
            this.dgv_employee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.profile_image,
            this.id,
            this.name,
            this.father_name,
            this.address,
            this.email,
            this.mobile_no,
            this.cnic_no,
            this.user_role_code,
            this.user_status_id,
            this.userRoleName,
            this.UserStatusName,
            this.created_at,
            this.updated_at});
            this.tableLayoutPanel2.SetColumnSpan(this.dgv_employee, 2);
            this.dgv_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_employee.Location = new System.Drawing.Point(3, 76);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.RowHeadersVisible = false;
            this.dgv_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee.Size = new System.Drawing.Size(808, 216);
            this.dgv_employee.TabIndex = 4;
            this.dgv_employee.TabStop = false;
            this.dgv_employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employee_CellClick);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.main_menu);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(411, 63);
            this.panelTopLeft.TabIndex = 6;
            // 
            // main_menu
            // 
            this.main_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.main_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_menu.ForeColor = System.Drawing.Color.Blue;
            this.main_menu.Location = new System.Drawing.Point(7, 18);
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
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Resturant.Properties.Resources.download2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // sno
            // 
            this.sno.HeaderText = "#";
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            this.sno.Width = 41;
            // 
            // profile_image
            // 
            this.profile_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profile_image.HeaderText = "";
            this.profile_image.Image = global::Resturant.Properties.Resources.default_avatar;
            this.profile_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.profile_image.Name = "profile_image";
            this.profile_image.ReadOnly = true;
            this.profile_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.profile_image.Width = 5;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            this.id.Width = 45;
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
            // father_name
            // 
            this.father_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.father_name.HeaderText = "Father Name";
            this.father_name.Name = "father_name";
            this.father_name.ReadOnly = true;
            this.father_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.father_name.Width = 108;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.Width = 81;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email.Width = 64;
            // 
            // mobile_no
            // 
            this.mobile_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mobile_no.HeaderText = "Mobile";
            this.mobile_no.Name = "mobile_no";
            this.mobile_no.ReadOnly = true;
            this.mobile_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mobile_no.Width = 74;
            // 
            // cnic_no
            // 
            this.cnic_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnic_no.HeaderText = "NIC";
            this.cnic_no.Name = "cnic_no";
            this.cnic_no.ReadOnly = true;
            this.cnic_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cnic_no.Width = 54;
            // 
            // user_role_code
            // 
            this.user_role_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.user_role_code.HeaderText = "UserRoleID";
            this.user_role_code.Name = "user_role_code";
            this.user_role_code.ReadOnly = true;
            this.user_role_code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_role_code.Visible = false;
            this.user_role_code.Width = 98;
            // 
            // user_status_id
            // 
            this.user_status_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.user_status_id.HeaderText = "StatusID";
            this.user_status_id.Name = "user_status_id";
            this.user_status_id.ReadOnly = true;
            this.user_status_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_status_id.Visible = false;
            this.user_status_id.Width = 80;
            // 
            // userRoleName
            // 
            this.userRoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userRoleName.HeaderText = "Role";
            this.userRoleName.Name = "userRoleName";
            this.userRoleName.ReadOnly = true;
            this.userRoleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userRoleName.Width = 59;
            // 
            // UserStatusName
            // 
            this.UserStatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UserStatusName.HeaderText = "Status";
            this.UserStatusName.Name = "UserStatusName";
            this.UserStatusName.ReadOnly = true;
            this.UserStatusName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserStatusName.Width = 68;
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
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.updated_at.HeaderText = "Last Updated";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updated_at.Visible = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_employees.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel_addBtn.ResumeLayout(false);
            this.panel_addBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.panelTopLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_employees;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Button main_menu;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.Panel panel_addBtn;
        private System.Windows.Forms.Button btn_addEmployees;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewImageColumn profile_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn father_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnic_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_role_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
    }
}