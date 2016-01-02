using System;
using Ninject;

namespace architecture
{
	interface ICalendarService {
		event EventHandler<ICalendarEventArgs> Holiday;
		void SomethingHappened();
	}
	
}
