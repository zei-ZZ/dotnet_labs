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
        public IEnumerable<Movie> GetAllMovies()
        {
            return _dbContext.Movies.ToList();
        }
        public void Add(Movie m)
        {

            m.Id = new Guid();
            string filename = UploadFile(m);
            m.Photo = filename;
            _dbContext.Movies.Add(m);
            _dbContext.SaveChanges();
        }
        private string UploadFile(Movie m)
        {
            string file = string.Empty;
            if (m.ImageFile != null)
            {
                string filePath = Path.Combine("uploads", Guid.NewGuid().ToString() + m.ImageFile.FileName);
                file = filePath;
                using (var filestream = new FileStream(Path.Combine("wwwroot", filePath), FileMode.Create))
                {
                    m.ImageFile.CopyTo(filestream);
                }
            }
            return file;
        }
    }
}
