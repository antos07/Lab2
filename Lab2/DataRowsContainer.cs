using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Xml;
using System.Xml.Xsl;

namespace Lab2
{
    public abstract class DataRowsContainer : IEnumerable<DataRow>
    {
        public void ExportToHtml(string filename)
        {
            XslCompiledTransform xslt = LoadXslCompiledTranform();

            XmlDocument xmlRepresentation = GetXmlRepresentation();
            var writer = XmlWriter.Create(filename);

            xslt.Transform(xmlRepresentation, null, writer, null);
        }

        private XslCompiledTransform LoadXslCompiledTranform()
        {
            var xslt = new XslCompiledTransform();
            using MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(Files.exportToHtml));
            var reader = XmlReader.Create(ms);
            xslt.Load(reader);
            return xslt;
        }

        private XmlDocument GetXmlRepresentation()
        {
            var document = new XmlDocument();

            XmlElement tableElement = document.CreateElement("Table");
            foreach (DataRow row in this)
            {
                AddXmlRowRepresentation(document, tableElement, row);
            }
            document.AppendChild(tableElement);

            return document;
        }

        private void AddXmlRowRepresentation(XmlDocument document, XmlElement table, DataRow row)
        {
            XmlElement rowElement = document.CreateElement("Row");

            XmlElement studentName = document.CreateElement("StudentName");
            studentName.InnerText = row.StudentName;
            rowElement.AppendChild(studentName);


            XmlElement faculty = document.CreateElement("Faculty");
            faculty.InnerText = row.Faculty;
            rowElement.AppendChild(faculty);

            XmlElement fieldOfStudy = document.CreateElement("FieldOfStudy");
            fieldOfStudy.InnerText = row.FieldOfStudy;
            rowElement.AppendChild(fieldOfStudy);

            XmlElement group = document.CreateElement("Group");
            group.InnerText = row.Group;
            rowElement.AppendChild(group);

            XmlElement enteranceDate = document.CreateElement("EnteranceDate");
            enteranceDate.InnerText = row.EnteranceDate;
            rowElement.AppendChild(enteranceDate);

            table.AppendChild(rowElement);
        }

        abstract public IEnumerator<DataRow> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
