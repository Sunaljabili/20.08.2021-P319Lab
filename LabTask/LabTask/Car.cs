using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public int maxSpeed;
        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string Brand, string Model)
        {
            this.brand = Brand;
            this.model = Model;

        }
        public Car(string Color, int MaxSpeed, string Brand, string Model) : this(Brand, Model)
        {
            this.color = Color;
            this.maxSpeed = MaxSpeed;
        }

        public virtual string CarInfo()
        {
            return ($"Brand is: {this.brand}, the model is:{this.model}the color is {this.color}, the maxSpeed {this.maxSpeed}");

        }

    }
}
