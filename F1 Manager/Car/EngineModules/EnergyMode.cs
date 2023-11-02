using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
	public class EnergyMode
	{
		public string name { get; set; }
		public int level { get; set; }

		public double powerMult { get; set; }
		public double tyreWearMult { get; set; }
	}
}
