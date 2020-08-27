using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Atmos.Domain.Model.Mixes;
using Microsoft.AspNetCore.Mvc;

namespace Atmos.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MixesController : ControllerBase
    {
        private List<Mix> Mixes { get; set; } =  new List<Mix>
        {
            new Mix { Id = "1", Title = "Mix 1", CreatedDate = DateTime.Now, SoundClipMixSettings = new List<SoundClipMixSettings>
            {
                new SoundClipMixSettings { Id = "1", Volume = (decimal) 0.5 },
                new SoundClipMixSettings { Id = "2", Volume = (decimal) 0.5 },
            }},
            new Mix { Id = "2", Title = "Mix 2", CreatedDate = DateTime.Now, SoundClipMixSettings = new List<SoundClipMixSettings>
            {
                new SoundClipMixSettings { Id = "1", Volume = (decimal) 0.5 },
                new SoundClipMixSettings { Id = "2", Volume = (decimal) 0.5 },
            }}
        };
        
        public MixesController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetMix(string mixId)
        {
            return Ok(Mixes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMix([FromBody]Mix mix)
        {
            return Ok(); // Should be created.
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMix([FromBody] Mix mix)
        {
            return Ok();
        }
    }
}