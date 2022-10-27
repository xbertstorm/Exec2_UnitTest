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
		public void Test1_星期六日(DateTime dt, bool expect)
		{
			var x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(dt);

			Assert.AreEqual(expect, result);
		}

		[TestCase("2022-10-24 10:00", true)]
		[TestCase("2022-10-25 10:00", true)]
		[TestCase("2022-10-26 10:00", true)]
		public void Test2_星期一到五(DateTime dt, bool expect)
		{
			var x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(dt);


			Assert.AreEqual(expect, result);
		}

		[TestCase("2022-10-24 8:00", true)]
		[TestCase("2022-10-25 7:59", false)]
		[TestCase("2022-10-26 13:30", true)]
		[TestCase("2022-10-26 13:31", false)]
		public void Test3_星期一到五是否有在規定時間內(DateTime dt, bool expect)
		{
			var x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(dt);


			Assert.AreEqual(expect, result);
		}
	}
}