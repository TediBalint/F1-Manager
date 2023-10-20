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
            Ers ers = new Ers();
            Heat heat = new Heat();
            Durability durability = new Durability();
            Power power = new Power();
            Weight weight = new Weight();
            FuelConsumption fuelConsumption = new FuelConsumption();
            RearGrip rearGrip = new RearGrip();

			ICE ice = new ICE(power, heat, heat, durability, weight, fuelConsumption);
			Turbo turbo = new Turbo(power, heat, heat, durability, weight, rearGrip);
			MGUH mguh = new MGUH(power, heat, heat, durability, weight, ers, ers);
            MGUK mguk = new MGUK(power, heat, heat, durability, weight, ers, ers);
            ControlElectronics controlElectronics = new ControlElectronics(durability, durability);


			_builder.BuildICE(ice);
            _builder.BuildTurbo(turbo);
            _builder.BuildMGUH(mguh);
			_builder.BuildMGUK(mguk);
            _builder.BuildCE(controlElectronics);
            
            return _builder.Build();
        }
    }
}
