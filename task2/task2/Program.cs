using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarix daxil edin:");
            string dateinput1 = Console.ReadLine();
            DateTime date1 = Convert.ToDateTime(dateinput1);
            

            Console.WriteLine("Tarixe elave etmek istediyiniz ili daxil edin:");
            string dateinput2= Console.ReadLine();
            var date2=Convert.ToInt32(dateinput2);

            date1 = date1.AddYears(date2);
            Console.WriteLine(date1.ToString("dd-MM-yyyy"));
           


            
            
           


        }
    }
}
