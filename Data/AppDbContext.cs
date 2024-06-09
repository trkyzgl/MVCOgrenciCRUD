using Microsoft.EntityFrameworkCore;
using MVCProjem.Models;
using System.Reflection;

namespace MVCProjem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<Yazar> Yazarlar { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Burada Configuration yapmak yerine , Configuration assmbly lerimizin içinde yaptığımız Configurationları buraya çekebiliriz*/
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            /*Product ve Category için Seed oluşturduk ama farklılık olması için ProductFeature için burda işlem yapalım*/
            modelBuilder.Entity<Student>().HasData(
                new Student()
            {
                Id = 1,
                Name= "Tarık",
                Surname="Yuzgul"
            },
            new Student()
            {
                Id = 2,
                Name = "DenemeAd",
                Surname = "DenemeSoyad"
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}