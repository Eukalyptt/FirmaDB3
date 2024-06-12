using System;
using System.ComponentModel.DataAnnotations;


namespace firmadb.Models
{
    public class Tervisekontroll
    {
        [Key]
        public int HealthCheckID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Status { get; set; }

        public Employee Employee { get; set; }
    }
}
