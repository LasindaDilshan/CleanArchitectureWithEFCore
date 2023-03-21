using CleanMovie.Application;
using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly Moviedbcontext _moviedbcontext;
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{ Id = 1 , Name = "Lord Of The rings" , Cost = 2} ,
             new Movie{ Id = 1 , Name = "Magic Elephent" , Cost = 1}
        };
        public MovieRepository(Moviedbcontext moviedbcontext) {
            _moviedbcontext = moviedbcontext;
        }

        public Movie CreateMovie(Movie movie)
        {
             _moviedbcontext.movies.Add(movie);
            _moviedbcontext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _moviedbcontext.movies.ToList();
        }
      
    }
}
