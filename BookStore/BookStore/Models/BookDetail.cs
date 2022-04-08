using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class BookDetail
    {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        public int BookName { get; set; }

        public int BookType { get; set; }

        public int BookDesc { get; set; }

        public int Author { get; set; }

    }
}
