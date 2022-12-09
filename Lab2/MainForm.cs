namespace Lab2
{
    public partial class MainFrom : Form
    {
        private Document? _document;
        private DataRowsContainer? _currentlyOnDisplay;
        private Query _query;

        public MainFrom()
        {
            InitializeComponent();
        }

        private void searchQueryTextBox_TextChanged(object sender, EventArgs e)
        {
            _query.Words = searchQueryTextBox.Text;
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            _query = new Query();

            // selecting default strategy
            _query.Strategy = new SaxFilteringStrategy();

            // marking all columns as selected
            ChangeColumnSelectionStatus("StudentName");
            ChangeColumnSelectionStatus("Faculty");
            ChangeColumnSelectionStatus("FieldOfStudy");
            ChangeColumnSelectionStatus("Group");
            ChangeColumnSelectionStatus("EnteranceDate");
        }

        private void studentNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColumnSelectionStatus("StudentName");
        }

        private void ChangeColumnSelectionStatus(string column)
        {
            if (_query.Columns.Contains(column))
                _query.Columns.Remove(column);
            else
                _query.Columns.Add(column);
        }

        private void facultyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColumnSelectionStatus("Faculty");
        }

        private void fieldOfStudyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColumnSelectionStatus("FieldOfStudy");
        }

        private void groupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColumnSelectionStatus("Group");
        }

        private void enteranceDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColumnSelectionStatus("EnteranceDate");
        }

        private void saxApiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (saxApiRadioButton.Checked)
                _query.Strategy = new SaxFilteringStrategy();
        }

        private void domApiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (domApiRadioButton.Checked)
                _query.Strategy = new DomFilteringStrategy();
        }

        private void linqRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (linqRadioButton.Checked)
                _query.Strategy = new LinqFilteringStrategy();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (_document == null)
            {
                DisplayError("Документ не відкрит");
                return;
            }
            FiltredRows filtredRows = _document.FilterRows(_query);
            try
            {
                DisplayDataRowsContainer(filtredRows);
            } catch (DocumentValidationException)
            {
                dataGridView.Rows.Clear();
                DisplayError("Документ не містить xml або не відповідає схемі.");
            }
        }

        private void openXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chooseFileDialog = new OpenFileDialog();
            chooseFileDialog.AddExtension = true;
            chooseFileDialog.Filter = "xml-файли (*.xml)|*.xml|Усі файли (*.*)|*.*";

            if (chooseFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _document = new Document(chooseFileDialog.FileName, Files.tableSchema);
                    DisplayDataRowsContainer(_document);
                }
                catch (DocumentValidationException)
                {
                    DisplayError("Документ не містить xml або не відповідає схемі.");
                    return;
                }
            }
        }

        private void removeFiltersButton_Click(object sender, EventArgs e)
        {
            if (_document == null)
                return;
            try
            {
                DisplayDataRowsContainer(_document);
            }
            catch (DocumentValidationException)
            {
                dataGridView.Rows.Clear();
                DisplayError("Документ не містить xml або не відповідає схемі.");
            }
        }

        private void exportToHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentlyOnDisplay == null)
            {
                DisplayError("Документ не відкрит");
                return;
            }

            var chooseOutputFileDialog = new SaveFileDialog();
            chooseOutputFileDialog.AddExtension = true;
            chooseOutputFileDialog.Filter = "html-файл (*.html)|*.html";
            
            if (chooseOutputFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _currentlyOnDisplay.ExportToHtml(chooseOutputFileDialog.FileName);
                }
                catch (DocumentValidationException)
                {
                    dataGridView.Rows.Clear();
                    DisplayError("Документ не містить xml або не відповідає схемі.");
                }
            }
        }

        private void DisplayDataRowsContainer(DataRowsContainer dataRows)
        {
            dataGridView.Rows.Clear();

            foreach (DataRow row in dataRows)
            {
                dataGridView.Rows.Add(new object[] { row.StudentName, row.Faculty, row.FieldOfStudy,
                    row.Group, row.EnteranceDate});
            }

            _currentlyOnDisplay = dataRows;
        }

        private void DisplayError(string errorText)
        {
            MessageBox.Show(errorText, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}