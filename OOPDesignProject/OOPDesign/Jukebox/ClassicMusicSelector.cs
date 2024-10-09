using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;


namespace OOPDesign.Jukebox;

public class ClassicMusicSelector : IMusicSelector<CompactDisc>
{
    private readonly IMusicStorage<CompactDisc> _storage;

    public ClassicMusicSelector(IMusicStorage<CompactDisc> storage)
    {
        this._storage = storage;
    }
    public IEnumerable<CompactDisc> GetAllRecords(Expression<Func<CompactDisc, bool>>? condition = null)
    {
        if (condition == null)
            return _storage.Records.ToList();
        return _storage.Records.Where(condition.Compile()).ToList();
    }

    public CompactDisc? GetRecordBy(Expression<Func<CompactDisc, bool>> condition)
    {
        return _storage.Records.FirstOrDefault(condition.Compile());
    }

    public CompactDisc? GetRecordByName(string name)
    {
        return _storage.Records.FirstOrDefault(c => c.Name == name);
    }

}
