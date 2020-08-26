using System.Threading.Tasks;
using Atmos.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace Atmos.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoundClipsController : ControllerBase
    {
        private readonly ISoundClipRepository _soundClipRepository;
        
        public SoundClipsController(ISoundClipRepository soundClipRepository)
        {
            _soundClipRepository = soundClipRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSoundClips()
        {
            var clips = await _soundClipRepository.GetSoundClips();
            return Ok(clips);
        }
    }
}