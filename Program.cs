﻿using System;

namespace EmpolyeePresentandAbsent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WElcome to Employee App");
            Console.WriteLine("Enter Employee name :");
            string name=Console.ReadLine();

            Random ran= new Random();
            int n= ran.Next();

            if(n == 0 )
            {
                Console.WriteLine("Empolee is Absent ");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
