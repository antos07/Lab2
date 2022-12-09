using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class DataRow
    {
        public string StudentName { get; }
        public string Faculty { get; }
        public string FieldOfStudy { get; }
        public string Group { get; }
        public string EnteranceDate { get; }

        public DataRow(string studentName, string faculty, string fieldOfStudy, string group, string enteranceDate)
        {
            StudentName = studentName;
            Faculty = faculty;
            FieldOfStudy = fieldOfStudy;
            Group = group;
            EnteranceDate = enteranceDate;
        }
    }
}
