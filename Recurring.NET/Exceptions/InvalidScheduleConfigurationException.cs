using System;

namespace Recurring.NET.Exceptions
{
	public class InvalidScheduleConfigurationException : Exception
	{
		internal InvalidScheduleConfigurationException (string message)
			: base(message)
		{
		}
	}
}

