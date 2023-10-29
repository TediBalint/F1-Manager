using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace F1_Manager.Car
{

	public class FrontDownForce
    {
        double downForce { get; set; }
        double maxDownForce { get; set; }
    }
    public class RearDownForce
    {
        public double downForce { get; set; }
        public double maxDownForce { get; set; }
    }

    public class FrontGrip
    {
        public double frontGrip { get; set; }
        public double maxFrontGrip { get; set; }

    }

    public class RearGrip
    {
        public double rearGrip { get; set; }
        public double maxRearGrip { get; set; }
    }

    public class Drag
    {
        public double drag { get; set; }
        public double minDrag { get; set; }
    }
    public class Flex
    {
        double flex { get; set; }
        double minFlex { get; set; }
        double maxFlex { get; set; }
    }
    public class Durability
    {
        public double durability { get; set; }
        public double maxDurability { get; set; }
    }
    public class Power
    {
        public double power { get; set; }
        public double maxPower { get; set; }
    }
    public class FuelConsumption
    {
        public double fuelConsumption { get; set; }
        public double minFuelConsumption { get; set; }
    }
    public class Ers
    {
        public double ers { get; set; }
        public double maxErs { get; set; }
    }
    public class Heat
    {
        public double heat { get; set; }
        public double maxHeat { get; set; }

    }
    public class Weight
    {
        public double weight { get; set; }
        public double minWeight { get; set; }
    }
}
