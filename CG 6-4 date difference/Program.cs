using System;

namespace CG_6_4_date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the number of days between two dates.");
            Console.Write("Please enter first date (MM/DD/YYYY): ");
            
            string firstdateInput = Console.ReadLine();
            DateTime firstDate = Convert.ToDateTime(firstdateInput);

            Console.Write("Please enter second date (MM/DD/YYYY): ");

            string seconddateInput = Console.ReadLine();
            DateTime secondDate = Convert.ToDateTime(seconddateInput);




            Console.ReadLine();
        }
    }
}
