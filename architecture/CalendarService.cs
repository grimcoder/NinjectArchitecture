using System;
using Ninject;

namespace architecture
{

	public class CalendarService : ICalendarService {
		
		public void SomethingHappened ()
		{
			Holiday (this, args);
		}

		#region ICalendarService implementation
		public event EventHandler<ICalendarEventArgs> Holiday;
		#endregion

		readonly ICalendarEventArgs args;
		public CalendarService(ICalendarEventArgs args){
			this.args = args;
		}
	}
	
}
