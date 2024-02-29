namespace Tenders.ErrorDialogs
{
    partial class Error
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
            this.sqlabC_Theme1 = new SQLABC_ModernUI.SQLABC_Theme();
            this.tb_message = new System.Windows.Forms.RichTextBox();
            this.sqlabC_Theme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlabC_Theme1
            // 
            this.sqlabC_Theme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.sqlabC_Theme1.Controls.Add(this.tb_message);
            this.sqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlabC_Theme1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sqlabC_Theme1.Location = new System.Drawing.Point(0, 0);
            this.sqlabC_Theme1.Name = "sqlabC_Theme1";
            this.sqlabC_Theme1.Size = new System.Drawing.Size(497, 211);
            this.sqlabC_Theme1.TabIndex = 0;
            this.sqlabC_Theme1.Text = "sqlabC_Theme1";
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tb_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_message.Font = new System.Drawing.Font("Segoe UI Emoji", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_message.Location = new System.Drawing.Point(21, 39);
            this.tb_message.Name = "tb_message";
            this.tb_message.ReadOnly = true;
            this.tb_message.Size = new System.Drawing.Size(454, 169);
            this.tb_message.TabIndex = 1;
            this.tb_message.Text = "Database error";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 211);
            this.Controls.Add(this.sqlabC_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Error_Load);
            this.sqlabC_Theme1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SQLABC_ModernUI.SQLABC_Theme sqlabC_Theme1;
        private System.Windows.Forms.RichTextBox tb_message;
    }
}