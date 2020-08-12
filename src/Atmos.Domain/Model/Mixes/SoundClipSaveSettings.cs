using Atmos.Domain.Model.Sound;

namespace Atmos.Domain.Model.Mixes
{
    public class SoundClipSaveSettings
    {
        public string Id { get; set; } 
        public SoundClip SoundClip { get; set; }
        public decimal Volume { get; set; }
    }
}