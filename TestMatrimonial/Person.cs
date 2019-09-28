using System;
using System.Collections.Generic;
using System.Text;

namespace TestMatrimonial
{
    class Person
    {
        
        public enum ReligionType
        {
            Hindu, 
            Islamic,
            Christian
        };
        #region Properties
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public ReligionType Religion { get; set; }
        public string WorkStatus { get; set; }
        public double AnnualIncome { get; set; }
        public int Age{ get; private set; }

        #endregion

        #region Constructors

        public Person(DateTime dob)
        {
            Console.WriteLine("calling constructor ");
            Console.WriteLine(DOB.ToString());
                 
        }

        #endregion



    }
}
