using Microsoft.AspNetCore.Mvc;
using Studentinfo.Data;
using Studentinfo.Models.Domain;
using Studentinfo.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Studentinfo.Controllers
{
    public class AdminCourseController : Controller
    {
        private readonly StudentDbcontext _context;

        public AdminCourseController(StudentDbcontext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AdminCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var course = new Course
                {
                    CourseName = model.CourseName,
                    CourseDescription = model.CourseDescription
                };

                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null) return NotFound();

            var model = new AdminCourseViewModel
            {
                Id = course.Id,
                CourseName = course.CourseName,
                CourseDescription = course.CourseDescription
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AdminCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var course = await _context.Courses.FindAsync(model.Id);
                if (course == null) return NotFound();

                course.CourseName = model.CourseName;
                course.CourseDescription = model.CourseDescription;
                await _context.SaveChangesAsync();

                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
    }
}
