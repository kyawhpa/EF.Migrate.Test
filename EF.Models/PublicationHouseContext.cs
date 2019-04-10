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
        public PublicationHouseContext() : base("PublicationHouse") { }

        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        public string Title { get; set; }
    }
}
//migrate EF.Models.dll /connectionString="Server=localhost;Database=PublicationHouse;User Id=sa;Password=Pa$$w0rd;" /connectionProviderName="System.Data.SqlClient"

//migrate.exe EF.Models.dll /startupConfigurationFile= "D:\Playground\EF.Migrate.Test\EF.Models\bin\Debug\EF.Models.dll.config" - verbose - force