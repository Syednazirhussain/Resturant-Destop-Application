namespace Resturant
{
    partial class OrderPaymentForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.listboxPM = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cashBack = new System.Windows.Forms.Label();
            this.lbl_amtRecieved = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.listViewDesc = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_addByCash = new System.Windows.Forms.Panel();
            this.chk_card = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel_addByCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panel_nav, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCenter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_addByCash, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_nav
            // 
            this.panel_nav.Controls.Add(this.pictureBox);
            this.panel_nav.Controls.Add(this.btn_print);
            this.panel_nav.Controls.Add(this.listboxPM);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_nav.Location = new System.Drawing.Point(3, 123);
            this.panel_nav.Name = "panel_nav";
            this.tableLayoutPanel1.SetRowSpan(this.panel_nav, 2);
            this.panel_nav.Size = new System.Drawing.Size(234, 274);
            this.panel_nav.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 200);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(227, 33);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(4, 232);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(227, 39);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // listboxPM
            // 
            this.listboxPM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPM.FormattingEnabled = true;
            this.listboxPM.ItemHeight = 21;
            this.listboxPM.Location = new System.Drawing.Point(4, 4);
            this.listboxPM.Name = "listboxPM";
            this.listboxPM.Size = new System.Drawing.Size(227, 193);
            this.listboxPM.TabIndex = 0;
            this.listboxPM.SelectedIndexChanged += new System.EventHandler(this.listboxPM_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.lbl_cashBack);
            this.panel2.Controls.Add(this.lbl_amtRecieved);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 114);
            this.panel2.TabIndex = 2;
            // 
            // lbl_cashBack
            // 
            this.lbl_cashBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cashBack.AutoSize = true;
            this.lbl_cashBack.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_cashBack.Location = new System.Drawing.Point(567, 39);
            this.lbl_cashBack.Name = "lbl_cashBack";
            this.lbl_cashBack.Size = new System.Drawing.Size(28, 37);
            this.lbl_cashBack.TabIndex = 2;
            this.lbl_cashBack.Text = "*";
            // 
            // lbl_amtRecieved
            // 
            this.lbl_amtRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_amtRecieved.AutoSize = true;
            this.lbl_amtRecieved.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amtRecieved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_amtRecieved.Location = new System.Drawing.Point(275, 39);
            this.lbl_amtRecieved.Name = "lbl_amtRecieved";
            this.lbl_amtRecieved.Size = new System.Drawing.Size(28, 37);
            this.lbl_amtRecieved.TabIndex = 1;
            this.lbl_amtRecieved.Text = "*";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_total.Location = new System.Drawing.Point(25, 39);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(28, 37);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "*";
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.listViewDesc);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(243, 123);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(554, 194);
            this.panelCenter.TabIndex = 3;
            // 
            // listViewDesc
            // 
            this.listViewDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDesc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.info});
            this.listViewDesc.Location = new System.Drawing.Point(2, 0);
            this.listViewDesc.Name = "listViewDesc";
            this.listViewDesc.Size = new System.Drawing.Size(552, 194);
            this.listViewDesc.TabIndex = 0;
            this.listViewDesc.UseCompatibleStateImageBehavior = false;
            this.listViewDesc.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 105;
            // 
            // info
            // 
            this.info.Text = "Information";
            this.info.Width = 456;
            // 
            // panel_addByCash
            // 
            this.panel_addByCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_addByCash.Controls.Add(this.chk_card);
            this.panel_addByCash.Controls.Add(this.btn_add);
            this.panel_addByCash.Controls.Add(this.txt_amt);
            this.panel_addByCash.Controls.Add(this.label1);
            this.panel_addByCash.Location = new System.Drawing.Point(243, 323);
            this.panel_addByCash.Name = "panel_addByCash";
            this.panel_addByCash.Size = new System.Drawing.Size(554, 74);
            this.panel_addByCash.TabIndex = 1;
            // 
            // chk_card
            // 
            this.chk_card.AutoSize = true;
            this.chk_card.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_card.Location = new System.Drawing.Point(18, 22);
            this.chk_card.Name = "chk_card";
            this.chk_card.Size = new System.Drawing.Size(132, 21);
            this.chk_card.TabIndex = 3;
            this.chk_card.Text = "Payment Recieved";
            this.chk_card.UseVisualStyleBackColor = true;
            this.chk_card.CheckedChanged += new System.EventHandler(this.chk_card_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.CausesValidation = false;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(286, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 25);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_amt
            // 
            this.txt_amt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amt.Location = new System.Drawing.Point(130, 22);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(139, 25);
            this.txt_amt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount Received";
            // 
            // OrderPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.OrderPaymentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.panel_addByCash.ResumeLayout(false);
            this.panel_addByCash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.ListBox listboxPM;
        private System.Windows.Forms.Panel panel_addByCash;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cashBack;
        private System.Windows.Forms.Label lbl_amtRecieved;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ListView listViewDesc;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader info;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.CheckBox chk_card;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}