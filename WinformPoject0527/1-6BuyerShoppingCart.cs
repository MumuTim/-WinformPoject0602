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
using static WinformPoject0527.BuyerMain;

namespace WinformPoject0527
{
    public partial class BuyerShoppingCart : Form 
    {
		 List<BuyListDto> buydatashow;

		public int _CarID;

		public class BuyListDto
		{
			public int ProductID { get; set; }
			public string ProductName { get; set; }

			public int Qty { get; set; }
			public decimal ProductPrice { get; set; }

			public decimal ProductTotalPrice { get; set; }
		}

		public BuyerShoppingCart()
        {
			this.Load += BuyerShoppingCart_Load;
            InitializeComponent();
        }

		//載入購物車ID的購物內容，(先查出所有車內(carid)的ProductID，再去join產品內的其他欄位)
		private void BuyerShoppingCart_Load(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			var db = new AppDbContext();
			var productIds = db.ShoppingCartDetails.AsNoTracking()
							.Where(x => x.CartID == _CarID)
							.Join(db.Products.AsNoTracking(), x => x.ProductID, y => y.ProductID, (x, y) => new
							{
								ProductID = x.ProductID,
								ProductName = y.ProductName,
								Quantity = x.Quantity,
								ProductPrice = y.ProductPrice
							})
							.ToList();
			buydatashow = productIds.Select(x => new BuyListDto
			{

				ProductID = (int)x.ProductID,
				ProductName = x.ProductName,
				Qty = (int)x.Quantity,
				ProductPrice = (decimal)x.ProductPrice,
				ProductTotalPrice = (decimal)x.ProductPrice * (int)x.Quantity
			}).ToList();
			this.dataGridView1.DataSource = buydatashow;
		}


		private void btnPay_Click(object sender, EventArgs e)
		{
            var c = new BuyerList();
			c._buyconfirmcarid = _CarID;
			c._BuyList = buydatashow;
			c.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int id = this.buydatashow[e.RowIndex].ProductID;
			var c = new BuyerEdit(id);
			c._carEditid = _CarID;
			c.Owner = this;
			c.ShowDialog();
		}

		
	}
}
