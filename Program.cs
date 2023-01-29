using System;

namespace EmpolyeePresentandAbsent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WElcome to Employee Wage Computation");
           
            Random random= new Random();
            int n=random.Next(0, 2);
            int WagePerHour = 20;
            int FullDayHour = 8;

            if (n == 0)
            {
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Employee Wage is : "+WagePerHour*FullDayHour);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
