using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;
using static WinformPoject0527.BuyerShoppingCart;

namespace WinformPoject0527
{
    public partial class BuyerList : Form
    {
		public int _buyconfirmcarid;

		public List<BuyListDto> _BuyList;

		int getuserid;

		int userOrderid;

		public BuyerList()
        {
			this.Load += BuyerList_Load;
            InitializeComponent();
        }

		private void BuyerList_Load(object sender, EventArgs e)
		{
		 dataGridView1.DataSource = _BuyList;
			//用車號找出使用者名字
			var db = new AppDbContext();
			var userid = db.ShoppingCarts
							.AsNoTracking()
							.Where(x => x.CartID == _buyconfirmcarid)
							.SingleOrDefault();
			getuserid = (int)userid.UserID;

			var username = db.Users
						  .AsNoTracking()
						  .Where(x => x.UserID == userid.UserID)
						  .SingleOrDefault();
			txtAccount.Text = username.UserName;
						 
							

		}

		//送出，成立訂單新增資料到Order
		private void button1_Click(object sender, EventArgs e)
		{ 
			var db = new AppDbContext();
			var addNewOrder = new Order()
			{
				UserID = getuserid,

				OrderDate = DateTime.Now,

			};
			db.Orders.Add(addNewOrder);
			db.SaveChanges();

			//新增Orderdetail資料(查詢OrderID)、(查詢OrderID內的ProductID和ProductID的數量)=>查詢Shoppingcartdetail)

			var userOrderID = new AppDbContext()
				         .Orders
						 .AsNoTracking()
						 .Where(x => x.UserID == getuserid)
						 .SingleOrDefault();

			userOrderid = userOrderID.OrderID;

			var ProductsAndQtys =db.ShoppingCartDetails
								.AsNoTracking ()
								.Where(x => x.CartID == _buyconfirmcarid)
								.ToList();

			foreach (var Allproduct in ProductsAndQtys)
			{
				var addOrderdetail = new OrderDetail()
				{
					OrderID = (int)userOrderID.OrderID,

					ProductID = (int)Allproduct.ProductID,

					Quantity = (int)Allproduct.Quantity

				};

				db.OrderDetails.Add(addOrderdetail);
			}			

			db.SaveChanges();

			//將資料新增進shipment(先查產品的sellerID有誰)
			var db2 = new AppDbContext();
			var productsellerids = db2.OrderDetails
								.AsNoTracking()
								.Where(x => x.OrderID == userOrderid)
								.Join(db2.Products.AsNoTracking(), x => x.ProductID, y => y.ProductID, (x, y) => new
								{
									SellerId = y.SellerID,
								})
								.Distinct()
								.ToList();

			foreach (var product in productsellerids) 
			{
				var addShipments = new Shipment()
				{
					OrderID = userOrderid,

					SellerID = product.SellerId,

					ShipmentDate = DateTime.Now,
				};

				db2.Shipments.Add(addShipments);
			}

			db2.SaveChanges();				

			MessageBox.Show("訂單送出成功");
			Close();

            //var c = new BuyerListEnd();
            //c.ShowDialog();
		}
	}
}
