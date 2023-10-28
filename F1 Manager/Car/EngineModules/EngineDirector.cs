using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
    class EngineDirector
    {
        private IEngineBuilder _builder;

        public EngineDirector(IEngineBuilder builder)
        {
            _builder = builder;
            
        }
        public Engine buildNullEngine()
        {
            // parts
			ICE ice = new ICE(new Power(), new Heat(), new Heat(), new Durability(), new Weight(), new FuelConsumption());
			Turbo turbo = new Turbo(new Power(), new Heat(), new Heat(), new Durability(), new Weight(), new RearGrip());
			MGUH mguh = new MGUH(new Power(), new Heat(), new Heat(), new Durability(), new Weight(), new Ers(), new Ers());
			MGUK mguk = new MGUK(new Power(), new Heat(), new Heat(), new Durability(), new Weight(), new Ers(), new Ers());
			ControlElectronics controlElectronics = new ControlElectronics(new Durability(), new Durability());

			_builder.BuildICE(ice);
            _builder.BuildTurbo(turbo);
            _builder.BuildMGUH(mguh);
			_builder.BuildMGUK(mguk);
            _builder.BuildCE(controlElectronics);
            
            return _builder.Build();
        }
    }
}
