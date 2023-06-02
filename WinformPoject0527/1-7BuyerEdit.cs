using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
	public partial class BuyerEdit : Form

	{
		public int _carEditid;

		private readonly int _ProductId;
		public BuyerEdit(int ProductID)
		{
			_ProductId = ProductID;
			InitializeComponent();
			this.Load += BuyerEdit_Load;
		}

		//載入此商品資料
		private void BuyerEdit_Load(object sender, EventArgs e)
		{
			//var db = new AppDbContext();
			//var data =db.ShoppingCartDetails
			//				.AsNoTracking()
			//				.Where(x => x.ProductID == _ProductId)
			//				.SingleOrDefault();
			//if (data == null)
			//{
			//	MessageBox.Show("目前查無此商品");
			//	return;
			//}
			//this.txtName.Text = data.ProductName;
			//price = (decimal)data.ProductPrice;
			//this.txtPrice.Text = price.ToString();
		}

	}
}
