using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exec2_UnitTest;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime set = DateTime.Now;
			DateTime set2 = new DateTime(2022,10 ,25, 12, 30, 11);
			TaiwainStockUtility x = new TaiwainStockUtility();
			bool result = x.IsTradingTime(set);
			bool result2 = x.IsTradingTime(set2);
			Console.WriteLine(result);
			Console.WriteLine(result2);

			Console.Read();
		}
	}
}
