
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookDbcontext :DbContext
    {
        public BookDbcontext(DbContextOptions<BookDbcontext>options):base(options) { 
        
        }
        public DbSet<BookDetail> bookDetails{ get; set; }   
    }
}