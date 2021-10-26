﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models
{
    public class BookModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Series { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Duration { get; set; }
        public string Rating { get; set; }
        public string Language { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public string TextField => $"\"{Name}\", [{Author}]";
    }
}