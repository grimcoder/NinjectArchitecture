using System;
using Ninject;

namespace architecture
{

	public class PersonalEventsEventArgs : ICalendarEventArgs {
		public PersonalEventsEventArgs(){

			this.HolidayName = "Personal Holiday";
		}
	}
	
}
