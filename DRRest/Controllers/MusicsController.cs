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
        public ActionResult<IEnumerable<Music>> Get()
        {
            var musicList = repo.GetMusicList();
            if (musicList != null && musicList.Any()) 
            { 
                return Ok(musicList);
            }
            else
            {
                return NoContent();
            }
            
            return repo.GetMusicList();
        }

        //// GET api/<MusicsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MusicsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<MusicsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MusicsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
