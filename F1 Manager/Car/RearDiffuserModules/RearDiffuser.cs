using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.RearDiffuserModules
{
	public class RearDiffuser
	{
		public Weight weight { get; set; } = new Weight();
		public RearDownForce rearDownForce { get; set; } = new RearDownForce();
		public Drag drag { get; set; } = new Drag();
	}
}
