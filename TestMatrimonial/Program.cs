using System;

namespace TestMatrimonial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            var Person1 = new Person
            {
                Name = "zzz",
                DOB = new DateTime(1983, 7, 22),
                Religion = Person.ReligionType.Christian,
                WorkStatus = "Self Employed",
                AnnualIncome = 20000.45
            


            };
            
        }
    }
}
