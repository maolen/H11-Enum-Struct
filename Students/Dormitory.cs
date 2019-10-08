using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class Dormitory
    {
        const int MINIMAL_SALARY = 10000;
        const int QUOTA_COEF = 2;
        public List<Student> DormitoryStudentList(List<Student> students)
        {
            //var dormitoryStudents = new List<Student>();
            //foreach(var student in students)
            //{
            //    if(student.Income < MINIMAL_SALARY * QUOTA_COEF)
            //    {
            //        dormitoryStudents.Add(student);
            //    }
            //    else
            //    {

            //    }
            //}
            var credit = QUOTA_COEF * MINIMAL_SALARY;
            var dormitoryStudents = new List<Student>();
            dormitoryStudents.Sort((a, b) => b.AverageGrade.CompareTo(a.AverageGrade));

            foreach (var student in dormitoryStudents)
            {
                if (student.Income < credit)
                {
                    dormitoryStudents.Add(student);
                }
            }
            foreach (var student in dormitoryStudents)
            {
                if (!dormitoryStudents.Contains(student))
                {
                    dormitoryStudents.Add(student);
                }
            }
            return dormitoryStudents;
        }
    }
}
