using System;
using System.Reflection;
namespace tribeca
{
	public class Utilities
	{
		public static string GetPersonName(Person person)
		{
			// I think this is to do with reflection - https://stackoverflow.com/questions/10862747/access-private-fields 
			var name = typeof(Person).GetField("_name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);
			return Convert.ToString(name);
		}
	}
}

