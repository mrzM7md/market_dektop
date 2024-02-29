using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenders.Forms.Auth
{
    public partial class Main : Form
    {
        internal static SQLABC_ModernUI.SQLABC_CheckedButton btnSignIn;

        private Controllers.ControllerSignIn controllerSignIn = new Controllers.ControllerSignIn();
        private Controllers.ControllerSignUp controllerSignUp = new Controllers.ControllerSignUp();

        public static Main mainAuthPage;

        public Main()
        {
            InitializeComponent();
            
            btnSignIn = btn_signIn;
            mainAuthPage = this;
        }

 

        private void GoToSignUpController()
        {
            panel_cotrollers.Controls.Clear();
            panel_cotrollers.Controls.Add(controllerSignUp);
        }
        private void GoToSignInController()
        {
            panel_cotrollers.Controls.Clear();
            panel_cotrollers.Controls.Add(controllerSignIn);
        }
 
        private void btn_sign_up_CheckedChanged(object sender)
        {
            if (btn_signIn.Checked)
                GoToSignInController();
        }
        private void btn_signIn_CheckedChanged(object sender)
        {
            if(btn_sign_up.Checked)
                GoToSignUpController();
            
        }

        private void btn_sign_up_Click_1(object sender, EventArgs e)
        {

        }
    }
}
