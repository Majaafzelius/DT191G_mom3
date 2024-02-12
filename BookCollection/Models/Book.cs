﻿namespace BookCollection.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorID { get; set; }
        public Author? Author { get; set; }
    }
}
