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
    public partial class Menu : Form
    {
        PRN211Context context = new PRN211Context();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cbCateName.DataSource = context.Categories.Select(x => x.CategoryName).ToList();
            cbSize.Items.AddRange(new string[] { "S", "M", "L" });
            cbStatus.Items.AddRange(new string[] { "Khả dụng", "Không khả dụng" });
            cbCateName.SelectedIndex = 0;
            cbSize.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            dataGridView1_Load();
            dataGridView2_Load();
        }

        public void dataGridView1_Load()
        {
            dataGridView1.DataSource = context.Categories.Select(x => new { x.CategoryId, x.CategoryName }).ToList();
        }

        public void dataGridView2_Load()
        {
            var food = (from f in context.Foods
                        join o in context.Options on f.FoodId equals o.FoodId
                        join c in context.Categories on f.CategoryId equals c.CategoryId
                        select new
                        {
                            FoodID = f.FoodId,
                            FoodName = f.FoodName,
                            CategoryName = c.CategoryName,
                            Size = o.Size,
                            UnitPrice = o.Price,
                            Status = o.Status,
                            OptionID = o.Id
                        }).ToList();
            dataGridView2.DataSource = food;
            dataGridView2.Columns[6].Visible = false;
        }

        private void btAddFood_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            if (context.Foods.FirstOrDefault(x => x.FoodName.Equals(tbFoodName.Text)) == null)
            {
                Food food = new Food();
                food.CategoryId = context.Categories.FirstOrDefault(x => x.CategoryName.Equals(cbCateName.SelectedItem.ToString())).CategoryId;
                food.FoodName = tbFoodName.Text;
                context.Foods.Add(food);
                context.SaveChanges();
                option.FoodId = food.FoodId;
            }
            else
            {
                option.FoodId = Convert.ToInt32(tbFoodID.Text);
                option.Size = cbSize.SelectedItem.ToString();
                option.Price = (int?)nupPrice.Value;
                if (cbStatus.SelectedItem.ToString().Equals("Khả dụng"))
                {
                    option.Status = true;
                }
                else
                {
                    option.Status = false;
                }
                context.Options.Add(option);
                context.SaveChanges();
            }
            dataGridView2_Load();
        }

        private void btUpdateFood_Click(object sender, EventArgs e)
        {
            Food food = context.Foods.FirstOrDefault(x => x.FoodId == Convert.ToInt32(tbFoodID.Text));
            food.CategoryId = context.Categories.FirstOrDefault(x => x.CategoryName.Equals(cbCateName.SelectedItem.ToString())).CategoryId;
            food.FoodName = tbFoodName.Text;
            context.SaveChanges();
            if (context.Options.FirstOrDefault(x => x.FoodId == Convert.ToInt32(tbFoodID.Text)
            && x.Size.Equals(cbSize.SelectedItem.ToString())) != null)
            {
                Option option = context.Options.FirstOrDefault(x => x.Id == Convert.ToInt32(tbOptionID.Text));
                option.Size = cbSize.SelectedItem.ToString();
                option.Price = (int?)nupPrice.Value;
                if (cbStatus.SelectedItem.ToString().Equals("Khả dụng"))
                {
                    option.Status = true;
                }
                else
                {
                    option.Status = false;
                }
                context.SaveChanges();
                dataGridView2_Load();
            }
            else
            {
                MessageBox.Show("Đã tồn tại sản phẩm này rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDeleteFood_Click(object sender, EventArgs e)
        {
            Option option = context.Options.FirstOrDefault(x => x.Id == Convert.ToInt32(tbOptionID.Text));
            context.Options.Remove(option);
            context.SaveChanges();
            dataGridView2_Load();
        }

        private void btAddCate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = tbCateName.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            dataGridView1_Load();
        }

        private void btUpdateCate_Click(object sender, EventArgs e)
        {
            Category category = context.Categories.FirstOrDefault(x => x.CategoryId == Convert.ToInt32(tbCateID.Text));
            category.CategoryName = tbCateName.Text;
            context.SaveChanges();
            dataGridView1_Load();
            dataGridView2_Load();
        }

        private void btDeleteCate_Click(object sender, EventArgs e)
        {
            Category category = context.Categories.FirstOrDefault(x => x.CategoryId == Convert.ToInt32(tbCateID.Text));
            List<Food> foods = context.Foods.Where(x => x.CategoryId == Convert.ToInt32(tbCateID.Text)).ToList();
            foreach (Food f in foods)
            {
                context.Options.RemoveRange(context.Options.Where(x => x.FoodId == f.FoodId));
            }
            context.Foods.RemoveRange(foods);
            context.Categories.Remove(category);
            context.SaveChanges();
            dataGridView1_Load();
            dataGridView2_Load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbCateID.Text = row.Cells[0].Value.ToString();
                tbCateName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                tbFoodID.Text = row.Cells[0].Value.ToString();
                tbFoodName.Text = row.Cells[1].Value.ToString();
                cbCateName.SelectedItem = row.Cells[2].Value.ToString();
                cbSize.SelectedItem = row.Cells[3].Value.ToString();
                nupPrice.Value = new decimal((int)row.Cells[4].Value);
                if ((Boolean)row.Cells[5].Value == true)
                {
                    cbStatus.SelectedItem = 0;
                }
                else
                {
                    cbStatus.SelectedItem = 1;
                }
                tbOptionID.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
