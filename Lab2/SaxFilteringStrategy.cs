using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    public class SaxFilteringStrategy : IFilteringStrategy
    {

        public IEnumerable<DataRow> Filter(string filename, string words, HashSet<string> columns)
        {
            var reader = XmlReader.Create(filename);

            string? studentName = null, faculty = null, fieldOfStudy = null, group = null, enteranceDate = null;
            var allowedElements = new HashSet<string> { "StudentName", "Faculty", "FieldOfStudy", "Group", "EnteranceDate" };
            Stack<string> elements = new Stack<string>();

            bool handlingRow = false, handlingTable = false;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        {
                            elements.Push(reader.Name);
                            switch (reader.Name)
                            {
                                case "Table":
                                    {
                                        if (handlingTable)
                                            throw new DocumentValidationException("Unexpected token");
                                        handlingTable = true;
                                        break;
                                    }
                                case "Row":
                                    {
                                        if (handlingRow || !handlingTable)
                                        {
                                            throw new DocumentValidationException("Unexpected token");
                                        }
                                        handlingRow = true;
                                        break;
                                    }
                                default:
                                    {
                                        if (!handlingRow || !allowedElements.Contains(reader.Name))
                                            throw new DocumentValidationException("Unexpected token");
                                        break;
                                    }
                            }
                            break;
                        }
                    case XmlNodeType.Text:
                        {
                            switch (elements.Peek())
                            {
                                case "StudentName":
                                    {
                                        if (studentName != null)
                                            throw new DocumentValidationException("Unexpected token");
                                        studentName = reader.Value.Trim();
                                        break;
                                    }
                                case "Faculty":
                                    {
                                        if (faculty != null)
                                            throw new DocumentValidationException("Unexpected token");
                                        faculty = reader.Value.Trim();
                                        break;
                                    }
                                case "FieldOfStudy":
                                    {
                                        if (fieldOfStudy != null)
                                            throw new DocumentValidationException("Unexpected token");
                                        fieldOfStudy = reader.Value.Trim();
                                        break;
                                    }
                                case "Group":
                                    {
                                        if (group != null)
                                            throw new DocumentValidationException("Unexpected token");
                                        group = reader.Value.Trim();
                                        break;
                                    }
                                case "EnteranceDate":
                                    {
                                        if (enteranceDate != null)
                                            throw new DocumentValidationException("Unexpected token");
                                        enteranceDate = reader.Value.Trim();
                                        break;
                                    }
                                default:
                                    throw new DocumentValidationException("Unexpected token");
                            }
                            break;
                        }
                    case XmlNodeType.EndElement:
                        {
                            elements.Pop();
                            if (reader.Name == "Row")
                            {
                                if (studentName == null || faculty == null
                                    || enteranceDate == null || group == null || fieldOfStudy == null)
                                {
                                    throw new DocumentValidationException("Missing data");
                                }
                                var dataRow = new DataRow(studentName, faculty, fieldOfStudy, group, enteranceDate);
                                if (FullfielsQuery(dataRow, words, columns))
                                    yield return dataRow;
                                studentName = null;
                                faculty = null;
                                enteranceDate = null;
                                group = null;
                                fieldOfStudy = null;
                                handlingRow = false;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        static private bool FullfielsQuery(DataRow row, string words, HashSet<string> columns)
        {
            return columns.Contains("StudentName") && row.StudentName.Contains(words)
                || columns.Contains("Faculty") && row.Faculty.Contains(words)
                || columns.Contains("FieldOfStudy") && row.FieldOfStudy.Contains(words)
                || columns.Contains("Group") && row.Group.Contains(words)
                || columns.Contains("EnteranceDate") && row.EnteranceDate.Contains(words);
        }
    }
}
