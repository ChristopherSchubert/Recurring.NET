using System;
using Recurring.NET.Model;
using Recurring.NET.Model.Recurring;
using System.Text;
using Recurring.NET.Model.Parameters;
using System.Globalization;
using Recurring.NET.Model.Dates;

namespace Recurring.NET.Utilities
{
	public class ScheduleDescriptor
	{
		private const string OneTimeScheduleFormat = @"Occurs once on {0} at {1}.";
		private const string SubdayComponentFormat = @"every {0} {1}{2}{3}";
		private static readonly Time DefaultStartTime = new Time(0, 0, 0);
		private static readonly Time DefaultEndTime = new Time(23, 59, 59, 999);

		public string DescribeSchedule(Schedule schedule)
		{
			switch (schedule.FrequencyType)
			{
			case FrequencyType.OneTimeOnly:
				return DescribeOneTimeOnlySchedule(schedule);
			case FrequencyType.Daily:
				return DescribeDailySchedule(schedule);
			case FrequencyType.Weekly:
				return DescribeWeeklySchedule(schedule);
			case FrequencyType.Monthly:
				return DescribeMonthlySchedule(schedule);
			case FrequencyType.MonthlyRelative:
				return DescribeMonthlyRelativeSchedule(schedule);
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		private static string DescribeOneTimeOnlySchedule(Schedule schedule)
		{
			return string.Format(OneTimeScheduleFormat, schedule.ScheduleStart, schedule.ActiveTimeStart);
		}

		private static string DescribeDailySchedule(Schedule schedule)
		{
			return string.Format("Occurs every {0} days");
		}

		private static string DescribeWeeklySchedule(Schedule schedule)
		{
			return string.Empty;
		}

		private static string DescribeMonthlySchedule(Schedule schedule)
		{
			return string.Empty;
		}

		private static string DescribeMonthlyRelativeSchedule(Schedule schedule)
		{
			return string.Empty;
		}

		private static string DescribeSubdayComponent(int subdayOccursEvery, SubdayFrequencyType subdayFrequencyType, Time startingAt, Time endingAt)
		{
			return string.Empty;
			/*
			 * return string.Format(SubdayComponentFormat, subdayOccursEvery, subdayFrequencyType.ToString().ToLower(), 
				startingAt == DefaultStartTime ? string.Empty : string.Format(" starting at {0}");
			*/
		}
	}
}

