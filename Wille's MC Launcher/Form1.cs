using CmlLib.Core.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wille_s_MC_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MLogin login = new MLogin();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateSession(MSession session)
        {
            // Success to login!

            var mainForm = new MainForm(session);
            mainForm.FormClosed += (s, e) => this.Close();
            mainForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("The email/password field can't be blank!");
                return;
            }

            gMojangLogin.Enabled = false;
            gOfflineLogin.Enabled = false;

            var th = new Thread(new ThreadStart(delegate
            {
                var result = login.Authenticate(txtEmail.Text, txtPassword.Text);
                if (result.Result == MLoginResult.Success)
                {
                    MessageBox.Show("You successfully logged in! Welcome!"); // Success Login
                    Invoke(new Action(() =>
                    {
                        UpdateSession(result.Session);
                    }));
                }
                else
                {
                    MessageBox.Show(result.Result.ToString() + "\n" + result.ErrorMessage); // Failed to login. Show error message
                    Invoke(new Action(() =>
                    {
                        gMojangLogin.Enabled = true;
                        gOfflineLogin.Enabled = true;
                    }));
                }
            }));
            th.Start();
        }

        private void btnOfflineLogin_Click(object sender, EventArgs e)
        {
            UpdateSession(MSession.GetOfflineSession(txtUsername.Text));
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
