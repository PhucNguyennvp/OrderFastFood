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
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            User a = LogIn.a;
            textBox1.Text = LogIn.a.UserId.ToString();
            textBox2.Text = LogIn.a.FullName;
            textBox5.Text = LogIn.a.Address;
            textBox6.Text = LogIn.a.Mobile;
            dateTimePicker1.Value = (DateTime)LogIn.a.Dob;
            if (LogIn.a.Gender == true)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            if (LogIn.a.Avatar != null)
                pictureBox1.Image = Image.FromFile(LogIn.a.Avatar);
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn.a.FullName = textBox2.Text;
            LogIn.a.Dob = dateTimePicker1.Value.Date;
            if (radioButton1.Checked == true)
            {
                LogIn.a.Gender = true;
            }
            else
            {
                LogIn.a.Gender = false;
            }
            LogIn.a.Address = textBox5.Text;
            LogIn.a.Mobile = textBox6.Text;
            LogIn.a.Avatar = pictureBox1.ImageLocation;
            textBox2.Text = pictureBox1.ImageLocation;
            PRN211Context context = new PRN211Context();
            context.Users.Update(LogIn.a);
            context.SaveChanges();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image File | *.png; *.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
