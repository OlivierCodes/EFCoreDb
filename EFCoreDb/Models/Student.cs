using System.ComponentModel.DataAnnotations;

namespace EFCoreDb.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<EmailAdress> Emails { get; set; }
        public ICollection<Course> Courses { get; set; }
        

    }
}
