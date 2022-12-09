namespace Lab2
{
    public interface IFilteringStrategy
    {
        public IEnumerable<DataRow> Filter(string filename, string words, HashSet<string> columns);
    }
}