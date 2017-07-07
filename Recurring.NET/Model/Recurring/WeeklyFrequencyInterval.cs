using System;

namespace Recurring.NET.Model.Recurring
{
	/// <summary>
	/// Weekly frequency interval.
	/// </summary>
	[Flags]
	public enum WeeklyFrequencyInterval
	{
		Sunday = 1,
		Monday = 2,
		Tuesday = 4,
		Wednesday = 8,
		Thursday = 16,
		Friday = 32,
		Saturday = 64
	}
}

