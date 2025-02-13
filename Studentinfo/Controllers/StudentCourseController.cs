using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentinfo.Data;
using Studentinfo.Models.Domain;

namespace Studentinfo.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly StudentDbcontext studentDbcontext;

        public StudentCourseController(StudentDbcontext studentDbcontext)
        {
            this.studentDbcontext = studentDbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var students= await studentDbcontext.Students.ToListAsync();
            var courses= await studentDbcontext.Courses.ToListAsync();
            ViewBag.Students = students;
            ViewBag.Courses = courses;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AssignCourse(int StudentId, int CourseId)
        {
            var student = await studentDbcontext.Students.FindAsync(StudentId);
            var course = await studentDbcontext.Courses.FindAsync(CourseId);

            if (student == null || course == null)
            {
                TempData["ErrorMessage"] = "Invalid student or course selection.";
                return RedirectToAction("Index");
            }

            var existingAssignment = await studentDbcontext.studentCourses
                .FirstOrDefaultAsync(sc => sc.StudentId == StudentId && sc.CourseId == CourseId);

            if (existingAssignment == null)
            {
                var studentCourse = new StudentCourse
                {
                    StudentId = StudentId,
                    CourseId = CourseId
                };

                studentDbcontext.studentCourses.Add(studentCourse);
                await studentDbcontext.SaveChangesAsync();
                TempData["SuccessMessage"] = "Course assigned successfully!";
            }
            else
            {
                TempData["ErrorMessage"] = "This student is already assigned to this course.";
            }

            return RedirectToAction("AssignedCourses");
        }

        public async Task<IActionResult> AssignedCourses()
        {
            var assignedCourses = await studentDbcontext.studentCourses
                .Include(sc => sc.Student)
                .Include(sc => sc.Course)
                .ToListAsync();

            return View(assignedCourses);
        }


    }
}
