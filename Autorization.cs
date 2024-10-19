using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktika
{
    public partial class Autorization : Form
    {
        public Autorization(Main form)
        {
            Form = form;
            InitializeComponent();
        }

        public Main Form;

        string login;
        string password;
        private void login_Button_Click (object sender, EventArgs e)
        {
            if (login_TextBox.Text == "admin" && password_TextBox.Text == "admin") Close();
            else if (login_TextBox.Text == "donater" && password_TextBox.Text == "12344321") Close();
            else if (login_TextBox.Text == "lutador" && password_TextBox.Text == "675235") Close();
            else MessageBox.Show("Incorrect password or login");
        }

        private void exit_Button_Click (Object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
