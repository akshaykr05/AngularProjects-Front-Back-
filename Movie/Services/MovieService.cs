using Movie.Models;
using Movie.Repositories;
using System.Collections.Generic;

namespace Movie.Services
{
    public interface IMovieService
    {
        List<MovieDetails> GetAll();
        MovieDetails GetMovie(int movieId);
        bool AddMovie(MovieDetails movie);
        bool UpdateMovie(int movieID, MovieDetails movie);
        bool DeleteMovie(int id);
    }
    public class MovieService : IMovieService
    {
        private IMovieRepository _repository;
        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }
        public bool AddMovie(MovieDetails movie)
        {
            return _repository.AddMovie(movie);
        }

        public bool DeleteMovie(int id)
        {
            return _repository.DeleteMovie(id);
        }

        public MovieDetails GetMovie(int movieId)
        {
            return _repository.GetMovie(movieId);
        }

        public List<MovieDetails> GetAll()
        {
            return _repository.GetAll();
        }

        public bool UpdateMovie(int id, MovieDetails movie)
        {
            return _repository.UpdateDetail(id, movie);
        }
    }
}