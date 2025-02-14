﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }

        public Book()
        {
            Author = new Author();
        }
        public Book(int id, string title, string description, Author author)
           : this() 
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
        }
    }
}
