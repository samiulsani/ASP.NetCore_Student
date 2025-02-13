using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Studentinfo.Models.Domain
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public string? Department { get; set; }

        [Required]
        public string? Session {  get; set; }

        [Required]
        public string? Section {  get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display (Name="Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name="Profile Image")]
        public Byte[]? Image { get; set; }
        [NotMapped]
        [Display (Name ="Upload Image")]
        public IFormFile? ImageFile { get; set; }


        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
