using FastFoodManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodManager
{
    public partial class LogIn : Form
    {
        public static User a = null;
        public LogIn()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var context = new PRN211Context())
            {
                if(textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Username or Password can't blank");
                }
                else
                {
                    a = context.Users.FirstOrDefault(x => x.UserName.Equals(textBox1.Text) && x.Password.Equals(textBox2.Text));
                    if(a != null)
                    {
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect");
                    }
                }
            }
        }
    }
}
