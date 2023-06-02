namespace WinformPoject0527
{
    partial class BuyerMain
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
			this.components = new System.ComponentModel.Container();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnIntoMember = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnIntoBuyList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.btnIntoCar = new System.Windows.Forms.Button();
			this.labLoginName = new System.Windows.Forms.Label();
			this.trytryseeDataSet = new WinformPoject0527.trytryseeDataSet();
			this.productCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoriesTableAdapter = new WinformPoject0527.trytryseeDataSetTableAdapters.ProductCategoriesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trytryseeDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoriesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(109, 74);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(92, 20);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(109, 118);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(92, 20);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(109, 158);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(92, 20);
			this.comboBox3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(24, 73);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "主分類：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(16, 115);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "細項分類：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(24, 156);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "品牌：";
			// 
			// btnIntoMember
			// 
			this.btnIntoMember.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnIntoMember.Location = new System.Drawing.Point(409, 9);
			this.btnIntoMember.Margin = new System.Windows.Forms.Padding(2);
			this.btnIntoMember.Name = "btnIntoMember";
			this.btnIntoMember.Size = new System.Drawing.Size(98, 38);
			this.btnIntoMember.TabIndex = 13;
			this.btnIntoMember.Text = "會員資料";
			this.btnIntoMember.UseVisualStyleBackColor = true;
			this.btnIntoMember.Click += new System.EventHandler(this.btnIntoMember_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnExit.Location = new System.Drawing.Point(512, 9);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 38);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "登出";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnIntoBuyList
			// 
			this.btnIntoBuyList.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnIntoBuyList.Location = new System.Drawing.Point(306, 9);
			this.btnIntoBuyList.Margin = new System.Windows.Forms.Padding(2);
			this.btnIntoBuyList.Name = "btnIntoBuyList";
			this.btnIntoBuyList.Size = new System.Drawing.Size(98, 38);
			this.btnIntoBuyList.TabIndex = 13;
			this.btnIntoBuyList.Text = "購買記錄";
			this.btnIntoBuyList.UseVisualStyleBackColor = true;
			this.btnIntoBuyList.Click += new System.EventHandler(this.btnIntoBuyList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Location = new System.Drawing.Point(224, 72);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(534, 262);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ProductID";
			this.Column1.HeaderText = "商品編號";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.DataPropertyName = "ProductName";
			this.Column2.HeaderText = "商品名稱";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ProductDescription";
			this.Column3.HeaderText = "商品描述";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ProductPrice";
			this.Column4.HeaderText = "單價";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 13);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 35);
			this.label4.TabIndex = 5;
			this.label4.Text = "買家主頁";
			// 
			// btnIntoCar
			// 
			this.btnIntoCar.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnIntoCar.Location = new System.Drawing.Point(466, 353);
			this.btnIntoCar.Margin = new System.Windows.Forms.Padding(2);
			this.btnIntoCar.Name = "btnIntoCar";
			this.btnIntoCar.Size = new System.Drawing.Size(115, 38);
			this.btnIntoCar.TabIndex = 13;
			this.btnIntoCar.Text = "進入購物車";
			this.btnIntoCar.UseVisualStyleBackColor = true;
			this.btnIntoCar.Click += new System.EventHandler(this.btnIntoCar_Click);
			// 
			// labLoginName
			// 
			this.labLoginName.AutoSize = true;
			this.labLoginName.Location = new System.Drawing.Point(150, 25);
			this.labLoginName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labLoginName.Name = "labLoginName";
			this.labLoginName.Size = new System.Drawing.Size(23, 12);
			this.labLoginName.TabIndex = 15;
			this.labLoginName.Text = "123";
			// 
			// trytryseeDataSet
			// 
			this.trytryseeDataSet.DataSetName = "trytryseeDataSet";
			this.trytryseeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productCategoriesBindingSource
			// 
			this.productCategoriesBindingSource.DataMember = "ProductCategories";
			this.productCategoriesBindingSource.DataSource = this.trytryseeDataSet;
			// 
			// productCategoriesTableAdapter
			// 
			this.productCategoriesTableAdapter.ClearBeforeFill = true;
			// 
			// BuyerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 401);
			this.Controls.Add(this.labLoginName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnIntoCar);
			this.Controls.Add(this.btnIntoBuyList);
			this.Controls.Add(this.btnIntoMember);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "BuyerMain";
			this.Text = "BuyerMain";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trytryseeDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoriesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIntoMember;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnIntoBuyList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIntoCar;
		private System.Windows.Forms.Label labLoginName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private trytryseeDataSet trytryseeDataSet;
		private System.Windows.Forms.BindingSource productCategoriesBindingSource;
		private trytryseeDataSetTableAdapters.ProductCategoriesTableAdapter productCategoriesTableAdapter;
	}
}