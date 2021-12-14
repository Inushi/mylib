using mylib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib.Database
{
    class BooksContext : DbContext
    {

        public DbSet<Books> books { get; set; }

    }
}
