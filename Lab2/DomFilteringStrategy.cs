using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    public class DomFilteringStrategy : IFilteringStrategy
    {
        public IEnumerable<DataRow> Filter(string filename, string words, HashSet<string> columns)
        {
            XmlDocument doc = LoadDocument(filename);
            XmlNode tableRoot = GetTableRootNode(doc);

            foreach (XmlNode row in tableRoot)
            {
                foreach (XmlNode col in row)
                {
                    if (columns.Contains(col.Name) && col.InnerText.Contains(words))
                    {
                        yield return DataRowFromRowNode(row);
                        break;
                    }
                }
            }
        }

        static private XmlDocument LoadDocument(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            return doc;       
        }

        static private XmlNode GetTableRootNode(XmlDocument doc)
        {
            XmlNode? tableRoot = doc.SelectSingleNode("/Table");
            if (tableRoot == null)
                throw new DocumentValidationException("Document does not contain Table tag");
            return tableRoot;
        }

        static private DataRow DataRowFromRowNode(XmlNode rowNode)
        {
            string studentName = ChildNodeText(rowNode, "StudentName");
            string faculty = ChildNodeText(rowNode, "Faculty");
            string fieldOdStudy = ChildNodeText(rowNode, "FieldOfStudy");
            string group = ChildNodeText(rowNode, "Group");
            string enteranceDate = ChildNodeText(rowNode, "EnteranceDate");

            return new DataRow(studentName, faculty, fieldOdStudy, group, enteranceDate);
        }

        static private string ChildNodeText(XmlNode parentNode, string childNodeName)
        {
            XmlNode? childNode = parentNode.SelectSingleNode(childNodeName);
            if (childNode == null)
                return String.Empty;
            return childNode.InnerText.Trim();
        }
    }
}
