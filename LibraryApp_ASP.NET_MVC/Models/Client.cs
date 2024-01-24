using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApp_ASP.NET_MVC.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }

        //create a validation
        [MaxLength(13), MinLength(13)]
        //an error appear when adding diacritical marks or other unnecessary marks
        [RegularExpression("^[0-9]*$", ErrorMessage ="CNP invalid")]
        public string CNP { get; set; }

        //connection with Loan
        public virtual ICollection<Loan> Loans { get; set; }
    }
}