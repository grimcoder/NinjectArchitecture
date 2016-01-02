using System;
using Ninject;

namespace architecture
{

	public class Client : IClient {
		ICalendarService _calendarService;

		public Client(ICalendarService calendarService)
		{
			this._calendarService = calendarService;

		}


	}
	
}
