using CleanMovieDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class Moviedbcontext : DbContext

    {
       public Moviedbcontext(DbContextOptions<Moviedbcontext> options)
            :   base(options)
        { 

        }
        public DbSet<Movie> movies { get; set; }
    }
}
