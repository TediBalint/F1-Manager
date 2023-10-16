using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.EngineModules
{
    class EngineDirector
    {
        private IBuilder _builder;

        public EngineDirector(IBuilder builder)
        {
            _builder = builder;
        }
    }
}
