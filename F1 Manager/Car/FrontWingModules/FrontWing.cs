using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.FrontWingModules
{
	public class FrontWing
	{
		public Weight weight { get;set; }
		public FrontDownForce frontDownForce { get; set; }
		public RearGrip rearGripLoss { get; set; }
		public Drag drag { get; set; }
		public Durability durability { get; set; }
	}
}
