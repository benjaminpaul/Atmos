using System;
using System.Collections.Generic;

namespace Atmos.Domain.Model.Mixes
{
    public class Mix
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public IEnumerable<SoundClipMixSettings> SoundClipMixSettings { get; set; } 
    }
}