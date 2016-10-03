using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DP2PHPClient
{
	[TestFixture ()]
	public class UnitTests
	{
		[Test ()]
		public void TestAddReceipt ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.DeleteReceipt(-1);
            p.DeleteStock(-1);

			p.InsertStock("Apple",0.5,1,100);
			p.InsertStock("Orange",0.7,1.5,100);
			p.InsertStock("Banana",0.65,1.2,100);

			int lenStock = p.RequestStockInfo(-1).Count - 1;

            List<StockRecord> records = p.RequestStockInfo(-1);
            StockRecord aRecord = records[lenStock];
			StockRecord bRecord = records[lenStock-1];
			StockRecord cRecord = records[lenStock-2];

			ItemSaleRecord a = new ItemSaleRecord(0,aRecord.StockID,1,1);
			ItemSaleRecord b = new ItemSaleRecord(0,bRecord.StockID,1.5,2);
			ItemSaleRecord c = new ItemSaleRecord(0,cRecord.StockID,1.2,1);


			List<ItemSaleRecord> s = new List<ItemSaleRecord>();
			s.Add(a);
			s.Add(b);
			s.Add(c);

			Assert.IsTrue(p.InsertReceipt(s));


			int lenReceiptNew = p.RequestReceiptInfo(-1).Count - 1;
			//ReceiptRecord lastReceipt = (ReceiptRecord)p.RequestReceiptInfo(-1)[lenReceiptNew];
			Assert.IsTrue(p.RequestReceiptInfo(-1).Count == 1);
		}

		[Test ()]
		public void TestDeleteReceipt ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);
			p.InsertStock("Orange",0.7,1.5,100);
			p.InsertStock("Banana",0.65,1.2,100);

			int lenReceipt = p.RequestStockInfo(-1).Count - 1;

			StockRecord aRecord = p.RequestStockInfo(-1)[lenReceipt];
			StockRecord bRecord = p.RequestStockInfo(-1)[lenReceipt-1];
			StockRecord cRecord = p.RequestStockInfo(-1)[lenReceipt-2];

			ItemSaleRecord a = new ItemSaleRecord(0,aRecord.StockID,1,1);
			ItemSaleRecord b = new ItemSaleRecord(0,bRecord.StockID,1.5,2);
			ItemSaleRecord c = new ItemSaleRecord(0,cRecord.StockID,1.2,1);


			List<ItemSaleRecord> s = new List<ItemSaleRecord>();
			s.Add(a);
			s.Add(b);
			s.Add(c);

			Assert.IsTrue(p.InsertReceipt(s));


			int lenReceiptNew = p.RequestReceiptInfo(-1).Count - 1;

			ReceiptRecord aReceipt = (ReceiptRecord)p.RequestReceiptInfo(-1)[lenReceiptNew];

			Assert.IsTrue(p.DeleteReceipt(aReceipt.SaleID));

			int lenReceiptDeleted = p.RequestReceiptInfo(-1).Count - 1;
			Assert.IsFalse(lenReceiptNew==lenReceiptDeleted);

			ReceiptRecord lastReceipt = (ReceiptRecord)p.RequestReceiptInfo(-1)[lenReceiptDeleted];
			Assert.IsFalse(lastReceipt.SaleID==aReceipt.SaleID);

			                             
		}

		[Test ()]
		public void TestEditReceipt ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);
			p.InsertStock("Orange",0.7,1.5,100);
			p.InsertStock("Banana",0.65,1.2,100);

			int lenReceipt = p.RequestStockInfo(-1).Count - 1;

			StockRecord aRecord = p.RequestStockInfo(-1)[lenReceipt];
			StockRecord bRecord = p.RequestStockInfo(-1)[lenReceipt-1];
			StockRecord cRecord = p.RequestStockInfo(-1)[lenReceipt-2];

			ItemSaleRecord a = new ItemSaleRecord(0,aRecord.StockID,1,1);
			ItemSaleRecord b = new ItemSaleRecord(0,bRecord.StockID,1.5,2);
			ItemSaleRecord c = new ItemSaleRecord(0,cRecord.StockID,1.2,1);


			List<ItemSaleRecord> s = new List<ItemSaleRecord>();
			s.Add(a);
			s.Add(b);
			s.Add(c);

			Assert.IsTrue(p.InsertReceipt(s));

			int lenReceiptNew = p.RequestReceiptInfo(-1).Count - 1;

			ReceiptRecord aReceipt = (ReceiptRecord)p.RequestReceiptInfo(-1)[lenReceiptNew];

			Assert.IsTrue(p.UpdateReceipt(aReceipt.SaleID));

		}

		[Test ()]
		public void TestDisplayReceipt ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);
			p.InsertStock("Orange",0.7,1.5,100);
			p.InsertStock("Banana",0.65,1.2,100);

			int lenReceipt = p.RequestStockInfo(-1).Count - 1;

			StockRecord aRecord = p.RequestStockInfo(-1)[lenReceipt];
			StockRecord bRecord = p.RequestStockInfo(-1)[lenReceipt-1];
			StockRecord cRecord = p.RequestStockInfo(-1)[lenReceipt-2];

			ItemSaleRecord a = new ItemSaleRecord(0,aRecord.StockID,1,1);
			ItemSaleRecord b = new ItemSaleRecord(0,bRecord.StockID,1.5,2);
			ItemSaleRecord c = new ItemSaleRecord(0,cRecord.StockID,1.2,1);


			List<ItemSaleRecord> s = new List<ItemSaleRecord>();
			s.Add(a);
			s.Add(b);
			s.Add(c);

			Assert.IsTrue(p.InsertReceipt(s));

            List<Record> records = p.RequestReceiptInfo(-1);
            int length = records.Count - 1;
            int lenReceiptNew = ((ReceiptRecord)records[length]).SaleID;
            Assert.IsTrue(p.DisplayReceipt(lenReceiptNew));
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
			StockRecord lid = p.RequestStockInfo(-1)[0];

			Assert.IsTrue(p.UpdateStock(lid));


		}
		[Test ()]
		public void TestDeleteStockItem ()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());

			p.InsertStock("Apple",0.5,1,100);
			StockRecord lid = p.RequestStockInfo(-1)[0];

			Assert.IsTrue(p.DeleteStock(lid.StockID));


		}
		
		
		
		
		//SPRINT 2
		[Test ()]
		public void TestPredictNextMonthSales()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());
			
			List<int> s = new List<int>();
			s.Add(1);
			s.Add(2);
			s.Add(3);
			double t = p.PredictNextMonthSales(s);
			Assert.IsTrue(t.Equals(0));
		}
		
		[Test ()]
		public void TestPredictNextMonthProfit()
		{
			ClientConnectionManager p = new ClientConnectionManager("127.0.0.1",25565);
			Assert.IsTrue(p.ConnectToServer());
			
			List<int> s = new List<int>();
			s.Add(1);
			s.Add(2);
			s.Add(3);
			double t = p.PredictNextMonthProfit(s);
			Assert.IsTrue(t.Equals(0));
		}
	}
}
