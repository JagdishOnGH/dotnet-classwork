using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginToDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginBtn.Click += loginBtn_Click;
            errorMsgLbl.ForeColor = System.Drawing.Color.Red;

        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = this.userNameTextField.Text;
            String password = this.passwordTextField.Text;

            if (String.IsNullOrEmpty(username)   )
            {
                errorMsgLbl.Text = "Username  is unfilled or blank";
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                errorMsgLbl.Text = "Password is unfilled or blank";
                return;

            }
            if(username != "admin")
            {
                errorMsgLbl.Text = "Invalid username";
                return;
            }if(password != "password")
            {
                errorMsgLbl.Text = "Invalid Credentials";
                return;
            }
            errorMsgLbl.Text = "";
            var dashboard = new Dashboard("VeryCaringMessage");
            this.Hide();
            dashboard.ShowDialog();
           

            


        }

        
    }
}
