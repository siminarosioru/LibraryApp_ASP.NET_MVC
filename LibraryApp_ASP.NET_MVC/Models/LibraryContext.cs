using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryApp_ASP.NET_MVC.Models
{
    //create the LibraryContext class for the connection
    //then inherit Dbconetxt, using Entity Framework
    public class LibraryContext:DbContext
    {
        //here the connection is created, using Entity Framework => then the database will be created after build
        //constructor
        public LibraryContext() : base("LibraryContext") { }

        //datasets for each class
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
    }
}
