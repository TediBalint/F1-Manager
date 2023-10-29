using F1_Manager.Car.EngineModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Managers
{
	public class CreateCarManager
	{
		public Engine thisEngine;
		public CreateCarManager() { 
			thisEngine = CreateEngine();
			//thisEngine.ice.power.power = 100;
			//thisEngine.turbo.power.power = 300;
			//thisEngine.mguh.ersRecharge.ers = 100;
			//thisEngine.mguk.ersRecharge.ers = 200;
			//thisEngine.ice.weight.weight = 100;
		}
		public Engine CreateEngine()
		{
			ConcreteEngineBuilder _engineBuilder = new ConcreteEngineBuilder();
			EngineDirector _engineDirector = new EngineDirector(_engineBuilder);
			return _engineDirector.buildNullEngine();
		}
	}
}
