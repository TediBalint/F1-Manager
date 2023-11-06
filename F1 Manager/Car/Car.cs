using F1_Manager.Car.EngineModules;
using F1_Manager.Car.GearBoxModules;
using F1_Manager.Car.TyreModules.FrontTyres;
using F1_Manager.Car.TyreModules.RearTyres;
using F1_Manager.Statics;
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
        public class Tyres
        {
			public FrontTyre frontLeftTyre { get; set; }
			public FrontTyre frontRightTyre { get; set; }
			public RearTyre rearLeftTyre { get; set; } 
			public RearTyre rearRightTyre { get; set; }
		}
        public Tyres tyres{ get; set; } = new Tyres();

        

        public double gripFactor { get; set; }
        public double throttlePercent { get; set; }
        public double brakePercent { get; set; } 
        public double wheelRadius { get; set; } = CarStatics.defaultWheelRadius;
        public double currentPower { get; set; }
        public double currentSpeed { get; set; } // m/s

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
        private double getActiveDownForce()
        {
            return 0;
        }
        private void updateWeelRadius()
        {
            
        }
        private double getCentripetalAcceleration()
        {
            return 0;
        }
        private double getGrip()
        {
            return 1000;
        }
        private double getGripFactor()
        {
            return 0;
        }
        public void Accelerate()
        {
            double maxTorque = getTorque();
            double currentRpmPercent = engine.rpm / engine.maxrpm * 100;
            double deltaRpm = throttlePercent / 100 * maxTorque - (currentRpmPercent * 0.1) - (gearBox.currentGear.frictionCoefficient * currentRpmPercent);
            engine.rpm += deltaRpm;
            engine.rpm = Math.Min(engine.rpm, engine.maxrpm);
            currentPower = getPower();
            currentSpeed = getSpeed();
		}
        public void Corner(double radius, double angle)
        {

        }
        public void Straight(double length)
        {

        }
        public void Brake()
        {

        }
	}

}
