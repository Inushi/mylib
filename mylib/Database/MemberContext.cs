using mylib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib.Database
{
    class MemberContext : DbContext
    {

        public DbSet<Member> members { get; set; }


    }
}
