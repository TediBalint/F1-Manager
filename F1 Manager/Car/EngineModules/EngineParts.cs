using System;
using System.Runtime.CompilerServices;

namespace F1_Manager.Car.EngineModules
{
    public class EnginePart
    {
        public Power power { get; set; }
        public Heat heat { get; set; }
        public Heat maxHeat { get; set; }
        public Durability durability { get; set; }
        public Weight weight { get; set; }
        public EnginePart(Power power_, Heat heat_, Heat maxHeat_, Durability durability_, Weight weight_)
        {
            power = power_;
            heat = heat_;
            maxHeat = maxHeat_;
            durability = durability_;
            weight = weight_;
        }
    }
    public class ICE : EnginePart
    {
        public FuelConsumption consumption { get; set; }
        public ICE(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, FuelConsumption consumption_) : 
        base(power, heat, maxHeat, durability, weight)
        {           //power = power_;
            consumption = consumption_;
        }
    }
    public class MGUK : EnginePart
    {
        public Ers ers { get; set; }
        public Ers ersRecharge { get; set; }

        public MGUK(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, Ers ers_, Ers ersRecharge_) 
        : base(power, heat, maxHeat, durability, weight)
        {
            ers = ers_;
            ersRecharge = ersRecharge_;
        }
    }
    public class MGUH : EnginePart
    {
        public Ers ers { get;set; }
        public Ers ersRecharge { get; set; }
		public FuelConsumption consumption { get; set; }

		public MGUH(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, Ers ers_, Ers ersRecharge_, FuelConsumption fuelConsumption_) 
        : base(power, heat, maxHeat, durability, weight)
        {
            ers = ers_;
            ersRecharge = ersRecharge_;
			consumption = fuelConsumption_;
		}
    }
    public class Turbo : EnginePart
    {
        public RearGrip rearGripLoss { get; set; }

        public Turbo(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, RearGrip rearGripLoss_) 
        :base(power, heat, maxHeat, durability, weight)
        {
            rearGripLoss = rearGripLoss_;
        }
    }
    public class ControlElectronics
    {
        public Durability durability { get; set; }
        public Durability durabilityLoss { get; set; }

        public ControlElectronics(Durability durability_, Durability durabilityLoss_)
        {
            durability = durability_;
            durabilityLoss = durabilityLoss_;
        }
    }


}

