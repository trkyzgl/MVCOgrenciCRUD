using Microsoft.EntityFrameworkCore;
using MVCProjem.Models;

namespace MVCProjem.Data
{
    public class MVCProjemContext : DbContext
    {
        public MVCProjemContext(DbContextOptions<MVCProjemContext> options) : base(options)
        {

        }

        public DbSet<OgrenciModel> Ogrenciler { get; set; }
        public DbSet<KitapModel> Kitaplar { get; set; }
        public DbSet<YazarModel> Yazarlar { get; set; }

    }
}