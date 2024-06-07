using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProjem.Models;

namespace NLayer.Repository.Seeds
{
    internal class OgrenciSeed : IEntityTypeConfiguration<Ogrenci>
    {


        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {

            builder.HasData(
                new Ogrenci { Id = 1, ad = "Ahmet", soyad = "test" },

                new Ogrenci {Id = 1, ad = "Mehmet", soyad = "test" },

                new Ogrenci {Id = 1, ad = "Ali", soyad = "test" }
                );
            //throw new NotImplementedException();


            /*Seed işlemi veri tabanına bir ekleme yapılırken manuel olarak bir ekleme yapabilmek için kullanılır. 
Bunu Migration ekleme yaparken de kullanabiliriz ama biz Seed aracılığıyla yapacağız.
public int ogrno { get; set; }
public string ad { get; set; }
public string soyad { get; set; }
public DateTime? dtarih { get; set; } 
public string cinsiyet { get; set; }
public string sinif { get; set; }
public int puan { get; set; }


*/
        }
    }
}
