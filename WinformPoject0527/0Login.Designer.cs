namespace WinformPoject0527
{
    partial class Login
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
			this.btnBuyer = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBuyer
			// 
			this.btnBuyer.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBuyer.Location = new System.Drawing.Point(190, 104);
			this.btnBuyer.Name = "btnBuyer";
			this.btnBuyer.Size = new System.Drawing.Size(413, 82);
			this.btnBuyer.TabIndex = 0;
			this.btnBuyer.Text = "我是買家";
			this.btnBuyer.UseVisualStyleBackColor = true;
			this.btnBuyer.Click += new System.EventHandler(this.BtnBuyer_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(190, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(413, 82);
			this.button2.TabIndex = 1;
			this.button2.Text = "我是賣家";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnBuyer);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuyer;
        private System.Windows.Forms.Button button2;
    }
}