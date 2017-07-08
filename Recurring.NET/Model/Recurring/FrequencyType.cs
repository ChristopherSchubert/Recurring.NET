using System;

namespace Recurring.NET.Model.Recurring
{
	/// <summary>
	/// How frequently an event occurs for this schedule.
	/// </summary>
	public enum FrequencyType
	{
		/// <summary>
		/// The one time only.
		/// </summary>
		OneTimeOnly = 1,
		/// <summary>
		/// Daily.
		/// </summary>
		Daily = 2,
		/// <summary>
		/// Weekly.
		/// </summary>
		Weekly = 3,
		/// <summary>
		/// Monthly.
		/// </summary>
		Monthly = 4,
		/// <summary>
		/// Monthly, relative to a frequency interval value.
		/// </summary>
		MonthlyRelative = 5
	}
}

