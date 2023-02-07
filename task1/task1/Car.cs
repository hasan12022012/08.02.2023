using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage} - FuelCapacity: {FuelCapacity}");
        }
    }
}
