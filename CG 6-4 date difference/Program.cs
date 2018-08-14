using System;

namespace CG_6_4_date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the number of days between two dates.");
            Console.Write("Please enter first date (MM/DD/YYYY): ");

            //declare string value of user input then convert to date
            string firstdateInput = Console.ReadLine();

            //convert string input to date
            DateTime firstDate = DateTime.Parse(firstdateInput);

            //prompt for second date
            Console.Write("Please enter second date (MM/DD/YYYY): ");

            //declare string value of user input then convert to date.
            string seconddateInput = Console.ReadLine();
            DateTime secondDate = DateTime.Parse(seconddateInput);

            //use timespan when determining an interval of time
            //take first date and subtract second date from it
            TimeSpan dayDifference = firstDate.Subtract(secondDate);

            //wanted total number of days between the two to be a positive number so i used Duration
            TimeSpan daydifferenceTotal = dayDifference.Duration();



            //print the difference, in days, between the two to the console.
            Console.WriteLine(daydifferenceTotal.TotalDays);


            Console.ReadLine();
        }

    }
}
