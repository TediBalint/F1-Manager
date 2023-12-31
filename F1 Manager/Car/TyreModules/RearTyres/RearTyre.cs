﻿using F1_Manager.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Car.TyreModules.RearTyres
{
    public class RearTyre : Tyre
    {
		public RearGrip rearGrip{ get; set; }
		public Durability durability { get; set; }
		public Setup setup { get; set; } = new Setup(CarStatics.defaultSetup.rearPressure);
	}
}
