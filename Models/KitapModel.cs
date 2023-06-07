using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProjem.Models
{
    public class KitapModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kitapno { get; set; }
        public string ad { get; set; }
        public int sayfasayisi { get; set; }
        public int puan { get; set; }
        public int yazarno { get; set; }
        public int turno { get; set; }
    }
}
