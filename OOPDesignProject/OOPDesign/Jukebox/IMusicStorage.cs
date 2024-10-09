

namespace OOPDesign.Jukebox;

public interface IMusicStorage<out TRecord>
    where TRecord : Record
{

    public IEnumerable<TRecord> Records { get; }
}
