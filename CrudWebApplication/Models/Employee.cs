using System.ComponentModel.DataAnnotations;

namespace CrudWebApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

    }
}
