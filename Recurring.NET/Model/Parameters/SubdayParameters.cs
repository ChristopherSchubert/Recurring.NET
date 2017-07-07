using Recurring.NET.Model.Recurring;
using Recurring.NET.Model.Dates;

namespace Recurring.NET.Model.Parameters
{
	public class SubdayParameters
	{
		public SubdayParameters(SubdayFrequencyType subdayFrequencyType, int occursEvery, Time? startingAt = null, Time? endingAt = null)
		{
			EndingAt = endingAt ?? new Time(23, 59, 59, 999);
			FrequencyType = subdayFrequencyType;
			OccursEvery = occursEvery;
			StartingAt = startingAt ?? new Time(0, 0, 0);
		}

		public SubdayFrequencyType FrequencyType{ get; set; }

		public int OccursEvery { get; set; }

		public Time StartingAt { get; set; }

		public Time EndingAt { get; set; }
	}
}

