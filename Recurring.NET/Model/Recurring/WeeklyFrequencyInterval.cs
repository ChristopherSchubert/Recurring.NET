using System;

namespace Recurring.NET.Model.Recurring
{
	/// <summary>
	/// Weekly frequency interval.
	/// </summary>
	public enum WeeklyFrequencyInterval
	{
		Unused = 0,
		Sunday = 1,
		Monday = 2,
		Tuesday = 4,
		Wednesday = 8,
		Thursday = 16,
		Friday = 32,
		Saturday = 64
	}
}

