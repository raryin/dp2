using System;
using NUnit.Framework;

namespace DP2PHPClient
{
	[TestFixture ()]
	public class UnitTests
	{
		[Test ()]
		public void TestAddSalesRecord ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);
			p.InsertStock("Orange",0.7,1.5,100);
			p.InsertStock("Banana",0.65,1.2,100);

			//List<ItemSale> s = new List<ItemSale>;

			//Assert.IsTrue(p.AddNewReceipt(0,s));
		}

		[Test ()]
		public void TestDeleteSalesRecord ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);
			p.InsertStock("Orange",0.7,1.5,100);
			p.InsertStock("Banana",0.65,1.2,100);

			//List<ItemSale> s = new List<ItemSale>;

			//p.AddNewReceipt(0,s);
			//Assert.IsTrue(p.DeleteReceipt(s.GetSaleID()));
		}

		[Test ()]
		public void TestEditSalesRecord ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());
		}

		[Test ()]
		public void TestDisplaySalesRecord ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			//Assert.IsTrue(p.DisplayReceipt(0));
		}

		[Test ()]
		public void TestAddStockItem ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			Assert.IsTrue(p.InsertStock("Apple",0.5,1,100));
		}

		[Test ()]
		public void TestEditStockItem ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);

			//Assert.IsTrue(p.ModifyStock());


		}
	}
}
