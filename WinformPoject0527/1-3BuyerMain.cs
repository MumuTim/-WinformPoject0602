using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinformPoject0527.BuyerLogin;

namespace WinformPoject0527
{
    public partial class BuyerMain : Form
    {

		List<BuyerMainDto> datashow ;

		public int _UserId;//將登入者ID傳入
		public string _UserName; //將登入者Name傳入
		public BuyerMain()
        {
			this.Load += BuyerMain_Load1;
            InitializeComponent();
        }

		public class BuyerMainDto
		{
			public int ProductID { get; set; }
			public string ProductName { get; set; }
			public string ProductDescription { get; set; }
			public decimal ProductPrice { get; set; }
		}

		 
		private void BuyerMain_Load1(object sender, EventArgs e)
		{
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//將欄位設成只能拉選不能輸入
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;//將欄位設成只能拉選不能輸入

			labLoginName.Text = "親愛的 "+_UserName+" 您好";
			//找出所有商品資料
			var db = new AppDbContext()
						.Products
						.Where(x => x.ProductID > 0)
						.ToList();

			datashow = db.Select(x => new BuyerMainDto {
								ProductID = x.ProductID,
								ProductName = x.ProductName,
								ProductDescription = x.ProductDescription,
								ProductPrice = (decimal)x.ProductPrice,
							})
							.ToList();
			this.dataGridView1.DataSource = datashow;
			//用大分類ID將所有大分類名稱找出
			var data2 = new AppDbContext()
						.ProductCategories
						.AsNoTracking()
						.Where(x => x.ParentCategoryID == null)
						.ToList();
			var data2CategorydNames = data2.Select(x => x.CategoryName).ToList();
			//將combobox的選項清空，並將找到名稱加進去
			comboBox1.Items.Clear();
			comboBox1.Items.AddRange(data2CategorydNames.Select(id => (object)id).ToArray());



		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int id = this.datashow[e.RowIndex].ProductID;
			var a = new BuyerAdd(id);
			a._BuyAddId = _UserId;
			a.Owner = this;
			a.ShowDialog();

		}

		private void btnIntoMember_Click(object sender, EventArgs e)
		{
			var c = new BuyerRegisterEdit();
			c.ShowDialog();
		}

		private void btnIntoBuyList_Click(object sender, EventArgs e)
		{
			var c = new BuyerListAll();
			c.ShowDialog();
		}

		//先找有沒有車，有車才進入，沒車跳訊息
		private void btnIntoCar_Click(object sender, EventArgs e)
		{
			var ifhascar = new AppDbContext()
						.ShoppingCarts
						.AsNoTracking()
						.Where(x => x.UserID == _UserId)
						.SingleOrDefault();
			if (ifhascar == null) 
			{
				MessageBox.Show("目前購物車無商品");
				return;
			}
			
			var c = new BuyerShoppingCart();
			c._CarID = ifhascar.CartID;
			c.ShowDialog();
		}

		//主分類combobox被選取後觸發事件
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//將選中的主分類名稱找出
			string qq = comboBox1.SelectedItem.ToString();
			var data3CategoryName = new AppDbContext()
						.ProductCategories
						.AsNoTracking()
						.Where(x => x.CategoryName == qq)
						.ToList();
			//將名稱轉成對應的CategoryID(只會有一筆)
			var data3CategoryID = data3CategoryName.Select(x => x.CategoryID)
													.SingleOrDefault()
													.ToString();
			//將ProductCategories裡面符合剛剛找到的CategoryID，利用join，將Products內相同CategoryID的其他欄位抓出來
			var db = new AppDbContext();
			var data = db.ProductCategories.AsNoTracking()
							.Where(x => x.ParentCategoryID == data3CategoryID)
							.Join(db.Products.AsNoTracking(), x => x.CategoryID, y => y.CategoryID, (x, y) => new
								{
									ProductID = y.ProductID,
									ProductName = y.ProductName,
									ProductDescription = y.ProductDescription,
									ProductPrice = (decimal)y.ProductPrice
								})
							.ToList();
								
			datashow = data.Select(x => new BuyerMainDto {
				ProductID = x.ProductID,
				ProductName = x.ProductName,
				ProductDescription = x.ProductDescription,
				ProductPrice = (decimal)x.ProductPrice,
			})
				.ToList();

			this.dataGridView1.DataSource = datashow;

			//用選中的主分類CategoryID來搜尋所有相對應的子分類的內容
			var data4 = new AppDbContext()
						.ProductCategories
						.AsNoTracking()
						.Where(x => x.ParentCategoryID == data3CategoryID)
						.ToList();
			var data4CategorydNames = data4.Select(x => x.CategoryName).ToList();
			comboBox2.Items.Clear();
			comboBox2.Items.AddRange(data4CategorydNames.Select(id => (object)id).ToArray());


		}
		//子分類combobox被選取後觸發事件
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			//將選中的子分類名稱找出
			string pp = comboBox2.SelectedItem.ToString();
			var data5CategoryName = new AppDbContext()
						.ProductCategories
						.AsNoTracking()
						.Where(x => x.CategoryName == pp)
						.ToList();
			//將名稱轉成對應的CategoryID(會有很多筆ID但都是同一個ID值)
			var data5CategoryID = data5CategoryName.Select(x => x.CategoryID)
													.FirstOrDefault()
													.ToString();


			//將符合條件的CategoryID抓出來
			var db = new AppDbContext()
				        .Products
						.Where(x => x.CategoryID == data5CategoryID)
						.ToList();
			datashow = db.Select(x => new BuyerMainDto
			{
				ProductID = x.ProductID,
				ProductName = x.ProductName,
				ProductDescription = x.ProductDescription,
				ProductPrice = (decimal)x.ProductPrice,
			})
				.ToList();
			this.dataGridView1.DataSource = datashow;
		}
	}
}
