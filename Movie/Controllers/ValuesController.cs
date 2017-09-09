using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Movie.Services;
using Movie.Models;

namespace Movie.Controllers
{
    
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IMovieService _service;
        public ValuesController(IMovieService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public List<MovieDetails> Get()
        {
            return _service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MovieDetails Get(int movieId)
        {
            return _service.GetMovie(movieId);
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]MovieDetails movie)
        {
            return _service.AddMovie(movie);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody]MovieDetails movie)
        {
            return _service.UpdateMovie(id, movie);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.DeleteMovie(id);
        }
    }
}
