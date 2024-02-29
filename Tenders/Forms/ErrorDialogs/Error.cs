using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenders.ErrorDialogs
{
    public partial class Error : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Error()
        {
            InitializeComponent();

        }

        private void Error_Load(object sender, EventArgs e)
        {
            sqlabC_Theme1.Text = Title;
            
            tb_message.Text = Description ;
        }
    }
}
