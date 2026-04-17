public class CollectionAnalyzer
{
    private readonly IEnumerable<int>? _collection;

    public CollectionAnalyzer(IEnumerable<int>? collection)
    {
        _collection = collection;
    }

    public (int? Min, int? Max, int? Range) FindRange()
    {
        if (_collection == null || !_collection.Any())
            return (null, null, null);

        int min = _collection.Min();
        int max = _collection.Max();

        return (min, max, max - min);
    }

    public (int? Min, int? Max, int? Range) FindRange((int Start, int End) position)
    {
        if (position.End < position.Start)
            throw new ArgumentException("End position cannot be lower than start position.");

        if (_collection == null || !_collection.Any())
            return (null, null, null);

        var filtered = _collection.Where(x => x >= position.Start && x <= position.End);

        if (!filtered.Any())
            return (null, null, null);

        int min = filtered.Min();
        int max = filtered.Max();

        return (min, max, max - min);
    }

    public void Deconstruct(out int? min, out int? max, out int? range)
    {
        var result = FindRange();
        min = result.Min;
        max = result.Max;
        range = result.Range;
    }
}
