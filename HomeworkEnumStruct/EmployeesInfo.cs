using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEnumStruct
{
    public class EmployeesInfo
    {
        private static Random random = new Random();
        private List<Employee> employees = new List<Employee>();

        public void PrintAllEmployee()
        {
            foreach (var employee in employees)
            {
                ShowEmployee(employee);
            }
        }


        public void PrintSortedManagers(List<Employee> managers)
        {
            managers.Sort((firstName, secondName) => firstName.Name.CompareTo(secondName.Name));
            foreach (var manager in managers)
            {
                ShowEmployee(manager);
            }
        }

        public void PrintEmployeeLaterBoss(List<Employee> employees)
        {
            List<Employee> youngerEmps = new List<Employee>();
            var boss = employees.Find(employee => employee.Vacancy == Vacancies.Boss);
            foreach (var employee in employees)
            {
                
                if (employee.HiringDate[2] == boss.HiringDate[2]) 
                {
                    if (employee.HiringDate[1] > boss.HiringDate[1]) 
                    {
                        youngerEmps.Add(employee);
                    }
                    else if (employee.HiringDate[1] == boss.HiringDate[1]) 
                    {
                        if (employee.HiringDate[0] > boss.HiringDate[0]) 
                        {
                            youngerEmps.Add(employee);
                        }
                    }
                }
                else if (employee.HiringDate[2] > boss.HiringDate[2])
                {
                    youngerEmps.Add(employee);
                }
            }
            youngerEmps.Sort((a, b) => a.Name.CompareTo(b.Name));
            foreach (var emp in youngerEmps)
            {
                ShowEmployee(emp);
            }
        }

        private void ShowEmployee(Employee employee)
        {
            Console.WriteLine($"\nИмя: {employee.Name}");
            Console.WriteLine($"Зарплата: {employee.Salary}");
            Console.WriteLine($"Должность: {employee.Vacancy}");
            Console.WriteLine($"Дата приема: {employee.HiringDate[0]}.{employee.HiringDate[1]}.{employee.HiringDate[2]}\n");
        }

        private double ClerksAverageSalary()
        {
            var salaries = 0;
            var clerkNumber = 0;

            foreach (var clerk in employees)
            {
                if (clerk.Vacancy == Vacancies.Clerk)
                {
                    salaries += clerk.Salary;
                    clerkNumber++;
                }
            }
            return (double) salaries / clerkNumber;
        }
    }
}
