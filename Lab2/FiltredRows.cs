namespace Lab2
{
    public class FiltredRows : DataRowsContainer
    {
        private string _filename;
        private Query _query;

        public FiltredRows(string filename, Query query)
        {
            _filename = filename;
            _query = query;
        }

        public override IEnumerator<DataRow> GetEnumerator()
        {
            return _query.Execute(_filename).GetEnumerator();
        }
    }
}