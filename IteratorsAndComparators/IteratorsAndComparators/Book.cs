﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public Book(string title, int year, params string[] authros)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authros;
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }
    }
}
