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
		Daily = 4,
		/// <summary>
		/// Weekly.
		/// </summary>
		Weekly = 8,
		/// <summary>
		/// Monthly.
		/// </summary>
		Monthly = 16,
		/// <summary>
		/// Monthly, relative to a <see cref="Recurring.NET.Model.Schedule"/>'s <see cref="FrequencyInterval"/> value.
		/// </summary>
		MonthlyRelative = 32,
		/// <summary>
		/// Immediately upon being evaluated.
		/// </summary>
		Immediate = 64
	}
}

