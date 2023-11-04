using F1_Manager.Car.EngineModules;
using F1_Manager.Car.GearBoxModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace F1_Manager.Car
{
    public class Car
    {
        public FrontWing frontWing;
        public Engine engine;
        public GearBox gearBox;
        public double gripFactor;
        public double throttlePercent { get; set; }
        public double wheelRadius { get; set; } = 0.4572;
        public double currentPower { get; set; }
        public double currentSpeed { get; set; }

		public Car()
        {

        }
        private double getTorque()
        {
            double maxTorque = engine.GetPower() / (2 * Math.PI * engine.maxrpm);
            return maxTorque * gearBox.currentGear.gearRatio * gripFactor;
        }
        private double getPower()
        {
            return 2 * Math.PI * engine.rpm * getTorque()/60;
        }
        private double getSpeed()
        {
            double angular_velocity = engine.rpm / 60 * 2 * Math.PI;
            double speed = wheelRadius * angular_velocity * gearBox.currentGear.gearRatio; 
            return speed;
        }
        public void Accelerate()
        {
            double maxTorque = getTorque();
            double rpmPercent = engine.rpm / engine.maxrpm * 100;
            double deltaRpm = throttlePercent / 100 * maxTorque - (engine.rpm * 0.1) - (gearBox.currentGear.frictionCoefficient * engine.rpm);
            engine.rpm += deltaRpm;
            engine.rpm = Math.Min(engine.rpm, engine.maxrpm);
            currentPower = getPower();
            currentSpeed = getSpeed();
		}
	}

}
