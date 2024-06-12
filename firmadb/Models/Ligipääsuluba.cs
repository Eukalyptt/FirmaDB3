using firmadb.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace firmadb.Models
{
    public class Ligipääasuluba
    {
        [Key]
        public int AccessID { get; set; }
        public int EmployeeID { get; set; }
        public string Permissions { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
