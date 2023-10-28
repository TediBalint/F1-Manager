using System;
using System.Runtime.CompilerServices;

namespace F1_Manager.Car.EngineModules
{
    public class EnginePart
    {
        public Power power;
        public Heat heat;
        public Heat maxHeat;
        public Durability durability;
        public Weight weight;

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
        public FuelConsumption consumption;
        public ICE(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, FuelConsumption consumption_) : 
        base(power, heat, maxHeat, durability, weight)
        {           //power = power_;
            consumption = consumption_;
        }
    }
    public class MGUK : EnginePart
    {
        public Ers ers;
        public Ers ersRecharge;

        public MGUK(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, Ers ers_, Ers ersRecharge_) 
        : base(power, heat, maxHeat, durability, weight)
        {
            ers = ers_;
            ersRecharge = ersRecharge_;
        }
    }
    public class MGUH : EnginePart
    {
        public Ers ers;
        public Ers ersRecharge;

        public MGUH(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, Ers ers_, Ers ersRecharge_) 
        : base(power, heat, maxHeat, durability, weight)
        {
            ers = ers_;
            ersRecharge = ersRecharge_;
        }
    }
    public class Turbo : EnginePart
    {
        public RearGrip rearGripLoss;

        public Turbo(Power power, Heat heat, Heat maxHeat, Durability durability, Weight weight, RearGrip rearGripLoss_) 
        :base(power, heat, maxHeat, durability, weight)
        {
            rearGripLoss = rearGripLoss_;
        }
    }
    public class ControlElectronics
    {
        public Durability durability;
        public Durability durabilityLoss;

        public ControlElectronics(Durability durability_, Durability durabilityLoss_)
        {
            durability = durability_;
            durabilityLoss = durabilityLoss_;
        }
    }


}

