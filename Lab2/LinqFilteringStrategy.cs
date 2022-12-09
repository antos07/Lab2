using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    public class LinqFilteringStrategy : IFilteringStrategy
    {
        public IEnumerable<DataRow> Filter(string filename, string words, HashSet<string> columns)
        {
            XElement xml = XElement.Load(filename);
            try
            {
                return xml.Elements("Row").Where(rowElement => IsRowValid(rowElement, words, columns))
                    .Select(DataRowFromXElement);
            }
            catch (NullReferenceException)
            { 
                return Enumerable.Empty<DataRow>(); 
            }
        }

        static private bool IsRowValid(XElement row, string words, HashSet<string> columns)
        {
            return row.Elements().Any(column => columns.Contains(column.Name.ToString()) && column.Value.Contains(words));
        }

        static private DataRow DataRowFromXElement(XElement row)
        {
            string studentName = GetChildText(row, "StudentName");
            string faculty = GetChildText(row, "Faculty");
            string fieldOfStudy = GetChildText(row, "FieldOfStudy");
            string group = GetChildText(row, "Group");
            string enteranceDate = GetChildText(row, "EnteranceDate");
            return new DataRow(studentName, faculty, fieldOfStudy, group, enteranceDate);
        }

        static private string GetChildText(XElement parent, string childName)
        {
            XElement? child = parent.Element(childName);
            if (child == null)
                return String.Empty;
            return child.Value.Trim();
        }
    }
}
