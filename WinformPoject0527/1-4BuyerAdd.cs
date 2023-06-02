using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class BuyerAdd : Form
    {
        public int _BuyAddId;

		private readonly int _ProductId;

		int qty = 1;

		decimal price = 0;

		int _carid;

		 
		public BuyerAdd(int PruductID)
        {
            _ProductId = PruductID;

			InitializeComponent();
			this.Load += BuyerAdd_Load;
        }

		private void BuyerAdd_Load(object sender, EventArgs e)
		{
			var data = new AppDbContext()
							.Products
							.AsNoTracking()
							.Where(x => x.ProductID == _ProductId)
							.SingleOrDefault();
			if (data == null)
			{
				MessageBox.Show("目前查無此商品");
				return;
			}
			this.txtName.Text = data.ProductName;
						price = (decimal)data.ProductPrice;
			this.txtPrice.Text = price.ToString();
		}

		private void labSub_Click(object sender, EventArgs e)
		{
			qty = Int32.Parse(txtQty.Text);

			if (qty > 1)
			{
				txtQty.Text = (qty - 1).ToString();
				txtPrice.Text = (price * (qty-1)).ToString();
			}
			else 
			{
				qty = 1;
				txtQty.Text = qty.ToString();
				MessageBox.Show("至少購買一個商品");
				txtPrice.Text = (price * qty).ToString();
			}
			
		}

		private void labAdd_Click(object sender, EventArgs e)
		{

			qty = Int32.Parse(txtQty.Text);

			if (qty >= 1)
			{
				txtQty.Text = (qty + 1).ToString();
				txtPrice.Text = (price * (qty+1)).ToString();
			}
			else 
			{
				qty = 1;
				txtQty.Text = qty.ToString();
				MessageBox.Show("至少購買一個商品");
				txtPrice.Text = (price * qty).ToString();
			}
			
		}

		private void btnAddIntoCar_Click(object sender, EventArgs e)
		{
			if (qty < 1) 
			{
				MessageBox.Show("至少購買一個商品");
				return;
			}
			//找出車ID，若沒有車，新增車
			var ifhascar = new AppDbContext()
						.ShoppingCarts
						.AsNoTracking()
						.Where(x => x.UserID == _BuyAddId)
						.SingleOrDefault();
			
			if (ifhascar == null) 
			{
				var db = new AppDbContext();
				var newcar = new ShoppingCart()
				{
					UserID = _BuyAddId,
				};

				db.ShoppingCarts .Add(newcar);
				db.SaveChanges();
	
			}
			var hascar = new AppDbContext()
						.ShoppingCarts
						.AsNoTracking()
						.Where(x => x.UserID == _BuyAddId)
						.SingleOrDefault();

			_carid = hascar.CartID;

			//將資料塞進車(先查車內有沒有資料，若有就Update，沒有則新增)
			var ifproductincar = new AppDbContext()
							.ShoppingCartDetails
							.AsNoTracking()
							.Where(c => c.ProductID == _ProductId)
							.SingleOrDefault()
							;
			
			//如果沒有資料
			if (ifproductincar == null)
			{
				//新增資料進車
				var db2 = new AppDbContext();
				var intocar = new ShoppingCartDetail()
				{
					CartID = _carid,
					ProductID = _ProductId,
					Quantity = Int32.Parse(txtQty.Text)
				};

				db2.ShoppingCartDetails.Add(intocar);
				db2.SaveChanges();
				this.Close();
			}
			else 
			{
				int cardetailid = ifproductincar.CartDetailID;
				//總數量=車內+現在
				int newproductqty = (int)(ifproductincar.Quantity + qty);
				//如果有資料則修改數量(先抓出裡面數量，將此次數量加上去後，存回資料裡面)

				//進行Update
				var db3 = new AppDbContext();
			var qtyupdate = db3.ShoppingCartDetails
							 .Find(cardetailid);
			qtyupdate.Quantity = newproductqty;
			db3.SaveChanges();
				Close();
			}

		}
	}
}
