
namespace ZwiftPower
{
	public static class Segments
	{
		public enum Segment
		{
			RichmondSprint = 1,
			LondonBoxHill = 2,
			LondonSprintForward = 3,
			RichmondSprint2 = 4,
			WatopiaKOMReverse = 5,
			WatopiaKOMForward = 6,
			WatopiaSprintReverse = 7,
			WatopiaSprintForward = 8,
			VolcanoClimb = 9,
			VolcanoCircuitForward = 10,
			AlpeduZwift = 11,
			JungleCircuit = 12,
			WatopiaEpicKOMForward = 13,
			WatopiaEpicKOMReverse = 14,
			VolcanoCircuitReverse = 15,
			LondonLoopForward = 16,
			LondonFoxHill = 17,
			LondonLeithHill = 18,
			LondonKeithHill = 19,
			InnsbruckKOMForward = 20,
			InnsbruckSprintForward = 21,
			InnsbruckUCILap = 22,
			InnsbruckSprintReverse = 23,
			InnsbruckKOMReverse = 24,
			RichmondUCI = 25,
			RichmondLibbyHill = 26,
			Richmond23rdStreet = 27,
			NYClimbForward = 28,
			CentralParkLoop = 29,
			NYSprint = 30,
			NYClimbReverse = 31,
			NYSprint2 = 32,
			CentralParkReverse = 33,
			FuegoFlatsShort = 34,
			FuegoFlatsLong = 35,
			BolognaTTLap = 36,
			TitansGroveReverse = 37,
			TitansGroveForward = 38,
			YorkshireKOMForward = 39,
			YorkshireSprintForward = 40,
			YorkshireUCILapForward = 41,
			YorkshireKOMReverse = 42,
			YorkshireSprintReverse = 43,
			YorkshireUCILapReverse = 44,
			CritCityBellLap = 45,
			CritCityBellSprint = 46,
			CritCityDolphinLap = 47,
			CritCityDolphinSprint = 48,
			ReverseSprint = 49, // Richmond
			ReverseSprint2 = 50, // Richmond
			ReverseUCI = 51,
			ReverseKOM = 52,
			Reverse23rdStreet = 53,
			AqueducKOM = 54,
			PetitKOM = 55,
			VenTop = 56,
			MarinaSprintRev = 57,
			PaveSprintRev = 58,
			BallonSprint = 59,
			AqueducKOMRev = 60,
			PaveSprint = 61,
			MarinaSprint = 62,
			BallonSprintRev = 63,
			ChampsElyseesLap = 64,
			ChampsElyseesSprint = 65,
			LuteceExpressSprint = 66,
			LuteceExpressLap = 67
		}

		public static Segment[] Sprints
		{
			get
			{
				return new Segment[] {
					Segment.RichmondSprint,
					Segment.LondonSprintForward,
					Segment.RichmondSprint2,
					Segment.WatopiaSprintReverse,
					Segment.WatopiaSprintForward,
					Segment.InnsbruckSprintForward,
					Segment.InnsbruckSprintReverse,
					Segment.NYSprint,
					Segment.NYSprint2,
					Segment.FuegoFlatsShort,
					Segment.YorkshireSprintForward,
					Segment.YorkshireSprintReverse,
					Segment.CritCityBellSprint,
					Segment.CritCityDolphinSprint,
					Segment.ReverseSprint,
					Segment.ReverseSprint2,
					Segment.MarinaSprintRev,
					Segment.PaveSprintRev,
					Segment.BallonSprint,
					Segment.PaveSprint,
					Segment.MarinaSprint,
					Segment.BallonSprintRev,
					Segment.ChampsElyseesSprint,
					Segment.LuteceExpressSprint
				};
			}
		}

		public static Segment[] Climbs
		{
			get
			{
				return new Segment[]
				{
					Segment.LondonBoxHill,
					Segment.WatopiaKOMReverse,
					Segment.WatopiaKOMForward,
					Segment.VolcanoClimb,
					Segment.AlpeduZwift,
					Segment.WatopiaEpicKOMForward,
					Segment.WatopiaEpicKOMReverse,
					Segment.LondonFoxHill,
					Segment.LondonLeithHill,
					Segment.LondonKeithHill,
					Segment.InnsbruckKOMForward,
					Segment.InnsbruckKOMReverse,
					Segment.RichmondLibbyHill,
					Segment.Richmond23rdStreet,
					Segment.NYClimbForward,
					Segment.NYClimbReverse,
					Segment.TitansGroveReverse,
					Segment.TitansGroveForward,
					Segment.YorkshireKOMForward,
					Segment.YorkshireKOMReverse,
					Segment.ReverseKOM,
					Segment.Reverse23rdStreet,
					Segment.AqueducKOM,
					Segment.PetitKOM,
					Segment.VenTop,
					Segment.AqueducKOMRev
				};
			}
		}

		public static Segment[] Laps
		{
			get
			{
				return new Segment[]
				{
					Segment.BolognaTTLap,
					Segment.CentralParkLoop,
					Segment.CentralParkReverse,
					Segment.InnsbruckUCILap,
					Segment.JungleCircuit,
					Segment.LondonLoopForward,
					Segment.RichmondUCI,
					Segment.VolcanoCircuitForward,
					Segment.VolcanoCircuitReverse,
					Segment.YorkshireUCILapForward,
					Segment.YorkshireUCILapReverse,
					Segment.ReverseUCI,
					Segment.ChampsElyseesLap,
					Segment.LuteceExpressLap
				};
			}
		}
	}
}
