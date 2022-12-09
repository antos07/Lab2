using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Lab2
{
    public class DocumentValidationException : Exception
    {
        public DocumentValidationException()
        {
        }

        public DocumentValidationException(string? message) : base(message)
        {
        }

        public DocumentValidationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DocumentValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public class Document : DataRowsContainer
    {

        private string _filename;
        private string? _schema;
        private XmlDocument _xmlDocument;

        public Document(string filename, string? schema=null)
        {
            _filename = filename;
            _schema = schema;
            _xmlDocument = new XmlDocument();

            LoadFile();
        }

        public override IEnumerator<DataRow> GetEnumerator()
        {
            XmlNode? table = _xmlDocument.SelectSingleNode("/Table");
            if (table == null)
                ThrowValidationError();

            foreach (XmlNode row in table)
            {
                string studentName = ExtractText(row.SelectSingleNode("StudentName"));
                string faculty = ExtractText(row.SelectSingleNode("Faculty"));
                string fieldOfStudy = ExtractText(row.SelectSingleNode("FieldOfStudy"));
                string group = ExtractText(row.SelectSingleNode("Group"));
                string enteranceDate = ExtractText(row.SelectSingleNode("EnteranceDate"));

                yield return new DataRow(studentName, faculty, fieldOfStudy, group, enteranceDate);
            }
        }

        public FiltredRows FilterRows(Query query)
        {
            return new FiltredRows(_filename, query);
        }

        private void LoadFile()
        {
            var settings = new XmlReaderSettings();

            XmlSchema? schema = GetXmlSchema();
            if (schema != null)
                settings.Schemas.Add(schema);

            settings.ValidationType = ValidationType.Schema;
            bool isValid = true;
            settings.ValidationEventHandler += (object? sender, ValidationEventArgs e) => {
                isValid = false;
            };
            var reader = XmlReader.Create(_filename, settings);
            try
            {
                _xmlDocument.Load(reader);
                reader.Close();
            } catch (XmlException)
            {
                isValid = false;
            }

            if (!isValid)
                ThrowValidationError();
        }

        private void ThrowValidationError()
        {
            throw new DocumentValidationException("Invalid file");
        }

        private string ExtractText(XmlNode? node)
        {
            if (node == null)
                return String.Empty;
            return node.InnerText.Trim();
        }

        private XmlSchema? GetXmlSchema()
        {
            if (_schema == null) return null;

            using var ms = new MemoryStream(Encoding.UTF8.GetBytes(_schema));
            return XmlSchema.Read(ms, null);
        }
    }
}
