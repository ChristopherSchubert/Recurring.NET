using System;
using Recurring.NET.Model.Dates;
using Recurring.NET.Model.Recurring;

namespace Recurring.NET.Model.Parameters.ScheduleType.Base
{
	public abstract class SpecificScheduleParameters
	{
		public Time ActiveTimeEnd { get; protected set; }

		public Time ActiveTimeStart { get; protected set; }

		public FrequencyType Frequency { get; protected set; }

		public bool IsEnabled { get; set; }

		public int? OccursEvery { get; protected set; }

		public MonthlyRelativeOrdinality? MonthlyRelativeOrdinality { get; protected set; }

		public int? RecurrenceFactor { get; protected set; }

		public Date ScheduleEnd { get; protected set; }

		public Guid ScheduleId { get; set; }

		public string ScheduleName { get; set; }

		public Date ScheduleStart { get; protected set; }

		public SubdayFrequencyType? SubdayFrequencyType{ get; protected set; }

		public int? SubdayOccursEvery { get; protected set; }
	}
}

