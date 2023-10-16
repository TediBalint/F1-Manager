using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
    class ConcreteBuilder : IBuilder
    {
        private Engine _product;

        public ConcreteBuilder()
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
            return _product;
        }
    }
    interface IBuilder
    {
        void BuildICE(ICE ice_);
        void BuildTurbo(Turbo turbo_);
        void BuildMGUH(MGUH mguh_);
        void BuildMGUK(MGUK mguk_);
        void BuildCE(ControlElectronics ce_);
		Engine Build();
    }

}
