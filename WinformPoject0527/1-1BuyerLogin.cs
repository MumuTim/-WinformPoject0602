using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
	public partial class BuyerLogin : Form
	{

		public BuyerLogin()
		{
			InitializeComponent();
		}


		private void btnLeaveToLogin_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string account = txtA.Text;
			string password = txtB.Text;

			if (account != null)
			{
				var result = new AppDbContext().Users
										.AsNoTracking()
										.Where(x => x.UserAccount == account)
										.SingleOrDefault();
				if (result != null)
				{
					if (password != null && password == result.UserPassword)
					{
						var c = new BuyerMain();
						c._UserName = result.UserName;
						c._UserId = result.UserID;
						c.ShowDialog();
						return;
					}

				}

			}

			MessageBox.Show("帳號或密碼錯誤");
		}
		private void btnRegister_Click(object sender, EventArgs e)
		{
			var c = new BuyerRegister();
			c.Show();
			this.Close();
		}
	

	} 
}
