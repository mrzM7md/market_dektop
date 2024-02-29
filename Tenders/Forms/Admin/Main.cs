using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenders.Forms.Admin.Controllers;

namespace Tenders.Forms.Admin
{
    public partial class Main : Form
    {
        ControllerAdmin admin = new ControllerAdmin();
        ControlletFirms firms = new ControlletFirms();
        ControllerCategories categories = new ControllerCategories();
       
        public Main()
        {
            InitializeComponent();

            tabControl.SelectedTab.Controls.Clear();
            tab_admins.Controls.Add(admin);
            tab_firms.Controls.Add(firms);
            tab_categories.Controls.Add(categories);
    
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tab_firms_Click(object sender, EventArgs e)
        {

        }
    }
}
