using Microsoft.AspNetCore.Mvc;
using UniversityAppp.Models;
using UniversityAppp.Services;

namespace UniversityAppp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentService.Create(student);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            Student? student = _studentService.Get(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _studentService.Update(student);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            Student? student = _studentService.Get(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _studentService.Delete(student.Id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            Student? student = _studentService.Get(id);
            return View(student);
        }
    }
}
