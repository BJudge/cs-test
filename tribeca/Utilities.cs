using System;
using System.Reflection;
namespace tribeca
{
	public class Utilities
	{
		public static string GetPersonName(Person person)
		{
			// I think this is to do with reflection
			var name = person.GetType();
		}
	}
}

