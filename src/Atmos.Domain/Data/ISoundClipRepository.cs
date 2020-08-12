using System.Collections.Generic;
using System.Threading.Tasks;
using Atmos.Domain.Model.Sound;

namespace Atmos.Domain.Data
{
    public interface ISoundClipRepository
    {
        Task<List<SoundClip>> GetSoundClips();
    }
}