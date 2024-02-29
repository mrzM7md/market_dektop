using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenders.Testing
{
    public partial class MainTest : Form
    {
        UserControl1 userControl = new UserControl1();
        public MainTest()
        {
            InitializeComponent();

            sqlabC_TabControlA1.SelectedTab.Controls.Clear();

            tabPage1.Controls.Add(userControl);
        }
    }
}
