using System;

namespace Recurring.NET.Model.Recurring
{
	/// <summary>
	/// When a monthly relative schedule should recur in each month.
	/// </summary>
	[Flags]
	public enum MonthlyRelativeOrdinality
	{
		/// <summary>
		/// The first occurrence of the month.
		/// </summary>
		First = 1,
		/// <summary>
		/// The second occurrence of the month.
		/// </summary>
		Second = 2,
		/// <summary>
		/// The third occurrence of the month.
		/// </summary>
		Third = 4,
		/// <summary>
		/// The fourth occurrence of the month.
		/// </summary>
		Fourth = 8,
		/// <summary>
		/// The last occurrence of the month.
		/// </summary>
		Last = 16
	}
}

