using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.RearWingModules
{
	public class RearWing
	{
		public RearDownForce rearDownForce { get;set; }
		public FrontDownForce frontDownForceLoss { get;set; }
		public Drag drag { get;set; }
		public Weight weight { get;set; }
		public Flex flex { get;set; }
		public Durability durability { get;set; }
	}
}
