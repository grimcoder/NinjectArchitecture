using System;
using Ninject;

namespace architecture
{
	public interface ICalendarService {
		event EventHandler<ICalendarEventArgs> Holiday;
		void SomethingHappened();
	}
	
}
