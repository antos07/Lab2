using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Lab2
{
    public class SaxParser
    {
        private XmlReader _reader;
        private List<DataRow> _rows = new();
        private Stack<string> _elements = new();
        private bool _handlingTable = false, _handlingRow = false;
        private HashSet<string> _allowedElements = new() { "StudentName", "Faculty",
            "FieldOfStudy", "Group", "EnteranceDate" };
        private string? _studentName = null;
        private string? _faculty = null;
        private string? _fieldOfStudy = null;
        private string? _group = null;
        private string? _enteranceDate = null;

        public SaxParser(string filename)
        {
            _reader = XmlReader.Create(filename);
        }

        public IEnumerable<DataRow> ParseRows()
        {
            while (_reader.Read())
            {
                switch (_reader.NodeType)
                {
                    case XmlNodeType.Element:
                        {
                            HandleElement();
                            break;
                        }
                    case XmlNodeType.Text:
                        {
                            HandleText();
                            break;
                        }
                    case XmlNodeType.EndElement:
                        {
                            HandleEndElement();
                            break;
                        }
                }
            }
            return _rows;
        }

        private void HandleElement()
        {
            _elements.Push(_reader.Name);
            switch (_reader.Name)
            {
                case "Table":
                    {
                        if (_handlingTable)
                            throw new DocumentValidationException("Unexpected token");
                        _handlingTable = true;
                        break;
                    }
                case "Row":
                    {
                        if (_handlingRow || !_handlingTable)
                        {
                            throw new DocumentValidationException("Unexpected token");
                        }
                        _handlingRow = true;
                        break;
                    }
                default:
                    {
                        if (!_handlingRow || !_allowedElements.Contains(_reader.Name))
                            throw new DocumentValidationException("Unexpected token");
                        break;
                    }
            }
        }

        private void HandleText()
        {
            string text = _reader.Value.Trim();
            switch (_elements.Peek())
            {
                case "StudentName":
                    {
                        if (_studentName != null)
                            throw new DocumentValidationException("Unexpected token");
                        _studentName = text;
                        break;
                    }
                case "Faculty":
                    {
                        if (_faculty != null)
                            throw new DocumentValidationException("Unexpected token");
                        _faculty = text;
                        break;
                    }
                case "FieldOfStudy":
                    {
                        if (_fieldOfStudy != null)
                            throw new DocumentValidationException("Unexpected token");
                        _fieldOfStudy = text;
                        break;
                    }
                case "Group":
                    {
                        if (_group != null)
                            throw new DocumentValidationException("Unexpected token");
                        _group = text;
                        break;
                    }
                case "EnteranceDate":
                    {
                        if (_enteranceDate != null)
                            throw new DocumentValidationException("Unexpected token");
                        _enteranceDate = text;
                        break;
                    }
                default:
                    throw new DocumentValidationException("Unexpected token");
            }
        }

        private void HandleEndElement()
        {
            _elements.Pop();
            if (_reader.Name == "Row")
            {
                if (_studentName == null || _faculty == null
                    || _enteranceDate == null || _group == null 
                    || _fieldOfStudy == null)
                {
                    throw new DocumentValidationException("Missing data");
                }
                var dataRow = new DataRow(_studentName, _faculty, _fieldOfStudy, _group, _enteranceDate);
                _rows.Add(dataRow);
                _studentName = null;
                _faculty = null;
                _enteranceDate = null;
                _group = null;
                _fieldOfStudy = null;
                _handlingRow = false;
            }
        }
    }

    public class SaxFilteringStrategy : IFilteringStrategy
    {

        public IEnumerable<DataRow> Filter(string filename, string words, HashSet<string> columns)
        {
            var parser = new SaxParser(filename);
            IEnumerable<DataRow> rows = parser.ParseRows();

            foreach (DataRow row in rows)
            {
                if (FullfielsQuery(row, words, columns))
                    yield return row;
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
