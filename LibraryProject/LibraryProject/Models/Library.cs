using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class Library
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public List<Book> Books { get; set; }
    }
}
