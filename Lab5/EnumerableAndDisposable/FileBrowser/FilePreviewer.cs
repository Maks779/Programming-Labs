namespace FileBrowser;

public class FilePreviewer : IDisposable
{
    private readonly StreamReader _reader;

    public FilePreviewer(string path)
    {
        _reader = new StreamReader(path);
    }

    public string? GetNextLine()
    {
        return _reader.ReadLine();
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}