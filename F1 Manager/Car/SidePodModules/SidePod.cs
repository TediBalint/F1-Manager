using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.SidePodModules
{
	public class SidePod
	{
		public FrontDownForce frontDownForce { get; set; }
		public RearDownForce rearDownForce { get; set; }
		public FrontGrip frontGrip { get; set; }
		public RearGrip rearGrip { get; set; }
		public Weight weight { get;set; }
		public Drag drag { get; set; }
		public Heat coolingAmount { get; set; }
	}
}
