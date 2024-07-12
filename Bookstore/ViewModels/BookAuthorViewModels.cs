﻿using Bookstore.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.ViewModels
{
    public class BookAuthorViewModel
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public List<Author> Authors { get; set; }
    }
}