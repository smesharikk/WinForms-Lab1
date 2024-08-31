using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Lab1
{
    public partial class FormLogin : Form
    {
        public FormLogin(FormCreateChange f1)
        {
            InitializeComponent();

            cAdmin.Items.Add("user");
            cAdmin.Items.Add("admin");
            cAdmin.SelectedIndex = 0;
            tPassword.Enabled = false;
            tPassword.PasswordChar = '*';
            f = f1;
            MD5 md5 = new MD5CryptoServiceProvider();
            HashPassword = "A6-6A-BB-56-84-C4-59-62-D8-87-56-4F-08-34-6E-8D";
        }
        FormCreateChange f;
        private string HashPassword;
        //Boolean flagRightPassword = false;
        private void bOK_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] InputPBytes = Encoding.UTF8.GetBytes("admin" + tPassword.Text);
            string InputPassword = BitConverter.ToString(md5.ComputeHash(InputPBytes));
            if (HashPassword == InputPassword)
            {

                f.flagRightPassword = true;
                Close();
            }
            else
            {
                lWrongPassword.Text = "Неверный пароль";
            }
        }

        private void cAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cAdmin.SelectedIndex == 0)
            {
                tPassword.Enabled = false;
                bOk.Enabled = false;
            }
            else
            {
                tPassword.Enabled = true;
                bOk.Enabled = true;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
