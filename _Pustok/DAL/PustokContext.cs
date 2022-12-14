using _Pustok.Models;
using Microsoft.EntityFrameworkCore;

namespace _Pustok.DAL
{
    public class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<BtnPromotion> BtnPromotions { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TopPromotion> TopPromotions { get; set; }
    }
}
