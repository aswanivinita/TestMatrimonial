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
        private static int lastId = 0;
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public ReligionType Religion { get; set; }
        public string WorkStatus { get; set; }
        public double AnnualIncome { get; set; }
        public int Age{ get; private set; }
        public int ReferenceId { get; set; }

        #endregion

        #region Constructors

        public Person()
        {
            ReferenceId = ++lastId;
                 
        }

        #endregion

        #region Methods

        public void CalculateAge()
        {
            Age =  DateTime.Now.Year - DOB.Year;
            
        }

        #endregion



    }
}
