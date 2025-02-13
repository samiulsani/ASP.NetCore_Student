using System.ComponentModel.DataAnnotations;

namespace Studentinfo.Models.Domain
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
