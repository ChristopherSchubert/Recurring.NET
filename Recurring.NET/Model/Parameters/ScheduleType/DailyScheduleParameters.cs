using System;
using Recurring.NET.Model.Dates;
using Recurring.NET.Model.Recurring;
using Recurring.NET.Model.Parameters.ScheduleType.Base;

namespace Recurring.NET.Model.Parameters.ScheduleType
{
	public sealed class DailyScheduleParameters : SpecificScheduleParameters
	{
		public DailyScheduleParameters(string scheduleName,
		                               int occursEveryDays,
		                               Time occurrenceTime,
		                               Date startDate,
		                               Date endDate = null,
		                               Guid? scheduleId = null,
		                               bool isEnabled = true)
		{
			ActiveTimeStart = occurrenceTime;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			OccursEvery = occursEveryDays;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
		}

		public DailyScheduleParameters(string scheduleName,
		                               int occursEveryDays,
		                               SubdayParameters subdayParameters,
		                               Date startDate,
		                               Date endDate = null,
		                               Guid? scheduleId = null,
		                               bool isEnabled = true)
		{
			ActiveTimeStart = subdayParameters.StartingAt;
			ActiveTimeEnd = subdayParameters.EndingAt;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			OccursEvery = occursEveryDays;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
			SubdayFrequencyType = subdayParameters.FrequencyType;
			SubdayOccursEvery = subdayParameters.OccursEvery;
		}
	}
}

