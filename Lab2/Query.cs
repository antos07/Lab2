namespace Lab2
{
    public class Query
    {
        public string Words { get; set; } = "";
        public HashSet<string> Columns { get; set; } = new HashSet<string>();
        public IFilteringStrategy? Strategy { get; set; }

        public IEnumerable<DataRow> Execute(string filename)
        {
            if (Strategy == null) 
                return Enumerable.Empty<DataRow>();
            return Strategy.Filter(filename, Words, Columns);
        }
    }
}