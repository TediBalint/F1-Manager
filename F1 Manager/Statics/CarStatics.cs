using F1_Manager.Car.EngineModules;
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
	}
}
