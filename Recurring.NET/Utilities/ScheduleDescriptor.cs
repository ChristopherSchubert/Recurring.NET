using System;
using Recurring.NET.Model;
using Recurring.NET.Model.Recurring;
using System.Text;
using Recurring.NET.Model.Parameters;
using System.Globalization;

namespace Recurring.NET.Utilities
{
	public class ScheduleDescriptor
	{
		
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

		private string DescribeOneTimeOnlySchedule(Schedule schedule)
		{
			return string.Format("Occurs once on {0} at {1}.", schedule.ScheduleStart, schedule.ActiveTimeStart);
		}

		private string DescribeDailySchedule(Schedule schedule)
		{
			return string.Empty;
		}

		private string DescribeWeeklySchedule(Schedule schedule)
		{
			return string.Empty;
		}

		private string DescribeMonthlySchedule(Schedule schedule)
		{
			return string.Empty;
		}

		private string DescribeMonthlyRelativeSchedule(Schedule schedule)
		{
			return string.Empty;
		}
	}
}

