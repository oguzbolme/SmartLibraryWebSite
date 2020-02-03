using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageURL { get; set; }
        public int authorID { get; set; }
        public string categoryName { get; set; }
        public int libraryID { get; set; }
    }
}
