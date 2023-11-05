using F1_Manager.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.TyreModules
{
	public class Tyre
	{
		public double wear { get; set; }
		public double coreTemp { get; set; }
		public double surfaceTemp { get; set; }
		public double currentPressure { get; set; }
		public double radius { get; set; }
		
		public class Setup
		{
			public double pressure { get; set; }
			public Setup(double? _pressure)
			{
				if (_pressure.HasValue)
				{
					pressure = _pressure.Value;
				}
				else
				{
					pressure = CarStatics.defaultSetup.frontPressure;
				}
			}
		}
	}

	
}
