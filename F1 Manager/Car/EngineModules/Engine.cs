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
			return SumStat(typeof(DefaultEnginePart), "Power.power");
		}
        public double GetMaxPower()
        {
			return parts.OfType<DefaultEnginePart>().Sum(obj => obj.power.maxPower);
        }
		private double SumStat(Type objectType, string attributePath)
		{
			string insideClass = attributePath.Split('.')[0];
			string attr = attributePath.Split(".")[1];
			PropertyInfo property = objectType.GetProperty(insideClass).PropertyType.GetProperty(attr);

			if (property == null)
			{
				throw new ArgumentException("No Property");
			}

			var filteredObjects = parts.Where(obj => obj.GetType() == objectType);
			double sum = filteredObjects.Sum(obj => (double)obj.GetType().GetProperty(insideClass).GetValue(obj).GetType().GetProperty(attr).GetValue(obj.GetType().GetProperty(insideClass).GetValue(obj)));
			//(double)property.GetValue(obj)
			//undorito
			return sum;
		}
	}

    
}
