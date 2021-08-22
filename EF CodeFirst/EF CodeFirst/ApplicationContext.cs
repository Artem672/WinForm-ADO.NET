using System;
using System.Data.Entity;
using System.Linq;

namespace EF_CodeFirst
{
    public class ApplicationContext : DbContext
    {        
        public ApplicationContext()
            : base("name=ApllicationContext")
        {
        }

        public virtual DbSet<Game> games { get; set; }

    }
}