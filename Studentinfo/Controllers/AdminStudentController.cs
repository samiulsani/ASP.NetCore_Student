using Microsoft.AspNetCore.Mvc;
using Studentinfo.Data;
using Studentinfo.Models.ViewModel;
using Studentinfo.Models.Domain;

namespace Studentinfo.Controllers
{
    public class AdminStudentController : Controller
    {
        private readonly StudentDbcontext studentDbcontext;

        public AdminStudentController(StudentDbcontext studentDbcontext)
        {
            this.studentDbcontext = studentDbcontext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentRequest addStudentRequest)
        {
            var student = new Student
            {
                Name = addStudentRequest.Name,
                Department = addStudentRequest.Department,
                Session = addStudentRequest.Session
            };

            studentDbcontext.Students.Add(student);
            studentDbcontext.SaveChanges();

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List() {
            var students=studentDbcontext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = studentDbcontext.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                var editStudentRequest = new EditStudentRequest
                {
                    Id = student.Id,
                    Name = student.Name,
                    Department = student.Department,
                    Session = student.Session
                };
                return View(editStudentRequest);
            }
            return View(null);
        }

        [HttpPost]
        public IActionResult Edit(EditStudentRequest editStudentRequest)
        {
            var student = new Student
            {
                Id=editStudentRequest.Id,
                Name = editStudentRequest.Name,
                Department = editStudentRequest.Department,
                Session = editStudentRequest.Session
            };
            var existingStudent=studentDbcontext.Students.Find(student.Id);
            if (existingStudent != null) 
            { 
            existingStudent.Name = student.Name;
                existingStudent.Department = student.Department;
                existingStudent.Session = student.Session;
                studentDbcontext.SaveChanges();
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(EditStudentRequest editStudentRequest) { 
            var student=studentDbcontext.Students.Find(editStudentRequest.Id);
            if (student != null)
            {
                studentDbcontext.Students.Remove(student);
                studentDbcontext.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
