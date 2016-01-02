using System;
using Ninject;

namespace architecture
{

	public abstract class ICalendarEventArgs : EventArgs{
		public string HolidayName { get; set; }
	}
	
}
