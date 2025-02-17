﻿namespace Books.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
    }

}
