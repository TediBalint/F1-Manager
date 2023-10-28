using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
    public class Engine
    {
        public ICE ice { get; set; }
        public Turbo turbo { get; set; }
        public MGUH mguh { get; set; }
        public MGUK mguk { get; set; }
        public ControlElectronics controlElectronics { get; set; }
        public List<object> parts { get; set; }
		public double GetPower()
		{
			return parts.OfType<EnginePart>().Sum(obj => obj.power.power);
		}
        public double GetMaxPower()
        {
			return parts.OfType<EnginePart>().Sum(obj => obj.power.maxPower);
        }
	}

    
}
