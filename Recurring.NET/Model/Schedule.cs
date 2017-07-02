using System;

namespace Recurring.NET.Model
{
	/// <summary>
	/// Encapsulates information about an event's scheduling details.
	/// </summary>
	public sealed class Schedule
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Recurring.NET.Model.Schedule"/> class.
		/// </summary>
		internal Schedule()
		{
		}

		/// <summary>
		/// Gets the schedule identifier.
		/// </summary>
		/// <value>The schedule identifier.</value>
		public Guid ScheduleId { get; private set; }

		/// <summary>
		/// Gets or sets the name of the schedule.
		/// </summary>
		/// <value>The name of the schedule.</value>
		public string ScheduleName{ get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this schedule is enabled.
		/// </summary>
		/// <value><c>true</c> if this schedule is enabled; otherwise, <c>false</c>.</value>
		public bool IsEnabled{ get; set; }

		/// <summary>
		/// Gets or sets how frequently an event would occur for this schedule.
		/// </summary>
		/// <value>The frequency type.</value>
		public FrequencyType FrequencyType{ get; private set; }

		/// <summary>
		/// Gets or sets the frequency interval.  This value's interpretation changes based on the <see cref="FrequencyType"/>.
		/// If the <see cref="FrequencyType"/> is <c>FrequencyType.OneTimeOnly</c>, this value is unused.
		/// If the <see cref="FrequencyType"/> is <c>FrequencyType.Daily</c>, this value represents a 'every X days' recurrence.
		/// If the <see cref="FrequencyType"/> is <c>FrequencyType.Weekly</c>, this value maps to <see cref="WeeklyInterval"/>.
		/// If the <see cref="FrequencyType"/> is <c>FrequencyType.Monthly</c>, this value represents an 'on the X day of the month' reccurrence.
		/// If the <see cref="FrequencyType"/> is <c>FrequencyType.MonthlyRelative</c>, this value maps to <see cref="MonthlyRelativeInterval"/>.
		/// If the <see cref="FrequencyType"/> is <c>FrequencyType.Immediate</c>, this value is unused.
		/// </summary>
		/// <seealso cref="Recurring.NET.Model.Recurring.FrequencyType"/>
		/// <seealso cref="Recurring.NET.Model.Recurring.WeeklyFrequencyInterval"/>
		/// <seealso cref="Recurring.NET.Model.Recurring.MonthlyRelativeFrequencyInterval"/>
		/// <value>The frequency internval.</value>
		public int FrequencyInterval { get; private set; }

		/// <summary>
		/// When <see cref="FrequencyType"/> is <c>FrequencyType.MonthlyRelative</c>, this will expose the relevant value.
		/// </summary>
		/// <seealso cref="Recurring.NET.Model.Recurring.FrequencyType"/>
		/// <value>The monthly relative interval.</value>
		public MonthlyRelativeFrequencyInterval MonthlyRelativeInterval
		{
			get
			{
				if (FrequencyType != FrequencyType.MonthlyRelative)
				{
					return MonthlyRelativeFrequencyInterval.Unused;
				} 
			
				return (MonthlyRelativeFrequencyInterval)FrequencyInterval;
			}
		}

		/// <summary>
		/// When <see cref="FrequencyType"/> is <c>FrequencyType.Weekly</c>, this will expose the relevant value.
		/// </summary>
		/// <seealso cref="Recurring.NET.Model.Recurring.FrequencyType"/> 
		/// <value>The weekly interval.</value>
		public WeeklyFrequencyInterval WeeklyInterval 
		{
			get
			{
				if (FrequencyType != FrequencyType.Weekly)
				{
					return WeeklyFrequencyInterval.Unused;
				} 

				return (WeeklyFrequencyInterval)FrequencyInterval;
			}
		}

		/// <summary>
		/// Gets or sets the type of the subday recurrence.
		/// </summary>
		/// <value>The type of the subday.</value>
		public FrequencySubdayType SubdayType{ get; private set; }

		/// <summary>
		/// Gets or sets the subday interval, which represents the number of <see cref="SubdayType"/> periods to occur between each recurrence.
		/// </summary>
		/// <seealso cref="Recurring.NET.Model.Recurring.FrequencySubdayType"/>
		/// <value>The subday interval.</value>
		public int SubdayInterval { get; private set; }

		/// <summary>
		/// Gets or sets the relative interval.  When the <see cref="FrequencyInterval"/> occurs in each month, if the <see cref="FrequencyType"/> is <c>FrequencyType.MonthlyRelative</c>.
		/// </summary>
		/// <seealso cref="Recurring.NET.Model.Recurring.FrequencyType"/>
		/// <value>The relative interval.</value>
		public FrequencyRelativeInterval RelativeInterval { get; private set; }

		/// <summary>
		/// Gets or sets the number of weeks or months between recurrences.  Only used if the <see cref="FrequencyType"/> is <c>FrequencyType.Weekly</c>, <c>FrequencyType.Monthly</c>, or <c>FrequencyType.MonthlyRelative</c>.
		/// </summary>
		/// <seealso cref="Recurring.NET.Model.Recurring.FrequencyType"/>
		/// <value>The recurrence factor.</value>
		public int RecurrenceFactor{ get; private set; }

		/// <summary>
		/// Gets or sets the date that the schedule will start.  No occurrences will be registered before this date.  Inclusive.
		/// </summary>
		/// <value>The schedule start.</value>
		public DateTime ScheduleStart{ get; private set; }

		/// <summary>
		/// Gets or sets the date that the schedule will end.  No occurrences will be registered after this date.  Inclusive.
		/// </summary>
		/// <value>The schedule end.</value>
		public DateTime ScheduleEnd{ get; private set; }

	}
}

