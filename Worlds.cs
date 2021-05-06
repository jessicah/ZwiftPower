using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZwiftPower
{
	public static class Worlds
	{
		public static Dictionary<string, int> Ids = new Dictionary<string, int>
		{
			["Watopia"] = 1,
			["Richmond"] = 2,
			["London"] = 3,
			["New York"] = 4,
			["Innsbruck"] = 5,
			["Bologna"] = 6,
			["Yorkshire"] = 7,
			["Crit City"] = 8,
			["France"] = 10,
			["Paris"] = 11
		};

		public static Dictionary<int, string> Names = new Dictionary<int, string>
		{
			[1] = "Watopia",
			[2] = "Richmond",
			[3] = "London",
			[4] = "New York",
			[5] = "Innsbruck",
			[6] = "Bologna",
			[7] = "Yorkshire",
			[8] = "Crit City",
			[10] = "France",
			[11] = "Paris"
		};
	}
}
