using System.Collections.Generic;

namespace MFOWebCoreMaster.Models
{ 
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}