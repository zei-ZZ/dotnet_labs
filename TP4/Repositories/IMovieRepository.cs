using TP4.Models;

namespace TP4.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMoviesByGenre(string genreName);
        IEnumerable<Movie> GetAllMoviesOrderedByTitle();
        IEnumerable<Movie> GetMoviesByGenreId(Guid genreId);
        IEnumerable<Movie> GetAllMovies();
        void Add(Movie m);
    }
}
