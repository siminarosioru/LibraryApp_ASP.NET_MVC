using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryApp_ASP.NET_MVC.Models
{
    public class LibraryContext:DbContext
    {
        //constructor
        public LibraryContext() : base("LibraryContext") { }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
    }
}