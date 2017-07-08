using System;

namespace Recurring.NET.Model.Dates
{
	public struct Date
	{
		#region Constructors

		public Date(int year, int month, int day)
		{
			_internalDateTime = new DateTime(year, month, day);
		}

		public Date(int year, Month month, int day)
		{
			_internalDateTime = new DateTime(year, (int)month, day);
		}

		#endregion

		#region Private Fields

		private DateTime _internalDateTime;

		#endregion

		#region Public Properties

		public int Year { get { return _internalDateTime.Year; } }

		public Month Month { get { return (Month)_internalDateTime.Month; } }

		public int Day { get { return _internalDateTime.Day; } }

		#endregion

		#region Public Methods

		public void SetYear(int year)
		{
			_internalDateTime = new DateTime(year, _internalDateTime.Month, _internalDateTime.Day);
		}

		public void AddYears(int years)
		{
			_internalDateTime.AddYears(years);
		}

		public void SubstractYears(int years)
		{
			_internalDateTime.AddYears(-years);
		}

		public void SetMonth(int month)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, month, _internalDateTime.Day);
		}

		public void SetMonth(Month month)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, (int)month, _internalDateTime.Day);
		}

		public void AddMonths(int months)
		{
			_internalDateTime.AddMonths(months);
		}

		public void SubstractMonths(int months)
		{
			_internalDateTime.AddMonths(-months);
		}

		public void SetDay(int day)
		{
			_internalDateTime = new DateTime(_internalDateTime.Year, _internalDateTime.Month, day);
		}

		public void AddDays(int days)
		{
			_internalDateTime.AddDays(days);
		}

		public void SubstractDays(int days)
		{
			_internalDateTime.AddDays(-days);
		}

		#endregion
	}
}

