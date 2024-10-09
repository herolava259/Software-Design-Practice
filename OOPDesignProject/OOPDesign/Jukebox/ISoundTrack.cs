using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPDesign.Jukebox.JukeBoxEnum;

namespace OOPDesign.Jukebox
{
    public interface ISoundTrack<TRecord>
        where TRecord : Record
    {

        public IEnumerable<TRecord> GetAllRecord();

        public void Priotize(Guid recordId);

        public bool NextRecord();

        public bool SkipToRecord(Guid recordId);
        public bool ChoosePlayingType(EPlayingType playingType);
    }
}
