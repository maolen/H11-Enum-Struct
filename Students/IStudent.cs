using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public interface IStudent
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public double AverageGrade { get; set; }
        public int Income { get; set; }

        public Gender Gender { get; set; }
        public StudyForm StudyForm { get; set; }
    }
}
