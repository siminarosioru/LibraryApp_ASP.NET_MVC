using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApp_ASP.NET_MVC.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }

        //constaint
        [Range(1200,2022), Display(Name="Year of appearance")]
        public int YearAppearance { get; set; }
    }
}