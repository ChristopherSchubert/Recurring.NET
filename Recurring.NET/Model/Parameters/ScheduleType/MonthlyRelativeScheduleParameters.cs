using System;
using Recurring.NET.Model.Dates;
using Recurring.NET.Model.Recurring;
using Recurring.NET.Model.Parameters.ScheduleType.Base;

namespace Recurring.NET.Model.Parameters.ScheduleType
{
	public class MonthlyRelativeScheduleParameters : SpecificScheduleParameters
	{
		public MonthlyRelativeScheduleParameters(string scheduleName, MonthlyRelativeOrdinality ordinality, MonthlyRelativeFrequencyInterval frequency, int occursEveryMonths, Time occurrenceTime, Date startDate, Date? endDate = null, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = occurrenceTime;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			OccursEvery = (int)frequency;
			MonthlyRelativeOrdinality = ordinality;
			RecurrenceFactor = occursEveryMonths;
			ScheduleEnd = endDate;
			ScheduleId = scheduleId ?? Guid.NewGuid();
			ScheduleName = scheduleName;
			ScheduleStart = startDate;
		}

		public MonthlyRelativeScheduleParameters(string scheduleName, MonthlyRelativeOrdinality ordinality, MonthlyRelativeFrequencyInterval frequency, int occursEveryMonths, SubdayParameters subdayParameters, Date startDate, Date? endDate = null, Guid? scheduleId = null, bool isEnabled = true)
		{
			ActiveTimeStart = subdayParameters.StartingAt;
			ActiveTimeEnd = subdayParameters.EndingAt;
			Frequency = FrequencyType.Daily;
			IsEnabled = isEnabled;
			OccursEvery = (int)frequency;
			MonthlyRelativeOrdinality = ordinality;
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
