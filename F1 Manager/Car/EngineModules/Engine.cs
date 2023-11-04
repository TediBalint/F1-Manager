using F1_Manager.Statics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
    public class Engine
    {
        public string Name { get; set; } 
        public double rpm { get; set; } 
        public double maxrpm { get; set; }
        public ICE ice { get; set; }
        public Turbo turbo { get; set; }
        public MGUH mguh { get; set; }
        public MGUK mguk { get; set; }
        public ControlElectronics controlElectronics { get; set; }
        public List<object> parts { get; set; }

        public Setup setup { get; set; } = new Setup();


        // Pov: Linq
		public double GetPower()
		{
			return parts.OfType<EnginePart>().Sum(obj => obj.power.power);
		}
        public double GetMaxPower()
        {
			return parts.OfType<EnginePart>().Sum(obj => obj.power.maxPower);
        }
        public double GetErsRecharge()
        {
            return GetSum("ersRecharge", "ers");
        }
		public double GetMaxErsRecharge()
		{
			return GetSum("ersRecharge", "maxErs");
		}
        public double GetWeight() {
            return GetSum("weight", "weight");
        }
		public double GetMinWeight()
		{
			return GetSum("weight", "minWeight");
		}
        public double GetConsumption()
        {
            return GetSum("consumption", "fuelConsumption");
        }
		public double GetMinConsumption()
		{
			return GetSum("consumption", "minFuelConsumption");
		}

		private double GetSum(string subclassName, string propertyName)
        {
            return parts.Where(part => part.GetType().GetProperty(subclassName) != null).Sum(part => GetSumHelper(part, subclassName, propertyName));
		}
        private double GetSumHelper(object obj, string subclassName, string propertyName) {
            object subclassObj = obj.GetType().GetProperty(subclassName).GetValue(obj);
            return (double)subclassObj.GetType().GetProperty(propertyName).GetValue(subclassObj);
		}
		public class Setup
		{
			public double fuelModeMultiplier { get; set; }
            public bool canRestart { get; set; } = false;
            public Dictionary<string, EnergyMode> energyModes { get; set; } = CarStatics.defaultEnergy;
		}
	}

    
}
