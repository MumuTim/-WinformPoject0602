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
    public partial class BuyerRegister : Form
    {
        public BuyerRegister()
        {
            InitializeComponent();
        }

	

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text;
			string password = txtPassword.Text;
			string name = txtName.Text;

			if (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(name))
			{

				var db = new AppDbContext();
				var user = new User()
				{
					UserAccount = account,
					UserName = name,
					UserPassword = password,
				};

				db.Users.Add(user);
				db.SaveChanges();

				var result = new AppDbContext()
						.Users
						.AsNoTracking()
						.Where(x => x.UserAccount == account)
						.SingleOrDefault();

				var c = new BuyerMain();
				c._UserId = result.UserID;
				c._UserName = result.UserName;
				c.ShowDialog();
				MessageBox.Show("註冊成功");
				Close();

			}
			else 
			{
				MessageBox.Show("欄位有缺，請補齊");
			}
			
		}
	}
}
