using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.models
{
    public class Book
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }


        public Author Author { get; set; }
    }
}
