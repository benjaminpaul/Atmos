using System.Collections.Generic;
using System.Threading.Tasks;
using Atmos.Domain.Model.Sound;

namespace Atmos.Domain.Data
{
    public class InMemorySoundClipRepository : ISoundClipRepository
    {
        private static readonly List<SoundClip> SoundClips = new List<SoundClip>
        {
            new SoundClip { Id = "1", Title = "Waves", Description = "A description", FileName = "waves.mp3", IconFileName = "waves.png" },
            new SoundClip { Id = "2", Title = "Birds", Description = "Birds tweeting", FileName = "birds.mp3", IconFileName = "birds.png" },
            new SoundClip { Id = "3", Title = "Rain", Description = "Rain falling", FileName = "rain.mp3", IconFileName = "rain.png" },
            new SoundClip { Id = "4", Title = "Wind", Description = "Wind blowing", FileName = "wind.mp3", IconFileName = "wind.png" },
            new SoundClip { Id = "5", Title = "Thunder", Description = "Thunder", FileName = "thunder.mp3", IconFileName = "thunder.png" }
        };
        
        public Task<List<SoundClip>> GetSoundClips()
        {
            return Task.FromResult(SoundClips);
        }
    }
}