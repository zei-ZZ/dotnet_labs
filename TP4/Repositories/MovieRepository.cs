using TP4.Models;

namespace TP4.Repositories
{
    public class MovieRepository:IMovieRepository
    {
        private readonly AppDbContext _dbContext;

        public MovieRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Movie> GetMoviesByGenre(string genreName)
        {
            return _dbContext.Movies
                .Where(movie=>movie.Genre.Name== genreName)
                .ToList();
        }
        public IEnumerable<Movie> GetAllMoviesOrderedByTitle()
        {
            return _dbContext.Movies
            .OrderBy(movie => movie.Name)
            .ToList();
        }
        public IEnumerable<Movie> GetMoviesByGenreId(Guid genreId)
        {
            return _dbContext.Movies
           .Where(movie => movie.GenreId == genreId)
           .ToList();
        }
    }
}
