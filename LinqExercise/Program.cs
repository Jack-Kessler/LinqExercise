using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            int answer = numbers.Sum(x => x);
            Console.WriteLine(answer);
            Console.WriteLine();

            //TODO: Print the Average of numbers

            double average = numbers.Average(x => x);
            Console.WriteLine(average);
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console

            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            List<int> sorted = numbers.OrderBy(x => x).ToList();

            int counter = 0;
            foreach (int number in sorted)
            {
                if (counter < 4)
                {
                    Console.Write(number);
                    counter++;
                }
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 30;
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.Write(x));
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Employee Fullname: {x.FirstName} {x.LastName}"));
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            employees.Where(x => x.Age > 26).OrderBy(x => x.FirstName).OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine($"Employee Fullname: {x.FirstName} {x.LastName}\nAge: {x.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var newList = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            int sum = newList.Sum(x => x.YearsOfExperience);
            double avg = newList.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Sum: {sum}\nAvg. Years of Experience: {avg}\n");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()

            Employee jack = new Employee { FirstName = "Jack", LastName = "Kessler", Age = 30, YearsOfExperience = 30 };

            employees.Insert(0,jack);

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.LastName);
            }

        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
