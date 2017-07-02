using System;

namespace Recurring.NET.Model.Recurring
{
	/// <summary>
	/// Unit for the <seealso cref="Recurring.NET.Model.Schedule"/>'s <see cref="Recurring.NET.Model.Schedule.FrequencySubdayInterval"/>.
	/// </summary>
	public enum FrequencySubdayType
	{
		/// <summary>
		/// At the specified time.
		/// </summary>
		AtTheSpecifiedTime = 1,
		/// <summary>
		/// The unit is seconds.
		/// </summary>
		Seconds = 2,
		/// <summary>
		/// The unit is minutes.
		/// </summary>
		Minutes = 4,
		/// <summary>
		/// The unit is hours.
		/// </summary>
		Hours = 8
	}
}

