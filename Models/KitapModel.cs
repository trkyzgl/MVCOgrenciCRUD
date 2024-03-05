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
        public int yazarno { get; set; }
        public string turno { get; set; }
        public  bool verildimi { get; set; }
        public int ogrno { get; set; }
        public string VerilisTarihi { get; set; }

    }
}
