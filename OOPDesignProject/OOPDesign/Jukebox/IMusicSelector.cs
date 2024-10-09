using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Jukebox;

public interface IMusicSelector
{ }
public interface IMusicSelector<TRecord>: IMusicSelector
    where TRecord : class
{

    public IEnumerable<TRecord> GetAllRecords(Expression<Func<TRecord, bool>>? condition = null);

    public TRecord? GetRecordByName(string name);

    public TRecord? GetRecordBy(Expression<Func<TRecord, bool>> condition);

    


}
