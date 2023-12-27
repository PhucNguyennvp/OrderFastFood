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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastFoodManager
{
    public partial class ThanhToan : Form
    {
        PRN211Context context = new PRN211Context();
        int total = 0;
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("0", "FoodName");
            dataGridView1.Columns["0"].DataPropertyName = "FoodName";
            dataGridView1.Columns.Add("1", "Size");
            dataGridView1.Columns["1"].DataPropertyName = "Size";
            dataGridView1.Columns.Add("2", "UnitPrice");
            dataGridView1.Columns["2"].DataPropertyName = "UnitPrice";
            dataGridView1.Columns.Add("3", "Amount");
            dataGridView1.Columns["3"].DataPropertyName = "Amount";
            textBox1.Text = Home.billID.ToString();
            textBox2.Text = Home.tableName;
            textBox3.Text = DateTime.Now.ToString();
            DS_Load();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                total += Convert.ToInt32(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);
            textBox4.Text = total.ToString();
        }


        internal void DS_Load()
        {
            using (var context = new PRN211Context())
            {
                var hoaDon = (from b in context.Bills
                              join bd in context.BillDetails on b.BillId equals bd.BillId
                              join f in context.Foods on bd.FoodId equals f.FoodId
                              join o in context.Options on f.FoodId equals o.FoodId
                              where b.BillId == Home.billID && b.TableId == Home.tableID && bd.Size == o.Size && bd.FoodId == o.FoodId
                              select new
                              {
                                  FoodName = f.FoodName,
                                  Size = bd.Size,
                                  UnitPrice = o.Price,

                                  Amount = bd.Amount
                              }).ToList();
                dataGridView1.DataSource = hoaDon;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PRN211Context())
            {
                context.Bills.FirstOrDefault(x => x.BillId == Home.billID).CheckOut = DateTime.Parse(textBox3.Text);
                context.Bills.FirstOrDefault(x => x.BillId == Home.billID).TotalPrice = total.ToString();
                context.Bills.FirstOrDefault(x => x.BillId == Home.billID).Status = true;
                context.Tables.FirstOrDefault(x => x.TableId == Home.tableID).Status = false;
                context.SaveChanges();
                this.Hide();
                Home home = new Home();
                home.Show();
            }            
        }
    }
}
