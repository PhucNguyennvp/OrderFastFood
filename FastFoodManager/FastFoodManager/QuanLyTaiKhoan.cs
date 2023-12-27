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
    public partial class QuanLyTaiKhoan : Form
    {
        PRN211Context context = new PRN211Context();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridView1_Load();
            comboBox1.Items.Add("Nhân viên");
            comboBox1.Items.Add("Admin");
        }
        public void dataGridView1_Load()
        {
            List<User> list = new List<User>();
            foreach (User user in context.Users.ToList())
            {
                if (user.UserId != LogIn.a.UserId)
                    list.Add(user);
            }
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                if ((Boolean)row.Cells[4].Value == true)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                textBox5.Text = row.Cells[6].Value.ToString();
                textBox6.Text = row.Cells[7].Value.ToString();
                if (row.Cells[8].Value?.ToString() != null)
                    pictureBox1.Image = Image.FromFile(row.Cells[8].Value.ToString());
                if ((Boolean)row.Cells[9].Value == true)
                {
                    comboBox1.SelectedItem = "Admin";
                }
                else
                {
                    comboBox1.SelectedItem = "Nhân viên";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống hoặc chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (context.Users.FirstOrDefault(x => x.UserName.Equals(textBox2.Text)) == null)
            {
                if (textBox3.Text == null && string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống hoặc chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User user = new User();
                    user.UserName = textBox2.Text;
                    user.Password = textBox3.Text;
                    if (comboBox1.SelectedIndex == 1)
                    {
                        user.RoleId = true;
                    }
                    else
                    {
                        user.RoleId = false;
                    }
                    user.FullName = textBox4.Text;
                    user.Dob = dateTimePicker1.Value.Date;
                    if (radioButton1.Checked == true)
                    {
                        user.Gender = true;
                    }
                    else
                    {
                        user.Gender = false;
                    }
                    user.Address = textBox5.Text;
                    user.Mobile = textBox6.Text;
                    user.Avatar = pictureBox1.ImageLocation;
                    context.Users.Add(user);
                    context.SaveChanges();
                    dataGridView1_Load();
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại tên tài khoản này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(textBox1.Text));
            user.UserName = textBox2.Text;
            user.Password = textBox3.Text;
            if (comboBox1.SelectedIndex == 1)
            {
                user.RoleId = true;
            }
            else
            {
                user.RoleId = false;
            }
            user.FullName = textBox4.Text;
            user.Dob = dateTimePicker1.Value.Date;
            if (radioButton1.Checked == true)
            {
                user.Gender = true;
            }
            else
            {
                user.Gender = false;
            }
            user.Address = textBox5.Text;
            user.Mobile = textBox6.Text;
            user.Avatar = pictureBox1.ImageLocation;
            context.SaveChanges();
            dataGridView1_Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.Users.Remove(context.Users.FirstOrDefault(x => x.UserId == Convert.ToInt32(textBox1.Text)));
            context.SaveChanges();
            dataGridView1_Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image File | *.png; *.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
