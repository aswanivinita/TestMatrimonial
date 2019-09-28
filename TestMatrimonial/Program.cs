using System;

namespace TestMatrimonial
{
    class Program
    {
        static void Main(string[] args)
        {


            var Person1 = new Person
            {
                Name = "zzz",
                DOB = new DateTime(1983, 7, 22),
                Religion = Person.ReligionType.Christian,
                WorkStatus = "Self Employed",
                AnnualIncome = 20000.45



            };

            Person1.CalculateAge();

            Console.WriteLine($"Name is {Person1.Name}," +
                $" Date of Birth is " + Person1.DOB.ToString("d") +
                $" RefID is {Person1.ReferenceId}, Religion is {Person1.Religion}," +
                $"Work Status is {Person1.WorkStatus}," +
                $"Income is {Person1.AnnualIncome} , age is {Person1.Age}");

            var Person2 = new Person
            {
                Name = "abc",

            };

            Console.WriteLine($"Name is {Person2.Name}, RefID is {Person2.ReferenceId}");
        }
    }
}
