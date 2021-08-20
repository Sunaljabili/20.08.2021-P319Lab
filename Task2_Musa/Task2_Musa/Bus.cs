using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Musa
{
    class Bus : Car
    {
        private byte _PassengerCount=0;

        public Bus(string Brand , string Model , string Color, int MaxSpeed, byte PassengerCount) : base(Brand, Model, Color, MaxSpeed)
        {
            this._PassengerCount = PassengerCount;
        }

        public byte PassengerCount
        {
            get
            {
                return this._PassengerCount;
            }
        }


        public override string Info()
        {
            return $"{base.Info()} | Passenger Count: {this._PassengerCount}";

        }

    }
}
