using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSingn_Content_Manager_cs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Options.Instance.Email = emaill.Text.Substring(0, emaill.Text.IndexOf('@')) + "@dsign.by";
            Options.Instance.Email = emaill.Text;
            Options.Instance.Password = pass.Text;
            ((Form1)this.Owner).LoginUser(emaill.Text, pass.Text);
        }

        public void showAlert(string text)
        {
            label4.Text = text;
            emaill.Text = "";
            pass.Text = "";
        }
    }
}
