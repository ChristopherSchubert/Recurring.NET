using System;
using Recurring.NET.Model.Dates;
using Recurring.NET.Model.Parameters.ScheduleType.Base;
using Recurring.NET.Model.Recurring;

namespace Recurring.NET.Model.Parameters.ScheduleType
{
	public class MonthlyScheduleParameters : SpecificScheduleParameters
	{
		public MonthlyScheduleParameters(string scheduleName, int dayOfMonth, int occursEveryMonths, Time occurrenceTime, Date startDate, Date? endDate = null, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = occurrenceTime;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			OccursEvery = dayOfMonth;
			RecurrenceFactor = occursEveryMonths;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
		}

		public MonthlyScheduleParameters(string scheduleName, int dayOfMonth, int occursEveryMonths, SubdayParameters subdayParameters, Date startDate, Date? endDate = null, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = subdayParameters.StartingAt;
			ActiveTimeEnd = subdayParameters.EndingAt;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			OccursEvery = dayOfMonth;
			RecurrenceFactor = occursEveryMonths;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
			SubdayFrequencyType = subdayParameters.FrequencyType;
			SubdayOccursEvery = subdayParameters.OccursEvery;		
		}
	}
}

