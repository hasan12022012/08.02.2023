using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Mercedes",
                Model = "G63",
                Millage = 34000,
                FuelCapacity=96
            };

            car1.ShowInfo();


            Bicycle bcy1 = new Bicycle
            {
                Brand= "stels",
                Model = "pilot710",
                Millage=500
            };

            bcy1.ShowInfo();

        }
    }
}
