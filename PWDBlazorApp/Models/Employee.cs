using System.ComponentModel.DataAnnotations.Schema;

namespace PWDBlazorApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Salary { get; set; }
        public string? ImageURL { get; set; }
        
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Salary} - {Address} -{ ImageURL} -{DepartmentID}";
        }
    }
}
