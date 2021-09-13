﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Q14
{
    class Program
    {
        public interface IContractEmployee
        {
            void CalculateSalary(int hour, int perHourRupees);
        }

        public class Info : IContractEmployee
        {
            int salary;

            public void CalculateSalary(int hour, int perHourRupees)
            {
                int hr, rup;
                hr = hour;
                rup = perHourRupees;

                salary = hr * rup;

                Console.WriteLine("salary is : " + salary);
                Console.ReadLine();

            }
        }
        static void Main(string[] args)
        {
            Info obj = new Info();
            Console.WriteLine("Enter Hour");
            int hr = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter perHourRupees");
            int rup = Convert.ToInt32(Console.ReadLine());

            obj.CalculateSalary(hr, rup);
            Console.ReadKey();

        }
    }
}
