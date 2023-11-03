using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.GearBoxModules
{
	public class GearBox
	{
		public int gearCount { get; set; }
		public int extraGears { get; set; }
		public Gear currentGear { get; set; }
		public Gear[] gears;
		public GearBox(Gear[] _gears)
		{
			gears = _gears;
			currentGear = _gears[0];
			setGearCount();
		}
		private void setGearCount()
		{
			gearCount = gears.Where(gear => gear.gearType == 'F').Count();
			extraGears = gears.Length - gearCount;
		}
		public void ShiftUp()
		{
			if(currentGear.gearNum < gearCount - 1)
			{
				currentGear = gears[currentGear.gearNum+extraGears];
			}
		}
		public void ShiftDown()
		{
			if(currentGear.gearNum > 1 - extraGears)
			{
				currentGear = gears[currentGear.gearNum];
			} 
		}
		
	}
}
