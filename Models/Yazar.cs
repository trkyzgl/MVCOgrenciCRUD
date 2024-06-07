using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProjem.Models
{
    public class Yazar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int yazarno { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
}
