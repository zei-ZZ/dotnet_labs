using TP4.Models;

namespace TP4.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMoviesByGenre(string genreName);
        IEnumerable<Movie> GetAllMoviesOrderedByTitle();
        IEnumerable<Movie> GetMoviesByGenreId(Guid genreId);
    }
}
