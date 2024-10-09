using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Jukebox
{
    public class ClassicPlayingRequest : IPlayingRequest
    {
        private readonly Guid _recordId;
        private readonly string _name;
       
        private readonly Guid _ticketId;

        public ClassicPlayingRequest(Guid recordId, string recordName, decimal coin)
        {
            _name = recordName;
            Coin = coin;
            _recordId = recordId;
            _ticketId = Guid.NewGuid();
        }
        public Guid TicketId => _ticketId;

        public Guid RecordId => _recordId;

        public string Name => _name;

        public decimal Coin { get; private init; }
    }
}
