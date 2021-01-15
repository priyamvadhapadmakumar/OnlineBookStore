using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class Books //table in database
    {
        [Key] //primary key - BookId
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public string Edition { get; set; }
        public DateTime YearPublished { get; set; }
        public int Price { get; set; }
    }
}
