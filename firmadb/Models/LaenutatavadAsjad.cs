using System.ComponentModel.DataAnnotations;

namespace firmadb.Models
{
    public class LaenutatavadAsjad
    {
        [Key]
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }

        public ICollection<Laenutus> Laenutused { get; set; }
    }
}