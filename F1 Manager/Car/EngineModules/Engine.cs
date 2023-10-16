using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
