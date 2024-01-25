using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApp_ASP.NET_MVC.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int ClientId { get; set; }
        public int BookId { get; set; }

        //constraint when miss the date
        [Display(Name= "Loan date"), DataType(DataType.Date)] 
        public DateTime LoanDate { get; set; }

        //connection with each class
        public virtual Client client { get; set; }
        public virtual Book book { get; set; }
    }
}