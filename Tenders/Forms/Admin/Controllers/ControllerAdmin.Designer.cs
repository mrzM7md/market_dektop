namespace Tenders.Forms.Admin.Controllers
{
    partial class ControllerAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerAdmin));
            this.panel_add_admin_card = new System.Windows.Forms.Panel();
            this.sqlabC_Label1 = new SQLABC_ModernUI.SQLABC_Label();
            this.fLPanel_cards = new System.Windows.Forms.FlowLayoutPanel();
            this.alert_signup_admin_error = new SQLABC_ModernUI.SQLABC_AlertBox();
            this.btn_admin_add = new SQLABC_ModernUI.SQLABC_Button();
            this.tb_admin_phone = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label7 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_admin_email = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label6 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_admin_name = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label8 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_admin_confirm_password = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label5 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_admin_password = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label4 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_admin_username = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label3 = new SQLABC_ModernUI.SQLABC_Label();
            this.label_new_update = new SQLABC_ModernUI.SQLABC_Label();
            this.flowLayoutPanel_admin_signup = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_add_admin = new System.Windows.Forms.PictureBox();
            this.panel_add_admin_card.SuspendLayout();
            this.fLPanel_cards.SuspendLayout();
            this.flowLayoutPanel_admin_signup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_add_admin_card
            // 
            this.panel_add_admin_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.panel_add_admin_card.Controls.Add(this.sqlabC_Label1);
            this.panel_add_admin_card.Controls.Add(this.pb_add_admin);
            this.panel_add_admin_card.Location = new System.Drawing.Point(3, 3);
            this.panel_add_admin_card.Name = "panel_add_admin_card";
            this.panel_add_admin_card.Size = new System.Drawing.Size(180, 267);
            this.panel_add_admin_card.TabIndex = 1;
            // 
            // sqlabC_Label1
            // 
            this.sqlabC_Label1.AutoSize = true;
            this.sqlabC_Label1.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label1.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label1.Location = new System.Drawing.Point(34, 153);
            this.sqlabC_Label1.Name = "sqlabC_Label1";
            this.sqlabC_Label1.Size = new System.Drawing.Size(106, 23);
            this.sqlabC_Label1.TabIndex = 1;
            this.sqlabC_Label1.Text = "ADD ADMIN";
            // 
            // fLPanel_cards
            // 
            this.fLPanel_cards.AutoScroll = true;
            this.fLPanel_cards.Controls.Add(this.panel_add_admin_card);
            this.fLPanel_cards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanel_cards.Location = new System.Drawing.Point(0, 0);
            this.fLPanel_cards.Name = "fLPanel_cards";
            this.fLPanel_cards.Size = new System.Drawing.Size(807, 655);
            this.fLPanel_cards.TabIndex = 5;
            // 
            // alert_signup_admin_error
            // 
            this.alert_signup_admin_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alert_signup_admin_error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alert_signup_admin_error.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alert_signup_admin_error.kind = SQLABC_ModernUI.SQLABC_AlertBox._Kind.Error;
            this.alert_signup_admin_error.Location = new System.Drawing.Point(30, 537);
            this.alert_signup_admin_error.Margin = new System.Windows.Forms.Padding(15, 40, 3, 3);
            this.alert_signup_admin_error.Name = "alert_signup_admin_error";
            this.alert_signup_admin_error.Size = new System.Drawing.Size(327, 42);
            this.alert_signup_admin_error.TabIndex = 18;
            this.alert_signup_admin_error.Visible = false;
            // 
            // btn_admin_add
            // 
            this.btn_admin_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_admin_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_admin_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_admin_add.Location = new System.Drawing.Point(30, 462);
            this.btn_admin_add.Margin = new System.Windows.Forms.Padding(15, 10, 3, 3);
            this.btn_admin_add.Name = "btn_admin_add";
            this.btn_admin_add.Padding = new System.Windows.Forms.Padding(5);
            this.btn_admin_add.Rounded = false;
            this.btn_admin_add.Size = new System.Drawing.Size(182, 32);
            this.btn_admin_add.TabIndex = 17;
            this.btn_admin_add.Text = "GO";
            this.btn_admin_add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_admin_add.Click += new System.EventHandler(this.btn_admin_add_Click);
            // 
            // tb_admin_phone
            // 
            this.tb_admin_phone.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin_phone.Location = new System.Drawing.Point(30, 415);
            this.tb_admin_phone.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_admin_phone.MaxLength = 32767;
            this.tb_admin_phone.Multiline = false;
            this.tb_admin_phone.Name = "tb_admin_phone";
            this.tb_admin_phone.ReadOnly = false;
            this.tb_admin_phone.Size = new System.Drawing.Size(327, 34);
            this.tb_admin_phone.TabIndex = 13;
            this.tb_admin_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_admin_phone.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_admin_phone.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label7
            // 
            this.sqlabC_Label7.AutoSize = true;
            this.sqlabC_Label7.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label7.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label7.Location = new System.Drawing.Point(18, 384);
            this.sqlabC_Label7.Name = "sqlabC_Label7";
            this.sqlabC_Label7.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label7.Size = new System.Drawing.Size(64, 28);
            this.sqlabC_Label7.TabIndex = 12;
            this.sqlabC_Label7.Text = "Phone";
            // 
            // tb_admin_email
            // 
            this.tb_admin_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin_email.Location = new System.Drawing.Point(30, 347);
            this.tb_admin_email.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_admin_email.MaxLength = 32767;
            this.tb_admin_email.Multiline = false;
            this.tb_admin_email.Name = "tb_admin_email";
            this.tb_admin_email.ReadOnly = false;
            this.tb_admin_email.Size = new System.Drawing.Size(327, 34);
            this.tb_admin_email.TabIndex = 11;
            this.tb_admin_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_admin_email.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_admin_email.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label6
            // 
            this.sqlabC_Label6.AutoSize = true;
            this.sqlabC_Label6.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label6.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label6.Location = new System.Drawing.Point(18, 316);
            this.sqlabC_Label6.Name = "sqlabC_Label6";
            this.sqlabC_Label6.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label6.Size = new System.Drawing.Size(56, 28);
            this.sqlabC_Label6.TabIndex = 10;
            this.sqlabC_Label6.Text = "Email";
            // 
            // tb_admin_name
            // 
            this.tb_admin_name.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin_name.Location = new System.Drawing.Point(30, 279);
            this.tb_admin_name.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_admin_name.MaxLength = 32767;
            this.tb_admin_name.Multiline = false;
            this.tb_admin_name.Name = "tb_admin_name";
            this.tb_admin_name.ReadOnly = false;
            this.tb_admin_name.Size = new System.Drawing.Size(327, 34);
            this.tb_admin_name.TabIndex = 15;
            this.tb_admin_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_admin_name.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_admin_name.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label8
            // 
            this.sqlabC_Label8.AutoSize = true;
            this.sqlabC_Label8.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label8.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label8.Location = new System.Drawing.Point(18, 248);
            this.sqlabC_Label8.Name = "sqlabC_Label8";
            this.sqlabC_Label8.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label8.Size = new System.Drawing.Size(111, 28);
            this.sqlabC_Label8.TabIndex = 14;
            this.sqlabC_Label8.Text = "Room Name";
            // 
            // tb_admin_confirm_password
            // 
            this.tb_admin_confirm_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin_confirm_password.Location = new System.Drawing.Point(30, 211);
            this.tb_admin_confirm_password.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_admin_confirm_password.MaxLength = 32767;
            this.tb_admin_confirm_password.Multiline = false;
            this.tb_admin_confirm_password.Name = "tb_admin_confirm_password";
            this.tb_admin_confirm_password.ReadOnly = false;
            this.tb_admin_confirm_password.Size = new System.Drawing.Size(327, 34);
            this.tb_admin_confirm_password.TabIndex = 9;
            this.tb_admin_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_admin_confirm_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_admin_confirm_password.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label5
            // 
            this.sqlabC_Label5.AutoSize = true;
            this.sqlabC_Label5.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label5.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label5.Location = new System.Drawing.Point(18, 180);
            this.sqlabC_Label5.Name = "sqlabC_Label5";
            this.sqlabC_Label5.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label5.Size = new System.Drawing.Size(151, 28);
            this.sqlabC_Label5.TabIndex = 8;
            this.sqlabC_Label5.Text = "Confirm Password";
            // 
            // tb_admin_password
            // 
            this.tb_admin_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin_password.Location = new System.Drawing.Point(30, 143);
            this.tb_admin_password.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_admin_password.MaxLength = 32767;
            this.tb_admin_password.Multiline = false;
            this.tb_admin_password.Name = "tb_admin_password";
            this.tb_admin_password.ReadOnly = false;
            this.tb_admin_password.Size = new System.Drawing.Size(327, 34);
            this.tb_admin_password.TabIndex = 7;
            this.tb_admin_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_admin_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_admin_password.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label4
            // 
            this.sqlabC_Label4.AutoSize = true;
            this.sqlabC_Label4.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label4.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label4.Location = new System.Drawing.Point(18, 112);
            this.sqlabC_Label4.Name = "sqlabC_Label4";
            this.sqlabC_Label4.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label4.Size = new System.Drawing.Size(85, 28);
            this.sqlabC_Label4.TabIndex = 6;
            this.sqlabC_Label4.Text = "Password";
            // 
            // tb_admin_username
            // 
            this.tb_admin_username.BackColor = System.Drawing.Color.Transparent;
            this.tb_admin_username.Location = new System.Drawing.Point(30, 75);
            this.tb_admin_username.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tb_admin_username.MaxLength = 32767;
            this.tb_admin_username.Multiline = false;
            this.tb_admin_username.Name = "tb_admin_username";
            this.tb_admin_username.ReadOnly = false;
            this.tb_admin_username.Size = new System.Drawing.Size(327, 34);
            this.tb_admin_username.TabIndex = 5;
            this.tb_admin_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_admin_username.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_admin_username.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label3
            // 
            this.sqlabC_Label3.AutoSize = true;
            this.sqlabC_Label3.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label3.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label3.Location = new System.Drawing.Point(18, 44);
            this.sqlabC_Label3.Name = "sqlabC_Label3";
            this.sqlabC_Label3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlabC_Label3.Size = new System.Drawing.Size(103, 28);
            this.sqlabC_Label3.TabIndex = 4;
            this.sqlabC_Label3.Text = "USERNAME";
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
            this.label_new_update.Size = new System.Drawing.Size(263, 44);
            this.label_new_update.TabIndex = 2;
            this.label_new_update.Text = "ADD NEW ADMIN";
            // 
            // flowLayoutPanel_admin_signup
            // 
            this.flowLayoutPanel_admin_signup.CausesValidation = false;
            this.flowLayoutPanel_admin_signup.Controls.Add(this.label_new_update);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label3);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_admin_username);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label4);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_admin_password);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label5);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_admin_confirm_password);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label8);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_admin_name);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label6);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_admin_email);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.sqlabC_Label7);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.tb_admin_phone);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.btn_admin_add);
            this.flowLayoutPanel_admin_signup.Controls.Add(this.alert_signup_admin_error);
            this.flowLayoutPanel_admin_signup.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_admin_signup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_admin_signup.Location = new System.Drawing.Point(807, 0);
            this.flowLayoutPanel_admin_signup.Name = "flowLayoutPanel_admin_signup";
            this.flowLayoutPanel_admin_signup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flowLayoutPanel_admin_signup.Size = new System.Drawing.Size(390, 655);
            this.flowLayoutPanel_admin_signup.TabIndex = 4;
            // 
            // pb_add_admin
            // 
            this.pb_add_admin.BackColor = System.Drawing.Color.Transparent;
            this.pb_add_admin.Image = ((System.Drawing.Image)(resources.GetObject("pb_add_admin.Image")));
            this.pb_add_admin.Location = new System.Drawing.Point(28, 55);
            this.pb_add_admin.Name = "pb_add_admin";
            this.pb_add_admin.Size = new System.Drawing.Size(123, 95);
            this.pb_add_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_add_admin.TabIndex = 0;
            this.pb_add_admin.TabStop = false;
            this.pb_add_admin.Click += new System.EventHandler(this.pb_add_admin_Click);
            // 
            // ControllerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.fLPanel_cards);
            this.Controls.Add(this.flowLayoutPanel_admin_signup);
            this.Name = "ControllerAdmin";
            this.Size = new System.Drawing.Size(1197, 655);
            this.panel_add_admin_card.ResumeLayout(false);
            this.panel_add_admin_card.PerformLayout();
            this.fLPanel_cards.ResumeLayout(false);
            this.flowLayoutPanel_admin_signup.ResumeLayout(false);
            this.flowLayoutPanel_admin_signup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_add_admin_card;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label1;
        private System.Windows.Forms.PictureBox pb_add_admin;
        internal System.Windows.Forms.FlowLayoutPanel fLPanel_cards;
        internal SQLABC_ModernUI.SQLABC_AlertBox alert_signup_admin_error;
        internal SQLABC_ModernUI.SQLABC_Button btn_admin_add;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_admin_phone;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label7;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_admin_email;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label6;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_admin_name;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label8;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_admin_confirm_password;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label5;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_admin_password;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label4;
        internal SQLABC_ModernUI.SQLABC_TextBox tb_admin_username;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label3;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_admin_signup;
        internal SQLABC_ModernUI.SQLABC_Label label_new_update;
    }
}
