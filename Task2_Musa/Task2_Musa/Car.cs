using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Musa
{
    class Car
    {
        private string _Brand="N/A";
        private string _Model="N/A";
        private string _Color="N/A";
        private int _MaxSpeed = 0;

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public Car(string Brand , string Model)
        {
            this._Brand = Brand;
            this._Model = Model;
        }

        public Car(string Brand, string Model , string Color, int MaxSpeed) : this(Brand , Model)
        {
            this._Color = Color;
            this._MaxSpeed = MaxSpeed;
        }

        public string Brand
        {
            get
            {
                return this._Brand;
            }
        }
        public string Model
        {
            get
            {
                return this._Model;
            }
        }
        public string Color
        {
            get
            {
                return this._Color;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return this._MaxSpeed;
            }
        }


        public virtual string Info()
        {
            return $"Brand: {this._Brand} | Model: {this._Model} | Color: {this._Color} | Max Speed: {this._MaxSpeed}";
        }
    }
}
