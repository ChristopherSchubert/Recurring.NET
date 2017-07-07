using System;

namespace Recurring.NET.Model
{
	public class ScheduleModel
	{
		public Guid ScheduleId { get; set; }

		public string ScheduleName { get; set; }

		public bool IsEnabled { get; set; }

		public int FrequencyType { get; set; }

		public int? FrequencyInterval { get; set; }

		public int? SubdayFrequencyType { get; set; }

		public int SubdayOccursEvery { get; set; }

		public int? RelativeInterval { get; set; }

		public int? RecurrenceFactor { get; set; }

		public long ScheduleStartDateEpoch { get; set; }

		public long? ScheduleEndDateEpoch { get; set; }

		public int ActiveTimeStartSeconds { get; set; }

		public int ActiveTimeEndSeconds { get; set; }
	}
}
