using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Book_store_MVC_.Models
{
    public class Book
    {

        public int Id { get; set; }
        [Required]
        public string Tittle { get; set; }

        public string Discription { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
