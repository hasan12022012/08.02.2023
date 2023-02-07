using System;
using System.Collections.Generic;
using System.Text;

namespace taskAtCode
{
    internal class Notebook
    {
        public Notebook(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand;
        public string Model;
        public double Price;
        public int RAM;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price} - RAM: {RAM}");
        }

    }
}
