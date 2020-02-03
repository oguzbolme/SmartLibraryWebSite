using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class MultipleViewModel
    {
        public User user { get; set; }
        public Book book { get; set; }
        public Author author { get; set; }
        public Library library { get; set; }
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<Library> Libraries { get; set; }
        public string isbn { get; set; }

        public MultipleViewModel()
        {
            user = new User();
            book = new Book();
            author = new Author();
            library = new Library();
            Books = new List<Book>();
            Authors = new List<Author>();
            Libraries = new List<Library>();
        }
    }
}
