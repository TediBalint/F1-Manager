using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.HaloModules
{
	public class Halo
	{
		public Weight weight { get; set; } = new Weight();
		public Drag drag { get; set; } = new Drag();
		public RearDownForce rearDownForce { get; set; } = new RearDownForce();	
		public Durability durability { get; set; } = new Durability();
	}
}
