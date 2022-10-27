using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_UnitTest
{
	/// <summary>
	/// 檢查股票日期
	/// </summary>
	public class TaiwainStockUtility
	{
		private DateTime input;
		/// <summary>
		/// 檢查股票交易營業日以及時間是不是在營業時間內
		/// </summary>
		/// <param name="dt">傳入時間</param>
		/// <returns>是否有在時間內</returns>
		public bool IsTradingTime(DateTime dt)
		{
			input = dt;

			if (input.DayOfWeek == DayOfWeek.Saturday || input.DayOfWeek == DayOfWeek.Sunday) return false;
			else
			{
				if (input.Hour >= 8 && input.Hour <= 13)
				{
					if (input.Hour == 13)
					{
						if (input.Minute <= 30) return true;
						else return false;
					}
					else return true;
				}
				else return false;
			}
		}
	}
}
