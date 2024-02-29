namespace Tenders.Forms.Client
{
    partial class Main
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
            this.theme_client_side = new SQLABC_ModernUI.SQLABC_Theme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fLPanel_cards = new System.Windows.Forms.FlowLayoutPanel();
            this.sqlabC_Label4 = new SQLABC_ModernUI.SQLABC_Label();
            this.sqlabC_Label3 = new SQLABC_ModernUI.SQLABC_Label();
            this.cb_categories = new SQLABC_ModernUI.SQLABC_ComboBox();
            this.theme_client_side.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // theme_client_side
            // 
            this.theme_client_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.theme_client_side.Controls.Add(this.panel1);
            this.theme_client_side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme_client_side.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.theme_client_side.Location = new System.Drawing.Point(0, 0);
            this.theme_client_side.Name = "theme_client_side";
            this.theme_client_side.Size = new System.Drawing.Size(1193, 658);
            this.theme_client_side.TabIndex = 0;
            this.theme_client_side.Text = "sqlabC_Theme1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fLPanel_cards);
            this.panel1.Controls.Add(this.sqlabC_Label4);
            this.panel1.Controls.Add(this.sqlabC_Label3);
            this.panel1.Controls.Add(this.cb_categories);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 611);
            this.panel1.TabIndex = 0;
            // 
            // fLPanel_cards
            // 
            this.fLPanel_cards.AutoScroll = true;
            this.fLPanel_cards.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLPanel_cards.Location = new System.Drawing.Point(39, 156);
            this.fLPanel_cards.Name = "fLPanel_cards";
            this.fLPanel_cards.Size = new System.Drawing.Size(1108, 446);
            this.fLPanel_cards.TabIndex = 7;
            // 
            // sqlabC_Label4
            // 
            this.sqlabC_Label4.AutoSize = true;
            this.sqlabC_Label4.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.sqlabC_Label4.Location = new System.Drawing.Point(510, 111);
            this.sqlabC_Label4.Name = "sqlabC_Label4";
            this.sqlabC_Label4.Size = new System.Drawing.Size(111, 28);
            this.sqlabC_Label4.TabIndex = 6;
            this.sqlabC_Label4.Text = "PRODUCTS";
            // 
            // sqlabC_Label3
            // 
            this.sqlabC_Label3.AutoSize = true;
            this.sqlabC_Label3.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlabC_Label3.ForeColor = System.Drawing.Color.White;
            this.sqlabC_Label3.Location = new System.Drawing.Point(529, 39);
            this.sqlabC_Label3.Name = "sqlabC_Label3";
            this.sqlabC_Label3.Size = new System.Drawing.Size(144, 28);
            this.sqlabC_Label3.TabIndex = 5;
            this.sqlabC_Label3.Text = "CategoryName";
            // 
            // cb_categories
            // 
            this.cb_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cb_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_categories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categories.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cb_categories.ForeColor = System.Drawing.Color.White;
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.cb_categories.ItemHeight = 18;
            this.cb_categories.Location = new System.Drawing.Point(459, 70);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(268, 24);
            this.cb_categories.TabIndex = 4;
            this.cb_categories.SelectedIndexChanged += new System.EventHandler(this.cb_categories_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 658);
            this.Controls.Add(this.theme_client_side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "them";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.theme_client_side.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SQLABC_ModernUI.SQLABC_Theme theme_client_side;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fLPanel_cards;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label4;
        private SQLABC_ModernUI.SQLABC_Label sqlabC_Label3;
        private SQLABC_ModernUI.SQLABC_ComboBox cb_categories;
    }
}