namespace Tenders.Forms.Auth.Controllers
{
    partial class ControllerSignIn
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sqlabC_Label3 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_username = new SQLABC_ModernUI.SQLABC_TextBox();
            this.sqlabC_Label4 = new SQLABC_ModernUI.SQLABC_Label();
            this.tb_password = new SQLABC_ModernUI.SQLABC_TextBox();
            this.btn_signin = new SQLABC_ModernUI.SQLABC_ButtonA();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlabC_Label2 = new SQLABC_ModernUI.SQLABC_Label();
            this.sqlabC_Label1 = new SQLABC_ModernUI.SQLABC_Label();
            this.alert_signin_client_error = new SQLABC_ModernUI.SQLABC_AlertBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLPanel_cards
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sqlabC_Label3);
            this.flowLayoutPanel1.Controls.Add(this.tb_username);
            this.flowLayoutPanel1.Controls.Add(this.sqlabC_Label4);
            this.flowLayoutPanel1.Controls.Add(this.tb_password);
            this.flowLayoutPanel1.Controls.Add(this.btn_signin);
            this.flowLayoutPanel1.Controls.Add(this.alert_signin_client_error);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel1.Name = "fLPanel_cards";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(413, 516);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // sqlabC_Label3
            // 
            this.sqlabC_Label3.AutoSize = true;
            this.sqlabC_Label3.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label3.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label3.Location = new System.Drawing.Point(3, 15);
            this.sqlabC_Label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.sqlabC_Label3.Name = "sqlabC_Label3";
            this.sqlabC_Label3.Size = new System.Drawing.Size(87, 23);
            this.sqlabC_Label3.TabIndex = 32;
            this.sqlabC_Label3.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Transparent;
            this.tb_username.Location = new System.Drawing.Point(3, 41);
            this.tb_username.MaxLength = 32767;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = false;
            this.tb_username.Size = new System.Drawing.Size(404, 34);
            this.tb_username.TabIndex = 33;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_username.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_username.UseSystemPasswordChar = false;
            // 
            // sqlabC_Label4
            // 
            this.sqlabC_Label4.AutoSize = true;
            this.sqlabC_Label4.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label4.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label4.Location = new System.Drawing.Point(3, 93);
            this.sqlabC_Label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.sqlabC_Label4.Name = "sqlabC_Label4";
            this.sqlabC_Label4.Size = new System.Drawing.Size(80, 23);
            this.sqlabC_Label4.TabIndex = 34;
            this.sqlabC_Label4.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_password.Location = new System.Drawing.Point(3, 119);
            this.tb_password.MaxLength = 32767;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.ReadOnly = false;
            this.tb_password.Size = new System.Drawing.Size(404, 34);
            this.tb_password.TabIndex = 35;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_password.UseSystemPasswordChar = false;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btn_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signin.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btn_signin.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(95)))), ((int)(((byte)(210)))));
            this.btn_signin.Location = new System.Drawing.Point(3, 159);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(158, 40);
            this.btn_signin.TabIndex = 53;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sqlabC_Label2);
            this.panel1.Controls.Add(this.sqlabC_Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 77);
            this.panel1.TabIndex = 34;
            // 
            // sqlabC_Label2
            // 
            this.sqlabC_Label2.AutoSize = true;
            this.sqlabC_Label2.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label2.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label2.Location = new System.Drawing.Point(88, 45);
            this.sqlabC_Label2.Name = "sqlabC_Label2";
            this.sqlabC_Label2.Size = new System.Drawing.Size(237, 23);
            this.sqlabC_Label2.TabIndex = 5;
            this.sqlabC_Label2.Text = "Sign In to your exists Account";
            // 
            // sqlabC_Label1
            // 
            this.sqlabC_Label1.AutoSize = true;
            this.sqlabC_Label1.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label1.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label1.Location = new System.Drawing.Point(159, 8);
            this.sqlabC_Label1.Name = "sqlabC_Label1";
            this.sqlabC_Label1.Size = new System.Drawing.Size(72, 28);
            this.sqlabC_Label1.TabIndex = 4;
            this.sqlabC_Label1.Text = "Sign In";
            // 
            // alert_signin_client_error
            // 
            this.alert_signin_client_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alert_signin_client_error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alert_signin_client_error.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alert_signin_client_error.kind = SQLABC_ModernUI.SQLABC_AlertBox._Kind.Error;
            this.alert_signin_client_error.Location = new System.Drawing.Point(15, 242);
            this.alert_signin_client_error.Margin = new System.Windows.Forms.Padding(15, 40, 3, 3);
            this.alert_signin_client_error.Name = "alert_signin_client_error";
            this.alert_signin_client_error.Size = new System.Drawing.Size(370, 42);
            this.alert_signin_client_error.TabIndex = 57;
            this.alert_signin_client_error.Visible = false;
            // 
            // ControllerSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ControllerSignIn";
            this.Size = new System.Drawing.Size(413, 593);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label3;
        private SQLABC_ModernUI.SQLABC_TextBox tb_username;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label4;
        private SQLABC_ModernUI.SQLABC_TextBox tb_password;
        private SQLABC_ModernUI.SQLABC_ButtonA btn_signin;
        private System.Windows.Forms.Panel panel1;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label2;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label1;
        internal SQLABC_ModernUI.SQLABC_AlertBox alert_signin_client_error;
    }
}
