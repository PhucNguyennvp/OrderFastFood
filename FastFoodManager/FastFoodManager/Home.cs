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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FastFoodManager
{
    public partial class Home : Form
    {
        public static int tableID = 0;
        Boolean status = false;
        public static string tableName = null;
        public static int billID = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (LogIn.a.RoleId == false)
            {
                toolStripMenuItem2.Visible = false;
            }
            else
            {
                toolStripMenuItem2.Visible = true;
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("0", "FoodName");
            dataGridView1.Columns["0"].DataPropertyName = "FoodName";
            dataGridView1.Columns.Add("1", "Size");
            dataGridView1.Columns["1"].DataPropertyName = "Size";
            dataGridView1.Columns.Add("2", "UnitPrice");
            dataGridView1.Columns["2"].DataPropertyName = "UnitPrice";
            dataGridView1.Columns.Add("3", "Amount");
            dataGridView1.Columns["3"].DataPropertyName = "Amount";
            BanAn_Load();
            FormDatDo_Load();
        }

        private void BanAn_Load()
        {
            using (var context = new PRN211Context())
            {
                flowLayoutPanel1.Controls.Clear();// làm mới sơ đồ bàn
                List<Table> tables = context.Tables.ToList(); ;
                foreach (Table t in tables)
                {
                    Button button = new Button();
                    string status = null;
                    button.Click += button_click;// tạo sự kiện click cho button
                    button.Tag = t; // dùng để xác định ID của mỗi button
                    button.Width = 100;
                    button.Height = 100;
                    if (t.Status == false)
                    {
                        status = "Trống";
                    }
                    else
                    {
                        status = "Đã có khách";
                        button.BackColor = Color.Green;
                    }
                    button.Text = "Bàn " + t.TableName + "\n" + status;
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
        }
        private void button_click(object sender, EventArgs e)
        {
            using (var context = new PRN211Context())
            {
                Boolean createNew = true;
                tableID = ((sender as Button).Tag as Table).TableId;
                status = (Boolean)((sender as Button).Tag as Table).Status;
                tableName = ((sender as Button).Tag as Table).TableName;

                foreach (Bill b in context.Bills.Where(x => x.TableId == tableID))
                {
                    if (b.Status == false)
                    {
                        createNew = false;
                    }
                }
                if (status == false && createNew == true)
                {
                    Bill bill = new Bill();
                    bill.TableId = tableID;
                    bill.Status = false;
                    context.Bills.Add(bill);
                    context.SaveChanges();
                    billID = bill.BillId;
                }
                else
                {
                    billID = context.Bills.FirstOrDefault(x => x.TableId == tableID && x.Status == false).BillId;
                }
                DSDoAn_Load(billID, tableID);
            }
        }

        private void FormDatDo_Load()
        {
            using (var context = new PRN211Context())
            {
                comboBox1.DataSource = context.Categories.ToList();
                comboBox1.DisplayMember = "CategoryName";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var context = new PRN211Context())
            {
                string cateName = comboBox1.Text;
                comboBox2.DataSource = context.Foods.Where(x=>x.Category.CategoryName.Equals(cateName)).ToList();
                comboBox2.DisplayMember = "FoodName";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new PRN211Context())
            {
                string foodName = comboBox2.Text;
                comboBox3.DataSource = context.Options.Where(x => x.Food.FoodName.Equals(foodName)).ToList();
                comboBox3.DisplayMember = "Size";
            }
        }

        private void DSDoAn_Load(int billID, int tableID)
        {
            using (var context = new PRN211Context())
            {
                var dsDo = (from b in context.Bills
                            join bd in context.BillDetails on b.BillId equals bd.BillId
                            join f in context.Foods on bd.FoodId equals f.FoodId
                            join o in context.Options on f.FoodId equals o.FoodId
                            where b.BillId == billID && b.TableId == tableID && bd.Size == o.Size && bd.FoodId == o.FoodId
                            select new
                            {
                                FoodName = f.FoodName,
                                Size = bd.Size,
                                UnitPrice = o.Price,
                                Amount = bd.Amount
                            }).ToList();
                dataGridView1.DataSource = dsDo;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211Context())
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Chưa chọn món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (comboBox3.Text == "")
                {
                    MessageBox.Show("Chưa chọn size.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BillDetail billDetail = new BillDetail();
                    billDetail.BillId = billID;
                    Table table = context.Tables.FirstOrDefault(x => x.TableId == tableID);
                    if (table != null) table.Status = true;
                    billDetail.FoodId = context.Foods.FirstOrDefault(x => x.FoodName.Equals(comboBox2.Text)).FoodId;
                    billDetail.Size = comboBox3.Text;
                    billDetail.Amount = (byte?)numericUpDown1.Value;
                    context.BillDetails.Add(billDetail);
                    context.SaveChanges();
                    dataGridView1.DataSource = null;
                    BanAn_Load();
                    DSDoAn_Load(billID, tableID);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có đồ, không thể thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                ThanhToan thanhToan = new ThanhToan();
                thanhToan.Show();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn.a = null;
            LogIn login = new LogIn();
            login.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan();
            thongTinCaNhan.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            quanLyTaiKhoan.Show();
        }
    }
}
