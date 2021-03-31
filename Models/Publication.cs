using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_store_MVC_.Models
{
    public class Publication
    {

        public int Id { get; set; }
        [Required]
        public string Books_Copies { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
