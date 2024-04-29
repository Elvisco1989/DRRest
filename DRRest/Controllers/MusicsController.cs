using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private Music? music;

        private MusicRepository repo;

        public MusicsController(MusicRepository repo)
        {
            this.repo = repo;
        }



        // GET: api/<MusicsController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<Music>> Get(string? title=null, string? artist=null)
        {
            var musicList = repo.GetMusicList(title,artist);
            if (musicList != null && musicList.Any()) 
            { 
                return Ok(musicList);
            }
            else
            {
                return NoContent();
            }
            
            
        }

        //// GET api/<MusicsController>/5
        [HttpGet("{id}")]
        public Music? Get(int id)
        {
           Music? music= repo.GetBy(id);
            return music;
        }

        // POST api/<MusicsController>
        [HttpPost]
        public void Post([FromBody] Music music)
        {
            repo.AddMusic(music);
        }

        //// PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Music music)
        {
            repo.Update(id, music);
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
