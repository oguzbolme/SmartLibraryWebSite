using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public List<Book> Books { get; set; }
    }
}
