using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEnumStruct
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public int[] HiringDate { get; set; }
    }
}
