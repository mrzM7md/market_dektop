namespace Tenders.Forms.Admin.Controllers
{
    partial class ControlletFirms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fLPanel_firms = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_edit_firm = new SQLABC_ModernUI.SQLABC_Label();
            this.label_delete_firm = new SQLABC_ModernUI.SQLABC_Label();
            this.dataGrideV_firms = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel_admin_signup = new System.Windows.Forms.FlowLayoutPanel();
            this.label_new_update = new SQLABC_ModernUI.SQLABC_Label();
            this.alert_signup_admin_error = new SQLABC_ModernUI.SQLABC_AlertBox();
            this.sqlabC_Label3 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_username = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label4 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_password = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label5 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_confirm_password = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label8 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_name = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label2 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_location = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label6 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_email = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label7 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_firm_phone = new SQLABC_ModernUI.SQLABC_TextBox();
            this.btn_firm_add = new SQLABC_ModernUI.SQLABC_Button();
            this.bunifuElipse_tb_search_firms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_dataGrideV_firms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tb_search_firms = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label1 = new SQLABC_ModernUI.SQLABC_Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_add_new_firm = new SQLABC_ModernUI.SQLABC_Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fLPanel_firms.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideV_firms)).BeginInit();
            this.flowLayoutPanel_admin_signup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLPanel_firms
            // 
            this.fLPanel_firms.AutoScroll = true;
            this.fLPanel_firms.Controls.Add(this.panel1);
            this.fLPanel_firms.Controls.Add(this.panel2);
            this.fLPanel_firms.Controls.Add(this.dataGrideV_firms);
            this.fLPanel_firms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanel_firms.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPanel_firms.Location = new System.Drawing.Point(0, 0);
            this.fLPanel_firms.Name = "fLPanel_firms";
            this.fLPanel_firms.Size = new System.Drawing.Size(813, 655);
            this.fLPanel_firms.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_edit_firm);
            this.panel2.Controls.Add(this.label_delete_firm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 47);
            this.panel2.TabIndex = 3;
            // 
            // label_edit_firm
            // 
            this.label_edit_firm.AutoSize = true;
            this.label_edit_firm.BackColor = System.Drawing.Color.Transparent;
            this.label_edit_firm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_edit_firm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_edit_firm.ForeColor = System.Drawing.SystemColors.Window;
            this.label_edit_firm.Location = new System.Drawing.Point(735, 12);
            this.label_edit_firm.Name = "label_edit_firm";
            this.label_edit_firm.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_edit_firm.Size = new System.Drawing.Size(50, 28);
            this.label_edit_firm.TabIndex = 9;
            this.label_edit_firm.Text = "EDIT";
            this.label_edit_firm.Click += new System.EventHandler(this.label_edit_firm_Click);
            // 
            // label_delete_firm
            // 
            this.label_delete_firm.AutoSize = true;
            this.label_delete_firm.BackColor = System.Drawing.Color.Transparent;
            this.label_delete_firm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_delete_firm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delete_firm.ForeColor = System.Drawing.Color.Crimson;
            this.label_delete_firm.Location = new System.Drawing.Point(12, 12);
            this.label_delete_firm.Name = "label_delete_firm";
            this.label_delete_firm.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_delete_firm.Size = new System.Drawing.Size(71, 28);
            this.label_delete_firm.TabIndex = 8;
            this.label_delete_firm.Text = "DELETE";
            this.label_delete_firm.Click += new System.EventHandler(this.label_delete_firm_Click);
            // 
            // dataGrideV_firms
            // 
            this.dataGrideV_firms.AllowUserToAddRows = false;
            this.dataGrideV_firms.AllowUserToDeleteRows = false;
            this.dataGrideV_firms.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "- -";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrideV_firms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrideV_firms.BackgroundColor = System.Drawing.Color.Black;
            this.dataGrideV_firms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "- -";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGrideV_firms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrideV_firms.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrideV_firms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrideV_firms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrideV_firms.GridColor = System.Drawing.SystemColors.InfoText;
            this.dataGrideV_firms.Location = new System.Drawing.Point(3, 168);
            this.dataGrideV_firms.Name = "dataGrideV_firms";
            this.dataGrideV_firms.ReadOnly = true;
            this.dataGrideV_firms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "--";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrideV_firms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrideV_firms.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.NullValue = "- -";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrideV_firms.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrideV_firms.RowTemplate.Height = 26;
            this.dataGrideV_firms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrideV_firms.ShowCellErrors = false;
            this.dataGrideV_firms.ShowCellToolTips = false;
            this.dataGrideV_firms.Size = new System.Drawing.Size(800, 472);
            this.dataGrideV_firms.TabIndex = 5;
            // 
            // flowLayoutPanel_admin_signup
            // 
            this.flowLayoutPanel_admin_signup.AutoScroll = true;
            this.flowLayoutPanel_admin_signup.CausesValidation = false;
            this.flowLayoutPanel_admin_signup.Controls.Add(this.label_new_update);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.alert_signup_admin_error);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label3);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_username);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label4);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_password);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label5);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_confirm_password);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label8);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_name);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label2);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_location);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label6);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_email);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label7);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_firm_phone);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.btn_firm_add);
            this.flowLayoutPanel_admin_signup.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_admin_signup.Location = new System.Drawing.Point(813, 0);
            this.flowLayoutPanel_admin_signup.Name = "flowLayoutPanel_admin_signup";
            this.flowLayoutPanel_admin_signup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flowLayoutPanel_admin_signup.Size = new System.Drawing.Size(384, 655);
            this.flowLayoutPanel_admin_signup.TabIndex = 6;
            // 
            // label_new_update
            // 
            this.label_new_update.AutoSize = true;
            this.label_new_update.BackColor = System.Drawing.Color.Transparent;
            this.label_new_update.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_new_update.ForeColor = System.Drawing.Color.White;
            this.label_new_update.Location = new System.Drawing.Point(18, 0);
            this.label_new_update.Name = "label_new_update";
            this.label_new_update.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label_new_update.Size = new System.Drawing.Size(234, 44);
            this.label_new_update.TabIndex = 2;
            this.label_new_update.Text = "ADD NEW FIRM";
            // 
            // alert_signup_admin_error
            // 
            this.alert_signup_admin_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alert_signup_admin_error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alert_signup_admin_error.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alert_signup_admin_error.kind = SQLABC_ModernUI.SQLABC_AlertBox._Kind.Error;
            this.alert_signup_admin_error.Location = new System.Drawing.Point(30, 54);
            this.alert_signup_admin_error.Margin = new System.Windows.Forms.Padding(15, 10, 3, 3);
            this.alert_signup_admin_error.Name = "alert_signup_admin_error";
            this.alert_signup_admin_error.Size = new System.Drawing.Size(327, 42);
            this.alert_signup_admin_error.TabIndex = 18;
            this.alert_signup_admin_error.Visible = false;
            // 
            // sqlabC_Label3
            // 
            this.sqlabC_Label3.AutoSize = true;
            this.sqlabC_Label3.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label3.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label3.Location = new System.Drawing.Point(18, 99);
            this.sqlabC_Label3.Name = "sqlabC_Label3";
            this.sqlabC_Label3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label3.Size = new System.Drawing.Size(146, 28);
            this.sqlabC_Label3.TabIndex = 4;
            this.sqlabC_Label3.Text = "FIRM USERNAME";
            // 
            // tb_firm_username
            // 
            this.tb_firm_username.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_username.Location = new System.Drawing.Point(30, 130);
            this.tb_firm_username.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_username.MaxLength = 32767;
            this.tb_firm_username.Multiline = false;
            this.tb_firm_username.Name = "tb_firm_username";
            this.tb_firm_username.ReadOnly = false;
            this.tb_firm_username.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_username.TabIndex = 5;
            this.tb_firm_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_username.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_username.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label4
            // 
            this.sqlabC_Label4.AutoSize = true;
            this.sqlabC_Label4.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label4.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label4.Location = new System.Drawing.Point(18, 167);
            this.sqlabC_Label4.Name = "sqlabC_Label4";
            this.sqlabC_Label4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label4.Size = new System.Drawing.Size(147, 28);
            this.sqlabC_Label4.TabIndex = 6;
            this.sqlabC_Label4.Text = "FIRM PASSOWRD";
            // 
            // tb_firm_password
            // 
            this.tb_firm_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_password.Location = new System.Drawing.Point(30, 198);
            this.tb_firm_password.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_password.MaxLength = 32767;
            this.tb_firm_password.Multiline = false;
            this.tb_firm_password.Name = "tb_firm_password";
            this.tb_firm_password.ReadOnly = false;
            this.tb_firm_password.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_password.TabIndex = 7;
            this.tb_firm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_password.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label5
            // 
            this.sqlabC_Label5.AutoSize = true;
            this.sqlabC_Label5.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label5.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label5.Location = new System.Drawing.Point(18, 235);
            this.sqlabC_Label5.Name = "sqlabC_Label5";
            this.sqlabC_Label5.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label5.Size = new System.Drawing.Size(184, 28);
            this.sqlabC_Label5.TabIndex = 8;
            this.sqlabC_Label5.Text = "CONFIRM PASSWORD";
            // 
            // tb_firm_confirm_password
            // 
            this.tb_firm_confirm_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_confirm_password.Location = new System.Drawing.Point(30, 266);
            this.tb_firm_confirm_password.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_confirm_password.MaxLength = 32767;
            this.tb_firm_confirm_password.Multiline = false;
            this.tb_firm_confirm_password.Name = "tb_firm_confirm_password";
            this.tb_firm_confirm_password.ReadOnly = false;
            this.tb_firm_confirm_password.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_confirm_password.TabIndex = 9;
            this.tb_firm_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_confirm_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_confirm_password.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label8
            // 
            this.sqlabC_Label8.AutoSize = true;
            this.sqlabC_Label8.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label8.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label8.Location = new System.Drawing.Point(18, 303);
            this.sqlabC_Label8.Name = "sqlabC_Label8";
            this.sqlabC_Label8.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label8.Size = new System.Drawing.Size(106, 28);
            this.sqlabC_Label8.TabIndex = 14;
            this.sqlabC_Label8.Text = "FIRM NAME";
            // 
            // tb_firm_name
            // 
            this.tb_firm_name.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_name.Location = new System.Drawing.Point(30, 334);
            this.tb_firm_name.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_name.MaxLength = 32767;
            this.tb_firm_name.Multiline = false;
            this.tb_firm_name.Name = "tb_firm_name";
            this.tb_firm_name.ReadOnly = false;
            this.tb_firm_name.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_name.TabIndex = 15;
            this.tb_firm_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_name.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_name.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label2
            // 
            this.sqlabC_Label2.AutoSize = true;
            this.sqlabC_Label2.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label2.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label2.Location = new System.Drawing.Point(18, 371);
            this.sqlabC_Label2.Name = "sqlabC_Label2";
            this.sqlabC_Label2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label2.Size = new System.Drawing.Size(130, 28);
            this.sqlabC_Label2.TabIndex = 19;
            this.sqlabC_Label2.Text = "FIRM ADDRESS";
            // 
            // tb_firm_location
            // 
            this.tb_firm_location.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_location.Location = new System.Drawing.Point(30, 402);
            this.tb_firm_location.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_location.MaxLength = 32767;
            this.tb_firm_location.Multiline = false;
            this.tb_firm_location.Name = "tb_firm_location";
            this.tb_firm_location.ReadOnly = false;
            this.tb_firm_location.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_location.TabIndex = 20;
            this.tb_firm_location.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_location.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_location.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label6
            // 
            this.sqlabC_Label6.AutoSize = true;
            this.sqlabC_Label6.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label6.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label6.Location = new System.Drawing.Point(18, 439);
            this.sqlabC_Label6.Name = "sqlabC_Label6";
            this.sqlabC_Label6.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label6.Size = new System.Drawing.Size(106, 28);
            this.sqlabC_Label6.TabIndex = 10;
            this.sqlabC_Label6.Text = "FIRM EMAIL";
            // 
            // tb_firm_email
            // 
            this.tb_firm_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_email.Location = new System.Drawing.Point(30, 470);
            this.tb_firm_email.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_email.MaxLength = 32767;
            this.tb_firm_email.Multiline = false;
            this.tb_firm_email.Name = "tb_firm_email";
            this.tb_firm_email.ReadOnly = false;
            this.tb_firm_email.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_email.TabIndex = 11;
            this.tb_firm_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_email.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_email.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label7
            // 
            this.sqlabC_Label7.AutoSize = true;
            this.sqlabC_Label7.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label7.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label7.Location = new System.Drawing.Point(18, 507);
            this.sqlabC_Label7.Name = "sqlabC_Label7";
            this.sqlabC_Label7.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label7.Size = new System.Drawing.Size(114, 28);
            this.sqlabC_Label7.TabIndex = 12;
            this.sqlabC_Label7.Text = "FIEM PHONE";
            // 
            // tb_firm_phone
            // 
            this.tb_firm_phone.BackColor = System.Drawing.Color.Transparent;
            this.tb_firm_phone.Location = new System.Drawing.Point(30, 538);
            this.tb_firm_phone.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_firm_phone.MaxLength = 32767;
            this.tb_firm_phone.Multiline = false;
            this.tb_firm_phone.Name = "tb_firm_phone";
            this.tb_firm_phone.ReadOnly = false;
            this.tb_firm_phone.Size = new System.Drawing.Size(327, 34);
            this.tb_firm_phone.TabIndex = 13;
            this.tb_firm_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firm_phone.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_firm_phone.UseSystemPasswordChar = false;
            // 
            // btn_firm_add
            // 
            this.btn_firm_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_firm_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_firm_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_firm_add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_firm_add.Location = new System.Drawing.Point(30, 585);
            this.btn_firm_add.Margin = new System.Windows.Forms.Padding(15, 10, 3, 3);
            this.btn_firm_add.Name = "btn_firm_add";
            this.btn_firm_add.Padding = new System.Windows.Forms.Padding(5);
            this.btn_firm_add.Rounded = false;
            this.btn_firm_add.Size = new System.Drawing.Size(182, 34);
            this.btn_firm_add.TabIndex = 17;
            this.btn_firm_add.Text = "GO";
            this.btn_firm_add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_firm_add.Click += new System.EventHandler(this.btn_firm_add_Click);
            // 
            // bunifuElipse_tb_search_firms
            // 
            this.bunifuElipse_tb_search_firms.ElipseRadius = 10;
            this.bunifuElipse_tb_search_firms.TargetControl = this.tb_search_firms;
            // 
            // bunifuElipse_dataGrideV_firms
            // 
            this.bunifuElipse_dataGrideV_firms.ElipseRadius = 15;
            this.bunifuElipse_dataGrideV_firms.TargetControl = this.dataGrideV_firms;
            // 
            // tb_search_firms
            // 
            this.tb_search_firms.BackColor = System.Drawing.Color.Transparent;
            this.tb_search_firms.Location = new System.Drawing.Point(253, 62);
            this.tb_search_firms.MaxLength = 32767;
            this.tb_search_firms.Multiline = false;
            this.tb_search_firms.Name = "tb_search_firms";
            this.tb_search_firms.ReadOnly = false;
            this.tb_search_firms.Size = new System.Drawing.Size(351, 34);
            this.tb_search_firms.TabIndex = 0;
            this.tb_search_firms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_search_firms.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_search_firms.UseSystemPasswordChar = false;
            this.tb_search_firms.TextChanged += new System.EventHandler(this.tb_search_firms_TextChanged);
            // 
            // sqlabC_Label1
            // 
            this.sqlabC_Label1.AutoSize = true;
            this.sqlabC_Label1.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label1.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label1.Location = new System.Drawing.Point(347, 23);
            this.sqlabC_Label1.Name = "sqlabC_Label1";
            this.sqlabC_Label1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label1.Size = new System.Drawing.Size(189, 28);
            this.sqlabC_Label1.TabIndex = 5;
            this.sqlabC_Label1.Text = "SEARCH BY ANYTHING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tenders.Properties.Resources.ic_search;
            this.pictureBox1.Location = new System.Drawing.Point(309, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_add_new_firm
            // 
            this.label_add_new_firm.AutoSize = true;
            this.label_add_new_firm.BackColor = System.Drawing.Color.Transparent;
            this.label_add_new_firm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_add_new_firm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_new_firm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_add_new_firm.Location = new System.Drawing.Point(12, 23);
            this.label_add_new_firm.Name = "label_add_new_firm";
            this.label_add_new_firm.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label_add_new_firm.Size = new System.Drawing.Size(96, 28);
            this.label_add_new_firm.TabIndex = 7;
            this.label_add_new_firm.Text = "NEW FIRM";
            this.label_add_new_firm.Click += new System.EventHandler(this.label_add_new_firm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_add_new_firm);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sqlabC_Label1);
            this.panel1.Controls.Add(this.tb_search_firms);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 106);
            this.panel1.TabIndex = 0;
            // 
            // ControlletFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.fLPanel_firms);
            this.Controls.Add(this.flowLayoutPanel_admin_signup);
            this.Name = "ControlletFirms";
            this.Size = new System.Drawing.Size(1197, 655);
            this.fLPanel_firms.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideV_firms)).EndInit();
            this.flowLayoutPanel_admin_signup.ResumeLayout(false);
            this.flowLayoutPanel_admin_signup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel fLPanel_firms;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_admin_signup;
        internal SQLABC_ModernUI.SQLABC_Label label_new_update;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label3;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_username;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label4;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_password;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label5;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_confirm_password;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label8;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_name;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label6;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_email;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label7;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_phone;
        internal SQLABC_ModernUI.SQLABC_Button btn_firm_add;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label2;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_firm_location;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_tb_search_firms;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_dataGrideV_firms;
        private System.Windows.Forms.Panel panel2;
        private SQLABC_ModernUI.SQLABC_Label label_edit_firm;
        private SQLABC_ModernUI.SQLABC_Label label_delete_firm;
        private System.Windows.Forms.DataGridView dataGrideV_firms;
        internal SQLABC_ModernUI.SQLABC_AlertBox alert_signup_admin_error;
        private System.Windows.Forms.Panel panel1;
        private SQLABC_ModernUI.SQLABC_Label label_add_new_firm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label1;
        private SQLABC_ModernUI.SQLABC_TextBox tb_search_firms;
    }
}
