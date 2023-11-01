using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.Suspension
{
    public class Suspensions
    {
        public class Setup
        {
			public double camber { get; set; }
			public double toe { get; set; }
			public double antiRollBar { get; set; }
			public double damper { get; set; }
			public double wheelRate { get; set; }
			public double travel { get; set; }
		}
		public Setup setup = new Setup();	
       
    }
}
