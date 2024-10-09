using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Jukebox
{
    public interface IPlayingRequest
    {
        public Guid TicketId { get; }

        public Guid RecordId { get; }

        public string Name { get; }
    }
}
