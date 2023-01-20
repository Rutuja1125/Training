using System.Reflection;

namespace StudentProject1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DepartmentId { get; set; }
        public Gender gender { get; set; }
    }
}
