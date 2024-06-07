using Microsoft.EntityFrameworkCore;
using MVCProjem.Models;

namespace MVCProjem.Data
{
    public class MVCProjemContext : DbContext
    {
        public MVCProjemContext(DbContextOptions<MVCProjemContext> options) : base(options)
        {

        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

    }
}