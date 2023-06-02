namespace WinformPoject0527
{
    partial class BuyerLogin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.btnRegister = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLeaveToLogin = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRegister.Location = new System.Drawing.Point(454, 38);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(80, 38);
			this.btnRegister.TabIndex = 1;
			this.btnRegister.Text = "註冊";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(180, 117);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "帳號：";
			// 
			// txtA
			// 
			this.txtA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtA.Location = new System.Drawing.Point(230, 112);
			this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(157, 29);
			this.txtA.TabIndex = 3;
			this.txtA.Text = "Jason@123.com";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(180, 161);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "密碼：";
			// 
			// txtB
			// 
			this.txtB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtB.Location = new System.Drawing.Point(230, 156);
			this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtB.Name = "txtB";
			this.txtB.PasswordChar = '@';
			this.txtB.Size = new System.Drawing.Size(157, 29);
			this.txtB.TabIndex = 3;
			this.txtB.Text = "1234";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogin.Location = new System.Drawing.Point(307, 226);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(80, 38);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnLeaveToLogin
			// 
			this.btnLeaveToLogin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLeaveToLogin.Location = new System.Drawing.Point(184, 226);
			this.btnLeaveToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLeaveToLogin.Name = "btnLeaveToLogin";
			this.btnLeaveToLogin.Size = new System.Drawing.Size(80, 38);
			this.btnLeaveToLogin.TabIndex = 1;
			this.btnLeaveToLogin.Text = "離開";
			this.btnLeaveToLogin.UseVisualStyleBackColor = true;
			this.btnLeaveToLogin.Click += new System.EventHandler(this.btnLeaveToLogin_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(340, 47);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "還沒有會員嗎：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 7);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 35);
			this.label4.TabIndex = 18;
			this.label4.Text = "我是買家";
			// 
			// BuyerLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLeaveToLogin);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "BuyerLogin";
			this.Text = "1-1BuyerLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLeaveToLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

