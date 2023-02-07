using System;
using System.Drawing;

namespace taskAtCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=Convert.ToInt32(Console.ReadLine());
            Notebook[] notebook = new Notebook[count];
            
            for(int i=0; i<count; i++)
            {
                Console.WriteLine($"{i+1}. mehsulu daxil et: ");

                Console.WriteLine("Brand: ");
                string brand = Console.ReadLine();

                Console.WriteLine("Model: ");
                string model = Console.ReadLine();

                Console.WriteLine("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("RAM: ");
                int RAM = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("------------------------------------------------------------------");
                Notebook array = new Notebook(brand, model) { Price = price, RAM = RAM };
                notebook[i] = array;

            }

            double sum = 0;
            for(int i=0; i<notebook.Length; i++)
            {
                sum+= notebook[i].Price;
            }
            var qiymetlerinOrtalamasi=sum/notebook.Length;

            Console.WriteLine(qiymetlerinOrtalamasi);
        }
    }
}
