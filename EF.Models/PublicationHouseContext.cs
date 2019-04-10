using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class PublicationHouseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        public string Title { get; set; }
    }
}
