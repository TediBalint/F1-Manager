﻿using System;
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
		public double energyUseMult { get; set; }
		public double tyreWearMult { get; set; }
		public EnergyMode(string _name, int _level, double _powerMult, double _energyUseMult, double _tyreWearMult) { 
			name = _name;
			level = _level;
			powerMult = _powerMult;
			energyUseMult = _energyUseMult;
			tyreWearMult = _tyreWearMult;
		}
	}
}
