


namespace OOPDesign.Jukebox;

public class CompactDiscStorage : IMusicStorage<CompactDisc>
{
    private readonly List<CompactDisc> _compactDiscs;

    public CompactDiscStorage(List<CompactDisc> compactDiscs)
    {
        this._compactDiscs = compactDiscs;
    }

    public CompactDiscStorage()
    {
        _compactDiscs = new List<CompactDisc>();
    }
    public IEnumerable<CompactDisc> Records => _compactDiscs;
}
