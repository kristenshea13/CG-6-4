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
            

            /*discovered second way to convert to datetime from string, wanted to test it
             so i used convert.todatetime instead of:  
             DateTime firstDate = DateTime.Parse(firstdateInput);*/
            DateTime firstDate = Convert.ToDateTime(firstdateInput);


            Console.Write("Please enter second date (MM/DD/YYYY): ");

            //declare string value of user input then convert to date.
            //could have used parse to convert, but wanted to maintain consistency in my code
            string seconddateInput = Console.ReadLine();
            DateTime secondDate = Convert.ToDateTime(seconddateInput);
            
            //use timespan when determining an interval of time
            //take first date and subtract second date from it
            TimeSpan dayDifference = firstDate.Subtract(secondDate);

            //print the difference, in days, between the two to the console.
            Console.WriteLine(dayDifference.TotalDays);


            Console.ReadLine();
        }
    }
}
