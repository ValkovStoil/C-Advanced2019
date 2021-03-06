﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Special_Cars
{
   public class Car
    {
        string make = "VW";
        string model = "Golf";
        int year = 2025;
        double fuelQuantity = 200;
        double fuelConsumtion = 10;
        public Car()
        {
            this.Make = this.make;
            this.Model = this.model;
            this.Year = this.year;
            this.FuelQuantity = this.fuelQuantity;
            this.FuelConsumption = this.fuelConsumtion;
        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumtion) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumtion;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumtion, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumtion)
        {
            this.Engine = engine;
            this.Tires = tires;
        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            var moveDistance = distance * this.FuelConsumption / 100;

            if (this.FuelQuantity - moveDistance > 0)
            {
                this.FuelQuantity -= moveDistance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}
