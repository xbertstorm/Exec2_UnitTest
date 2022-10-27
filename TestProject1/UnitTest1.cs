using Exec2_UnitTest;

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("2022-10-22 10:00", false)]
		[TestCase("2022-10-23 10:00", false)]
		public void Test1_�P������(DateTime dt, bool expect)
		{
			var x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(dt);

			Assert.AreEqual(expect, result);
		}

		[TestCase("2022-10-24 10:00", true)]
		[TestCase("2022-10-25 10:00", true)]
		[TestCase("2022-10-26 10:00", true)]
		public void Test2_�P���@�줭(DateTime dt, bool expect)
		{
			var x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(dt);


			Assert.AreEqual(expect, result);
		}

		[TestCase("2022-10-24 8:00", true)]
		[TestCase("2022-10-25 7:59", false)]
		[TestCase("2022-10-26 13:30", true)]
		[TestCase("2022-10-26 13:31", false)]
		public void Test3_�P���@�줭�O�_���b�W�w�ɶ���(DateTime dt, bool expect)
		{
			var x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(dt);


			Assert.AreEqual(expect, result);
		}
	}
}