using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.GearBoxModules
{
	public class Gear
	{
		public int gearNum { get; set; }
		public double gearRatio { get; set; }
		public double frictionCoefficient { get; set; }
		public char gearType { get;set; }
		public Gear(int _gearNum, double _gearRatio, double _frictionCoefficient, char _gearType = 'F')
		{
			gearNum = _gearNum;
			gearRatio = _gearRatio;
			frictionCoefficient = _frictionCoefficient;
			gearType = _gearType;
		}
	}
}
