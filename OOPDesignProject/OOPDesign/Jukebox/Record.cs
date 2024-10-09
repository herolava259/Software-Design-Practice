using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Jukebox
{
    public abstract class Record
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int PublishedYear { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Artist { get; set; }


        public TimeSpan Time { get; set; }

        public byte[] Content { get; set; }


    }
}
