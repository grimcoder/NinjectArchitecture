using System;
using Ninject;

namespace architecture
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IKernel kernel = new StandardKernel();

			kernel.Bind<ICalendarService>().To<CalendarService>().InSingletonScope();
			kernel.Bind<ICalendarEventArgs>().To<PersonalEventsEventArgs>();

			var cal = kernel.Get<ICalendarService>();

			cal.Holiday += (o, a) => {
				Console.WriteLine (a.HolidayName);
			};

			cal.SomethingHappened ();

		}
	}
}
