using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenders.EncryptionDecryption;
using Tenders.Processes;

namespace Tenders.Forms.Auth.Controllers
{
    public partial class ControllerSignUp : UserControl
    {
        private short PERMMISSION_CLIENT = 4;


        private Bitmap profileImagePath = global::Tenders.Properties.Resources.ic_profile; // default image

        private EncryptionDecryptionText encryptionDecryptionText = new EncryptionDecryptionText();
        private EncryptionDecryptionImage encryptionDecryptionImage = new EncryptionDecryptionImage();
        private ClientProcesses ClientProcesses = new ClientProcesses();
        private AccountProcesses accountProcesses = new AccountProcesses();
        private OpenFileDialog ofd = new OpenFileDialog();

        public ControllerSignUp()
        {
            InitializeComponent();
            
        }



        private void SignUp()
        {
            if (IsAllFieldsFilled() == true)
            {
                if (IsPasswordAndConfirmPasswordAreSame())
                {
                    if (IsUsernameNotUsedBefor() == true)
                    {//check that Username not used befor
                        InsertClientDataToClientTable(); //sucessfully AddCategory, new user added !!
                        tb_username.Text = "";
                        HideAlertErrorMessage();
                        Main.btnSignIn.Checked = true;
                        ClearAllTextBoks();

                    }
                    else //if another one has same Username already
                    {
                        ShowAlertErrorMessage("this Username already used !!");
                        tb_username.Text = "";
                        tb_username.Focus();
                    }
                }
                else
                {
                    ShowAlertErrorMessage("Make sure that Passwords are same");
                }
            }
            else
            {
                ShowAlertErrorMessage("Make sure all fields are filled");
            }
        }

        private bool IsAllFieldsFilled()
        {
            if (!tb_username.Text.Equals("") &&
                !tb_name.Text.Equals("") &&
                !tb_password.Text.Equals("") &&
                !tb_confirm_password.Text.Equals("") &&
                !tb_email.Text.Equals("") &&
                !cb_gender.Text.Equals("") &&
                !tb_phone.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private bool IsPasswordAndConfirmPasswordAreSame()
        {
            if (tb_password.Text.Trim() == tb_confirm_password.Text.Trim())
            {
                return true;
            }
            return false;
        }
        private void ShowAlertErrorMessage(string errorMessage)
        {
            alert_signup_client_error.Visible = true;
            alert_signup_client_error.Text = errorMessage;
        }
        private void HideAlertErrorMessage()
        {
            alert_signup_client_error.Visible = false;
        }

        private bool IsUsernameNotUsedBefor()
        {
            string username = tb_username.Text.Trim();
            return ClientProcesses.IsUsernameNew(encryptionDecryptionText.Encryption(username));
        }

        private void InsertClientDataToClientTable()
        {
            Models.Account accountClient = new Models.Account
            {
                Username = encryptionDecryptionText.Encryption(tb_username.Text.Trim()),
                Password = encryptionDecryptionText.Encryption(tb_password.Text.Trim()),
                PermissionId = PERMMISSION_CLIENT,
                Email = encryptionDecryptionText.Encryption(tb_email.Text.Trim()),
                Phone = encryptionDecryptionText.Encryption(tb_phone.Text.Trim()),
            };

            accountProcesses.Add(accountClient);
            int accountClientId = accountProcesses.GetId(accountClient);

            Models.Client ClientInfo = new Models.Client
            {
                Name = encryptionDecryptionText.Encryption(tb_name.Text.Trim()),
                Gender = encryptionDecryptionText.Encryption(cb_gender.Text.Trim()),
                IdentityImage = encryptionDecryptionImage.Encryption(profileImagePath),
                AccountId = accountClientId,
                Account = accountClient,
            };

            ClientProcesses.Add(ClientInfo);
        }

        private void btn_select_image_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profileImagePath = new Bitmap(ofd.FileName);  // new image
                pb_image.Image = (Image)profileImagePath;
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void ClearAllTextBoks()
        {
            tb_username.Text = "";
            tb_password.Text = "";
            tb_confirm_password.Text = "";
            tb_email.Text = "";
            tb_phone.Text = "";
            tb_name.Text = "";
            tb_username.Text = "";
        }
    }
}
