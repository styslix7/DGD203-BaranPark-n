using System;

namespace DGD203.Project.BaranParkin
{
    public class Car
    {
        //I wanted to go with a different style and made a spaceship instead of a common car, however I named it "Car" since it was said in assignment
        //setting default name for the spaceship as "Horizon" inspired by Mass Effect "Normandy", you will also see EDI here
        public string Name = "Horizon";
        //defining spaceship model and year
        public string Model;
        public int Year;
        //setting default values for speed, fuel, and shields
        public int Speed = 0;
        public int MaxSpeed = 300;
        public float FuelLevel = 100;
        public float FuelCapacity = 100;
        public int ShieldStrength = 100;
        public int MaxShieldStrength = 100;

        //set model and year
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
            //telling the player about the spaceship when they board
            Console.WriteLine($"Welcome aboard the spaceship '{Name}' - Model: {Model}, Year: {Year}.");
        }

        //accelerating the spaceship by the given amount
        public void Accelerate(int amount)
        {
            Speed += amount;
            if (Speed > MaxSpeed) Speed = MaxSpeed;
            Console.WriteLine($"Accelerating to {Speed} km/h.");
        }

        //slowing down the spaceship by the given amount
        public void Brake(int amount)
        {
            Speed -= amount;
            if (Speed < 0) Speed = 0;
            Console.WriteLine($"Reducing speed to {Speed} km/h.");
        }

        //refueling the spaceship and making sure it doesn't exceed the capacity
        public void Refuel(float amount)
        {
            FuelLevel += amount;
            if (FuelLevel > FuelCapacity) FuelLevel = FuelCapacity;
            Console.WriteLine($"Fuel level now at {FuelLevel}/{FuelCapacity}.");
        }

        //damaging the shields by the given amount
        public void DamageShield(int amount)
        {
            ShieldStrength -= amount;
            if (ShieldStrength < 0) ShieldStrength = 0;
            Console.WriteLine($"Shields down to {ShieldStrength}/{MaxShieldStrength}.");
        }

        //repairing the shields by the given amount
        public void RepairShield(int amount)
        {
            ShieldStrength += amount;
            if (ShieldStrength > MaxShieldStrength) ShieldStrength = MaxShieldStrength;
            Console.WriteLine($"Shields restored to {ShieldStrength}/{MaxShieldStrength}.");
        }

        //showing the current status of the spaceship (speed, fuel, shields)
        public void ReportStatus()
        {
            Console.WriteLine($"Status - Speed: {Speed}, Fuel: {FuelLevel}/{FuelCapacity}, Shields: {ShieldStrength}/{MaxShieldStrength}");
        }
    }
}