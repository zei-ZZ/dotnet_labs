using TP4.Models;
using TP4.Repositories;

namespace TP4.Services
{
    public class MovieService:IMovieService
    {
        public readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> GetMoviesByGenre(string genreName)
        {
            return _movieRepository.GetMoviesByGenre(genreName);
        }
        public IEnumerable<Movie> GetAllMoviesOrderedByTitle()
        {
            return _movieRepository.GetAllMoviesOrderedByTitle();
        }
        public IEnumerable<Movie> GetMoviesByGenreId(Guid genreId)
        {
            return _movieRepository.GetMoviesByGenreId(genreId);
        }
        public IEnumerable<Movie> GetAllMovies() { return _movieRepository.GetAllMovies();}
        public void Add(Movie m)
        {
            _movieRepository.Add(m);
        }
    }
}
