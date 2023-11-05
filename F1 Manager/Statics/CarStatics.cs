using F1_Manager.Car.EngineModules;
using F1_Manager.Car.GearBoxModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Statics
{
	public static class CarStatics
	{
		
		public static Dictionary<string, EnergyMode> defaultEnergy = new Dictionary<string, EnergyMode>()
		{
			{"Attack", new EnergyMode("Attack", 5, 1.2, 1.2, 1.4)},
			{"Push", new EnergyMode("Push", 4, 1.1,1.1, 1.2) },
			{"Neutral", new EnergyMode("Neutral", 3, 1, 1, 1) },
			{"Recharge", new EnergyMode("Recharge", 2, 0.9, 0.9, 0.95) },
			{"Back Off", new EnergyMode("Back Off", 1, 0.7, 0.7, 0.9) }
		};		
		public static Gear[] defaultGears =
		{
			new Gear(-1, defaultSetup.gearRatios[0], 0.01, 'R'), 
			new Gear(0, 0, 0.01, 'N'),
			new Gear(1, defaultSetup.gearRatios[0], 0.01),
			new Gear(2, defaultSetup.gearRatios[1], 0.015),
			new Gear(3, defaultSetup.gearRatios[2], 0.02),
			new Gear(4, defaultSetup.gearRatios[3], 0.025),
			new Gear(5, defaultSetup.gearRatios[4], 0.0275),
			new Gear(6, defaultSetup.gearRatios[5], 0.03),
			new Gear(7, defaultSetup.gearRatios[6], 0.0325),
			new Gear(8, defaultSetup.gearRatios[7], 0.035)
		};
		public static class defaultSetup
		{
			public static double frontPressure = 14; //PSI
			public static double rearPressure = 14;
			public static double frontWingAngle = 30;
			public static double rearWingAngle = 30;
			public static double[] gearRatios = { 14.7, 11.71, 9.68, 8.09, 6.93, 6.05, 5.34, 4.75 };
		}
		
	}
}
