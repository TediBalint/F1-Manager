using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.FloorModules
{
	public class Floor
	{
		public Weight weight { get;set; }
		public FrontDownForce frontDownForce{ get;set; }
		public RearDownForce rearDownforce { get;set; }
		public Drag drag { get;set; }
		public Durability durability { get;set; }
		public Flex flex { get;set; }
	}
}
