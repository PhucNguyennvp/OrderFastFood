namespace FastFoodManager
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbOptionID = new System.Windows.Forms.TextBox();
            this.btDeleteFood = new System.Windows.Forms.Button();
            this.btUpdateFood = new System.Windows.Forms.Button();
            this.btAddFood = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.cbCateName = new System.Windows.Forms.ComboBox();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.tbFoodID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btDeleteCate = new System.Windows.Forms.Button();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.btUpdateCate = new System.Windows.Forms.Button();
            this.btAddCate = new System.Windows.Forms.Button();
            this.tbCateID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOptionID
            // 
            this.tbOptionID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOptionID.HideSelection = false;
            this.tbOptionID.Location = new System.Drawing.Point(711, 518);
            this.tbOptionID.Name = "tbOptionID";
            this.tbOptionID.Size = new System.Drawing.Size(56, 30);
            this.tbOptionID.TabIndex = 19;
            this.tbOptionID.Visible = false;
            // 
            // btDeleteFood
            // 
            this.btDeleteFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteFood.ForeColor = System.Drawing.Color.Black;
            this.btDeleteFood.Location = new System.Drawing.Point(536, 712);
            this.btDeleteFood.Name = "btDeleteFood";
            this.btDeleteFood.Size = new System.Drawing.Size(99, 50);
            this.btDeleteFood.TabIndex = 18;
            this.btDeleteFood.Text = "Delete";
            this.btDeleteFood.UseVisualStyleBackColor = true;
            this.btDeleteFood.Click += new System.EventHandler(this.btDeleteFood_Click);
            // 
            // btUpdateFood
            // 
            this.btUpdateFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdateFood.ForeColor = System.Drawing.Color.Black;
            this.btUpdateFood.Location = new System.Drawing.Point(366, 712);
            this.btUpdateFood.Name = "btUpdateFood";
            this.btUpdateFood.Size = new System.Drawing.Size(99, 50);
            this.btUpdateFood.TabIndex = 17;
            this.btUpdateFood.Text = "Update";
            this.btUpdateFood.UseVisualStyleBackColor = true;
            this.btUpdateFood.Click += new System.EventHandler(this.btUpdateFood_Click);
            // 
            // btAddFood
            // 
            this.btAddFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddFood.ForeColor = System.Drawing.Color.Black;
            this.btAddFood.Location = new System.Drawing.Point(182, 712);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(99, 50);
            this.btAddFood.TabIndex = 16;
            this.btAddFood.Text = "Add";
            this.btAddFood.UseVisualStyleBackColor = true;
            this.btAddFood.Click += new System.EventHandler(this.btAddFood_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(536, 624);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(145, 30);
            this.cbStatus.TabIndex = 15;
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(532, 519);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(151, 30);
            this.cbSize.TabIndex = 14;
            // 
            // nupPrice
            // 
            this.nupPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupPrice.Location = new System.Drawing.Point(533, 571);
            this.nupPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupPrice.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(150, 30);
            this.nupPrice.TabIndex = 13;
            this.nupPrice.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // cbCateName
            // 
            this.cbCateName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCateName.FormattingEnabled = true;
            this.cbCateName.Location = new System.Drawing.Point(246, 625);
            this.cbCateName.Name = "cbCateName";
            this.cbCateName.Size = new System.Drawing.Size(204, 30);
            this.cbCateName.TabIndex = 11;
            // 
            // tbFoodName
            // 
            this.tbFoodName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFoodName.Location = new System.Drawing.Point(226, 571);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(224, 30);
            this.tbFoodName.TabIndex = 9;
            // 
            // tbFoodID
            // 
            this.tbFoodID.Enabled = false;
            this.tbFoodID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFoodID.Location = new System.Drawing.Point(226, 521);
            this.tbFoodID.Name = "tbFoodID";
            this.tbFoodID.Size = new System.Drawing.Size(224, 30);
            this.tbFoodID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(469, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(469, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(469, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "CategoryName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "FoodName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "FoodID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(7, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(777, 458);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btDeleteCate
            // 
            this.btDeleteCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteCate.ForeColor = System.Drawing.Color.Black;
            this.btDeleteCate.Location = new System.Drawing.Point(306, 712);
            this.btDeleteCate.Name = "btDeleteCate";
            this.btDeleteCate.Size = new System.Drawing.Size(99, 50);
            this.btDeleteCate.TabIndex = 21;
            this.btDeleteCate.Text = "Delete";
            this.btDeleteCate.UseVisualStyleBackColor = true;
            this.btDeleteCate.Click += new System.EventHandler(this.btDeleteCate_Click);
            // 
            // tbCateName
            // 
            this.tbCateName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCateName.Location = new System.Drawing.Point(145, 571);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(224, 30);
            this.tbCateName.TabIndex = 4;
            // 
            // btUpdateCate
            // 
            this.btUpdateCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdateCate.ForeColor = System.Drawing.Color.Black;
            this.btUpdateCate.Location = new System.Drawing.Point(169, 712);
            this.btUpdateCate.Name = "btUpdateCate";
            this.btUpdateCate.Size = new System.Drawing.Size(99, 50);
            this.btUpdateCate.TabIndex = 20;
            this.btUpdateCate.Text = "Update";
            this.btUpdateCate.UseVisualStyleBackColor = true;
            this.btUpdateCate.Click += new System.EventHandler(this.btUpdateCate_Click);
            // 
            // btAddCate
            // 
            this.btAddCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddCate.ForeColor = System.Drawing.Color.Black;
            this.btAddCate.Location = new System.Drawing.Point(35, 712);
            this.btAddCate.Name = "btAddCate";
            this.btAddCate.Size = new System.Drawing.Size(99, 50);
            this.btAddCate.TabIndex = 19;
            this.btAddCate.Text = "Add";
            this.btAddCate.UseVisualStyleBackColor = true;
            this.btAddCate.Click += new System.EventHandler(this.btAddCate_Click);
            // 
            // tbCateID
            // 
            this.tbCateID.Enabled = false;
            this.tbCateID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCateID.Location = new System.Drawing.Point(145, 518);
            this.tbCateID.Name = "tbCateID";
            this.tbCateID.Size = new System.Drawing.Size(224, 30);
            this.tbCateID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "CategoryName:";
            // 
            // CategoryID
            // 
            this.CategoryID.AutoSize = true;
            this.CategoryID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryID.ForeColor = System.Drawing.Color.Black;
            this.CategoryID.Location = new System.Drawing.Point(6, 530);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(107, 22);
            this.CategoryID.TabIndex = 1;
            this.CategoryID.Text = "CategoryID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(415, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOptionID);
            this.groupBox2.Controls.Add(this.btDeleteFood);
            this.groupBox2.Controls.Add(this.btUpdateFood);
            this.groupBox2.Controls.Add(this.btAddFood);
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.cbSize);
            this.groupBox2.Controls.Add(this.nupPrice);
            this.groupBox2.Controls.Add(this.cbCateName);
            this.groupBox2.Controls.Add(this.tbFoodName);
            this.groupBox2.Controls.Add(this.tbFoodID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(451, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 771);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDeleteCate);
            this.groupBox1.Controls.Add(this.tbCateName);
            this.groupBox1.Controls.Add(this.btUpdateCate);
            this.groupBox1.Controls.Add(this.btAddCate);
            this.groupBox1.Controls.Add(this.tbCateID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CategoryID);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(19, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 771);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 809);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbOptionID;
        private Button btDeleteFood;
        private Button btUpdateFood;
        private Button btAddFood;
        private ComboBox cbStatus;
        private ComboBox cbSize;
        private NumericUpDown nupPrice;
        private ComboBox cbCateName;
        private TextBox tbFoodName;
        private TextBox tbFoodID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView2;
        private Button btDeleteCate;
        private TextBox tbCateName;
        private Button btUpdateCate;
        private Button btAddCate;
        private TextBox tbCateID;
        private Label label1;
        private Label CategoryID;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}