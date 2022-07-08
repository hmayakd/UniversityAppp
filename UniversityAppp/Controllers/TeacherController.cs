using Microsoft.AspNetCore.Mvc;
using UniversityAppp.Models;
using UniversityAppp.Services;

namespace UniversityAppp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            var teachers = _teacherService.GetAll();
            return View(teachers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            _teacherService.Create(teacher);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            Teacher? teacher = _teacherService.Get(id);
            return View(teacher);
        }
        public IActionResult Edit(Guid id)
        {
            Teacher? teacher = _teacherService.Get(id);
            return View(teacher);
        }
        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            _teacherService.Update(teacher);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            Teacher? teacher = _teacherService.Get(id);
            return View(teacher);
        }
        [HttpPost]
        public IActionResult Delete(Teacher teacher)
        {
            _teacherService.Delete(teacher.Id);
            return RedirectToAction("Index");
        }
    }
}
