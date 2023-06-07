using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProjem.Models
{
    public class OgrenciModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ogrno { get; set; }
        
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime? dtarih { get; set; } 
        public string cinsiyet { get; set; }
        public string sinif { get; set; }
        public int puan { get; set; }

    }
}
