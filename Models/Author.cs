﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_store_MVC_.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email_Id { get; set; }
        public string Address { get; set; }
        [Required]
        public string Mobile_Number { get; set; }
    }
}
