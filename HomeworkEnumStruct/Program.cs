using System;
using static System.Console;
using System.Collections.Generic;

namespace HomeworkEnumStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            WriteLine("Введите данные сотрудника:");
            employees.Add(new Employee
            {
                Name = ReadLine(),
                Salary = Convert.ToInt32(ReadLine()),
                HiringDate = new int[] { 12, 10, 2017},
                Vacancy = Vacancies.Clerk
            }); ;

        }
    }
}
