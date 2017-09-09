using Movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie.Repositories
{
    public interface IMovieRepository
        {
            List<MovieDetails> GetAll();
            MovieDetails GetMovie(int movieId);
            bool AddMovie(MovieDetails movie);
            bool DeleteMovie(int id);
            bool UpdateDetail(int movieId, MovieDetails movie);
        }
    public class MovieRepository : IMovieRepository
    {
        private MovieDbContext _context;
        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public bool AddMovie(MovieDetails movie)
        {
            try{
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        public bool DeleteMovie(int id)
        {
            try
            {
                MovieDetails movie = _context.Movies.FirstOrDefault(m => m.id == id);
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public MovieDetails GetMovie(int movieId)
        {
            MovieDetails movie = _context.Movies.FirstOrDefault(m => m.id==movieId);
            return movie;
        }

        public List<MovieDetails> GetAll()
        {
            return _context.Movies.ToList();
        }

        public bool UpdateDetail(int id, MovieDetails movie)
        {
            try { 
            MovieDetails movies = _context.Movies.FirstOrDefault(m => m.id == id);
            movies.comment = movie.comment;
            return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
