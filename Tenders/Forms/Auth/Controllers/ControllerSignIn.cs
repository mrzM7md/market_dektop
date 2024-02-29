using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenders.Processes;

namespace Tenders.Forms.Auth.Controllers
{
    public partial class ControllerSignIn : UserControl
    {
        private readonly short MASTER_ADMIN_PERMISSION = 1;
        private readonly short ADMIN_PERMISSION = 2;
        private readonly short FIRM_PERMISSION = 3;
        private readonly short CLIENT_PERMISSION = 4;
       
        public static short PREMISSION;

        private Models.Account selectedAccount;  /////////////////////////////////////////
        

        public ControllerSignIn()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void SignIn()
        {
            if (IsAllFieldsFill())
            {
                HideErrorMessage();
                GetAccountDataFromAccountsTable();
            }
            else
            {
                TestFieldsValidation();
            }
        }

        private bool IsAllFieldsFill()
        {
            return tb_username.Text != "" && tb_password.Text != "";
        }

        private void GetAccountDataFromAccountsTable()
        {
            EncryptionDecryption.EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryption.EncryptionDecryptionText();
            Models.Account account = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_password.Text.Trim()),
            };

            
            selectedAccount = new AccountProcesses().IsLoginedSuccessfully(account);
            if (selectedAccount == null)
            {
                ShowErrorMessage("`Usernamw` or `Password` or both not correct");
                tb_username.Focus();
            }
            else
            {
                PREMISSION = selectedAccount.PermissionId;
                // IF USER IS ADMIN OR MASETER ADMIN
                if (PREMISSION == MASTER_ADMIN_PERMISSION || PREMISSION == ADMIN_PERMISSION)
                {
                    // GO TO ADMIN PAGE !!
                    new Forms.Admin.Main().ShowDialog();
                }
                // IF USER IS A FIRM
                else if (selectedAccount.PermissionId == FIRM_PERMISSION)
                {
                    
                    FirmProcesses f = new FirmProcesses();
                    int fitmSelectedId = int.Parse(f.GetAll().Where(x => x.AccountId == selectedAccount.Id).Select(z => z.Id).First().ToString());
                    // GO TO FIRM PAGE !!
                    new Forms.Firm.Main(fitmSelectedId).ShowDialog();
                }
                // IF USER IS A CLIENT
                else  if (selectedAccount.PermissionId == CLIENT_PERMISSION)
                {
                    ClientProcesses c = new ClientProcesses();
                    List<Models.Client> clientSelectedId = c.GetAll().ToList();
                    int i = int.Parse(clientSelectedId.Where(x=> x.AccountId == selectedAccount.Id).Select(z => z.Id).First().ToString());


                    // GO TO CLIENT PAGE !!

                    new Forms.Client.Main(i).ShowDialog();
                }
            }

        }

        private void TestFieldsValidation()
        {
            if (tb_username.Text == "")
            {
                ShowErrorMessage("Please make sure you fill `Username` field");
                tb_username.Focus();
            }
            else
            {
                ShowErrorMessage("Please make sure you fill `Password` field");
                tb_password.Focus();
            }
        }

        private void ShowErrorMessage(string errorMessage)
        {
            alert_signin_client_error.Visible = true;
            alert_signin_client_error.Text = errorMessage;
        }

        private void HideErrorMessage()
        {
            alert_signin_client_error.Visible = false;
        }
    }
}
