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
			new Gear(-1, 14.7, 0.01, 'R'), 
			new Gear(0, 0, 0.01, 'N'),
			new Gear(1, 14.7, 0.01),
			new Gear(2, 11.71, 0.015),
			new Gear(3, 9.68, 0.02),
			new Gear(4, 8.09, 0.025),
			new Gear(5, 6.93, 0.0275),
			new Gear(6, 6.05, 0.03),
			new Gear(7, 5.34, 0.0325),
			new Gear(8, 4.75, 0.035)
		};
	}
}
