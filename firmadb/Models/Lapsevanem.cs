using firmadb.Models;
using System.ComponentModel.DataAnnotations;

namespace firmadb.Models
{
    public class Lapsevanem
    {
        [Key]
        public int ParentID { get; set; }
        public int ParentEmployee { get; set; }
        public int ChildID { get; set; }
        public string Relationship { get; set; }

        public Employee Employee { get; set; }
        public Lapsed Child { get; set; }
    }
}
