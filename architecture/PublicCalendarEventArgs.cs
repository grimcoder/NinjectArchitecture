using System;
using Ninject;

namespace architecture
{

	public class PublicCalendarEventArgs : ICalendarEventArgs {
		public PublicCalendarEventArgs(){
				this.HolidayName = "Public holiday";
			}
		}
	
}
