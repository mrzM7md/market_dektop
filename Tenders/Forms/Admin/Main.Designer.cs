namespace Tenders.Forms.Admin
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
            this.sqlabC_Theme1 = new SQLABC_ModernUI.SQLABC_Theme();
            this.tabControl = new SQLABC_ModernUI.SQLABC_TabControlA();
            this.tab_admins = new System.Windows.Forms.TabPage();
            this.tab_firms = new System.Windows.Forms.TabPage();
            this.tab_categories = new System.Windows.Forms.TabPage();
            this.sqlabC_Theme1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlabC_Theme1
            // 
            this.sqlabC_Theme1.BackColor = System.Drawing.SystemColors.ControlText;
            this.sqlabC_Theme1.Controls.Add(this.tabControl);
            this.sqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlabC_Theme1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sqlabC_Theme1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqlabC_Theme1.Location = new System.Drawing.Point(0, 0);
            this.sqlabC_Theme1.Name = "sqlabC_Theme1";
            this.sqlabC_Theme1.Size = new System.Drawing.Size(1405, 752);
            this.sqlabC_Theme1.TabIndex = 0;
            this.sqlabC_Theme1.Text = "ADMINS";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_admins);
            this.tabControl.Controls.Add(this.tab_firms);
            this.tabControl.Controls.Add(this.tab_categories);
            this.tabControl.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControl.ItemSize = new System.Drawing.Size(0, 34);
            this.tabControl.Location = new System.Drawing.Point(14, 43);
            this.tabControl.Margin = new System.Windows.Forms.Padding(34, 30, 34, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(24, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1377, 697);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tab_admins
            // 
            this.tab_admins.BackColor = System.Drawing.SystemColors.ControlText;
            this.tab_admins.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_admins.Location = new System.Drawing.Point(4, 38);
            this.tab_admins.Name = "tab_admins";
            this.tab_admins.Padding = new System.Windows.Forms.Padding(3);
            this.tab_admins.Size = new System.Drawing.Size(1369, 655);
            this.tab_admins.TabIndex = 0;
            this.tab_admins.Text = "ADMINS";
            // 
            // tab_firms
            // 
            this.tab_firms.BackColor = System.Drawing.SystemColors.ControlText;
            this.tab_firms.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_firms.Location = new System.Drawing.Point(4, 38);
            this.tab_firms.Name = "tab_firms";
            this.tab_firms.Padding = new System.Windows.Forms.Padding(3);
            this.tab_firms.Size = new System.Drawing.Size(1369, 655);
            this.tab_firms.TabIndex = 1;
            this.tab_firms.Text = "FIRMS";
            this.tab_firms.Click += new System.EventHandler(this.tab_firms_Click);
            // 
            // tab_categories
            // 
            this.tab_categories.BackColor = System.Drawing.SystemColors.ControlText;
            this.tab_categories.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_categories.Location = new System.Drawing.Point(4, 38);
            this.tab_categories.Name = "tab_categories";
            this.tab_categories.Size = new System.Drawing.Size(1369, 655);
            this.tab_categories.TabIndex = 2;
            this.tab_categories.Text = "CATEGORIES";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 752);
            this.Controls.Add(this.sqlabC_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.sqlabC_Theme1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SQLABC_ModernUI.SQLABC_Theme sqlabC_Theme1;
        private SQLABC_ModernUI.SQLABC_TabControlA tabControl;
        private System.Windows.Forms.TabPage tab_admins;
        private System.Windows.Forms.TabPage tab_firms;
        private System.Windows.Forms.TabPage tab_categories;
    }
}