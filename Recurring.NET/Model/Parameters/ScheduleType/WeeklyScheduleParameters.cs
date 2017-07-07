using System;
using Recurring.NET.Model.Dates;
using Recurring.NET.Model.Recurring;
using Recurring.NET.Model.Parameters.ScheduleType.Base;

namespace Recurring.NET.Model.Parameters.ScheduleType
{
	public class WeeklyScheduleParameters : SpecificScheduleParameters
	{
		protected WeeklyScheduleParameters(string scheduleName, int occursEveryWeeks, WeeklyFrequencyInterval occursOn, Time occurrenceTime, Date startDate, Date? endDate = null, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = occurrenceTime;
			OccursEvery = (int)occursOn;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			RecurrenceFactor = occursEveryWeeks;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
		}

		protected WeeklyScheduleParameters(string scheduleName, int occursEveryWeeks, WeeklyFrequencyInterval occursOn, SubdayParameters subdayParameters, Date startDate, Date? endDate = null, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = subdayParameters.StartingAt;
			ActiveTimeEnd = subdayParameters.EndingAt;
			OccursEvery = (int)occursOn;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			RecurrenceFactor = occursEveryWeeks;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
			SubdayFrequencyType = subdayParameters.FrequencyType;
			SubdayOccursEvery = subdayParameters.OccursEvery;			
		}
	}
}

