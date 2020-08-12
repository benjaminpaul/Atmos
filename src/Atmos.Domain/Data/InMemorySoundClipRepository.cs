using System.Collections.Generic;
using System.Threading.Tasks;
using Atmos.Domain.Model.Sound;

namespace Atmos.Domain.Data
{
    public class InMemorySoundClipRepository : ISoundClipRepository
    {
        private static readonly List<SoundClip> SoundClips = new List<SoundClip>
        {
            new SoundClip { Id = "1", Title = "Waves", Description = "A description", FileName = "waves.mp3", IconFileName = "waves.png" }
        };
        
        public Task<List<SoundClip>> GetSoundClips()
        {
            return Task.FromResult(SoundClips);
        }
    }
}