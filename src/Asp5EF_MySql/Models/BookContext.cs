
using Asp5EF;
using Microsoft.Framework.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Asp5EF.Models
{
    [DbConfigurationType(typeof(MyDbConfiguration))]
    public class BookContext : DbContext
    {
        public BookContext(IConfiguration config)
			: base(config["Data:DefaultConnection:ConnectionString"])
		{
            Database.SetInitializer<BookContext>(null);
        }
        public DbSet<Author> Authors { get; set; }
       // public DbSet<Book> Books { get; set; }
    }
}