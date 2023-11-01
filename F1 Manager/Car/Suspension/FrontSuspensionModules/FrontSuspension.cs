using F1_Manager.Car.Suspension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.FrontSuspensionModules
{
	public class FrontSuspension : Suspensions
	{
		public Weight weight { get; set; }
		public FrontDownForce frontDownForce { get; set; }
		public FrontGrip frontMechanicalGrip { get; set; }
		public RearGrip rearMechanicalGrip { get; set; }
		public Drag drag { get; set; }
		public Durability durability { get; set; }
		public Flex flex { get; set; }
	}
}
