using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.TrackParts
{
	public class Corner
	{
		public double angle { get;set; }
		public double radius { get;set; }
		public double distance { get;set; }
		public Corner(double _angle, double _radius) 
		{ 
			angle = _angle;
			radius = _radius;
			distance = radius * angle;
		}
	}
}
