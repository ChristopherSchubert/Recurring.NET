using System;

namespace Recurring.NET.Model.Recurring
{
	/// <summary>
	/// The frequency type that a schedule occuring multiple times a day occurs.
	/// </summary>
	public enum SubdayFrequencyType
	{
		/// <summary>
		/// The unit is seconds.
		/// </summary>
		Seconds = 1,
		/// <summary>
		/// The unit is minutes.
		/// </summary>
		Minutes = 2,
		/// <summary>
		/// The unit is hours.
		/// </summary>
		Hours = 3
	}
}

