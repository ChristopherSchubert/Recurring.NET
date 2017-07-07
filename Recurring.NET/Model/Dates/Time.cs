using System;

namespace Recurring.NET.Model.Dates
{
	public struct Time
	{
		public Time(int hour, int minute, int second, int millisecond = 0)
		{
			_internalDateTime = new DateTime(2000, 1, 1, hour, minute, second);

			if (millisecond != 0)
			{
				_internalDateTime.AddMilliseconds(millisecond);
			}
		}

		private DateTime _internalDateTime;

		public int Hour { get { return _internalDateTime.Hour; } }

		public int Minute { get { return _internalDateTime.Minute; } }

		public int Second { get { return _internalDateTime.Second; } }

		public int Millisecond { get { return _internalDateTime.Millisecond; } }

		public void SetHour(int hour)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, _internalDateTime.Month, _internalDateTime.Day, hour, _internalDateTime.Minute, _internalDateTime.Second);
		}

		public void AddHours(int hours)
		{
			_internalDateTime.AddHours(hours);
		}

		public void SubstractHours(int hours)
		{
			_internalDateTime.AddHours(-hours);
		}

		public void SetMinute(int minute)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, _internalDateTime.Month, _internalDateTime.Day, _internalDateTime.Hour, minute, _internalDateTime.Second);
		}

		public void AddMinute(int minutes)
		{
			_internalDateTime.AddMinutes(minutes);
		}

		public void SubstractMinutes(int minutes)
		{
			_internalDateTime.AddMinutes(-minutes);
		}

		public void SetSecond(int second)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, _internalDateTime.Month, _internalDateTime.Day, _internalDateTime.Hour, _internalDateTime.Minute, second);
		}

		public void AddSeconds(int seconds)
		{
			_internalDateTime.AddSeconds(seconds);
		}

		public void SubstractSeconds(int seconds)
		{
			_internalDateTime.AddSeconds(-seconds);
		}

		public void SetMillisecond(int millisecond)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, _internalDateTime.Month, _internalDateTime.Day, _internalDateTime.Hour, _internalDateTime.Minute, _internalDateTime.Second);
			AddMilliseconds(millisecond);
		}

		public void AddMilliseconds(int milliseconds)
		{
			_internalDateTime.AddMilliseconds(milliseconds);
		}

		public void SubstractMilliseconds(int milliseconds)
		{
			_internalDateTime.AddMilliseconds(-milliseconds);
		}
	}
}

