namespace WinformPoject0527
{
    partial class BuyerAdd
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.btnAddIntoCar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.labSub = new System.Windows.Forms.Label();
			this.labAdd = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtName.Location = new System.Drawing.Point(369, 62);
			this.txtName.Margin = new System.Windows.Forms.Padding(2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(157, 29);
			this.txtName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(288, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "商品名稱：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(288, 106);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "數量：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(288, 143);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "金額：";
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPrice.Location = new System.Drawing.Point(369, 143);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(157, 29);
			this.txtPrice.TabIndex = 7;
			// 
			// btnAddIntoCar
			// 
			this.btnAddIntoCar.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAddIntoCar.Location = new System.Drawing.Point(410, 186);
			this.btnAddIntoCar.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddIntoCar.Name = "btnAddIntoCar";
			this.btnAddIntoCar.Size = new System.Drawing.Size(115, 38);
			this.btnAddIntoCar.TabIndex = 1;
			this.btnAddIntoCar.Text = "加入購物車";
			this.btnAddIntoCar.UseVisualStyleBackColor = true;
			this.btnAddIntoCar.Click += new System.EventHandler(this.btnAddIntoCar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(62, 62);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(191, 170);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtQty.Location = new System.Drawing.Point(410, 103);
			this.txtQty.Margin = new System.Windows.Forms.Padding(2);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(71, 33);
			this.txtQty.TabIndex = 0;
			this.txtQty.Text = "1";
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labSub
			// 
			this.labSub.AutoSize = true;
			this.labSub.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labSub.Location = new System.Drawing.Point(374, 97);
			this.labSub.Name = "labSub";
			this.labSub.Size = new System.Drawing.Size(31, 40);
			this.labSub.TabIndex = 16;
			this.labSub.Text = "-";
			this.labSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labSub.Click += new System.EventHandler(this.labSub_Click);
			// 
			// labAdd
			// 
			this.labAdd.AutoSize = true;
			this.labAdd.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labAdd.Location = new System.Drawing.Point(486, 97);
			this.labAdd.Name = "labAdd";
			this.labAdd.Size = new System.Drawing.Size(41, 40);
			this.labAdd.TabIndex = 17;
			this.labAdd.Text = "+";
			this.labAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labAdd.Click += new System.EventHandler(this.labAdd_Click);
			// 
			// BuyerAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.labAdd);
			this.Controls.Add(this.labSub);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAddIntoCar);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "BuyerAdd";
			this.Text = "BuyerAdd";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddIntoCar;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label labSub;
		private System.Windows.Forms.Label labAdd;
	}
}