using System;
using Recurring.NET.Model.Dates;
using Recurring.NET.Model.Parameters.ScheduleType.Base;
using Recurring.NET.Model.Recurring;

namespace Recurring.NET.Model.Parameters.ScheduleType
{
	public class OneTimeScheduleParameters : SpecificScheduleParameters
	{
		protected OneTimeScheduleParameters(string scheduleName, Date occurrenceDate, Time occurrenceTime, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = occurrenceTime;
			Frequency = FrequencyType.OneTimeOnly;
			IsEnabled = isEnabled;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = occurrenceDate;
		}
	}
}