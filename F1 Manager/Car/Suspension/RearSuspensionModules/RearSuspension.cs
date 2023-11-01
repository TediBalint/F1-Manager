using F1_Manager.Car.Suspension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.RearSuspensionModules
{
	public class RearSuspension : Suspensions
	{
		public Weight weight { get; set; }
		public RearGrip rearGrip { get; set; }
		public FrontGrip frontGrip { get; set; }
		public Flex flex { get; set; }
		public Drag drag { get; set; }
		public Durability durability { get; set; }
	}
}
