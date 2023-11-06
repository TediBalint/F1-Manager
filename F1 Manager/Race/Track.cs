using F1_Manager.TrackParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Race
{
	public class Track
	{
		public string name { get; set; }
		public string[] statistics { get; set; }
		private int currentPartIndex = 0;
		
		public Corner[] corners { get; set; }
		// there is a straight between each corners
		public double[] straightLengths { get; set; }
		public Track(Corner[] _corners, double[] _starightLengths) 
		{
			corners = _corners;
			straightLengths = _starightLengths;
		}
		public Corner NextCorner()
		{
			return corners[currentPartIndex++];
		}
		public double nextStaright() 
		{
			return straightLengths[currentPartIndex];
		}

	}
}
