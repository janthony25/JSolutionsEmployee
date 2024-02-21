using System.ComponentModel.DataAnnotations;

namespace JSolutionsEmployee.Models
{
    public class Employee
    {
        [Key]
        public int employeeID { get; set; }
        [Required]
        public string employeeName { get; set; }
        public string position { get; set; }
        public DateTime DateHired { get; set; }
    }
}
