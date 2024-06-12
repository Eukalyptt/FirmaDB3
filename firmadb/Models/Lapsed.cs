using System;
using System.ComponentModel.DataAnnotations;

namespace firmadb.Models
{
    public class Lapsed
    {
        [Key]
        public int ChildID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Lapsevanem> Lapsevanemad { get; set; }
    }
}
