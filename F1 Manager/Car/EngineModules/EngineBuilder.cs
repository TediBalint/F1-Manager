using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
    class ConcreteEngineBuilder : IEngineBuilder
    {
        private Engine _product;

        public ConcreteEngineBuilder()
        {
            _product = new Engine();
        }

        public void BuildICE(ICE ice_)
        {
            _product.ice = ice_;
        }

        public void BuildTurbo(Turbo turbo_)
        {
            _product.turbo = turbo_;
        }
		public void BuildMGUH(MGUH mguh_)
		{
			_product.mguh = mguh_;
		}
		public void BuildMGUK(MGUK mguk_)
		{
			_product.mguk = mguk_;
		}
        public void BuildCE(ControlElectronics ce_)
        {
            _product.controlElectronics = ce_;
        }
		public Engine Build()
        {
            _product.parts = new List<object> {_product.ice, _product.turbo, _product.mguh, _product.mguk, _product.controlElectronics};
            return _product;
        }
    }
    interface IEngineBuilder
    {
        void BuildICE(ICE ice_);
        void BuildTurbo(Turbo turbo_);
        void BuildMGUH(MGUH mguh_);
        void BuildMGUK(MGUK mguk_);
        void BuildCE(ControlElectronics ce_);
		Engine Build();
    }

}
