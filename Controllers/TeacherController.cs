using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASSIGNMENT03_BRYANHUGHES.Models;

// SOME CODE WAS USED FROM CHRSTINE BITTLE @ https://github.com/christinebittle/BlogProject_1.git

namespace ASSIGNMENT03_BRYANHUGHES.Controllers
{
    public class TeacherController : Controller
    {
        [HttpGet]
        [Route("api/Teacher")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/Teacher/List")]
        public ActionResult List()
        {
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers();
            return View(Teachers);
        }

        [HttpGet]
        [Route("api/Teacher/Show/{id}")]
        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);
            return View(NewTeacher);
        }

        [HttpPost]
        [Route("api/Teacher/ConfirmDelete/{id}")]
        public ActionResult ConfirmDelete(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);
            return View(NewTeacher);
        }

        [HttpPost]
        [Route("api/Teacher/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            int result = controller.DeleteTeacher(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        [Route("api/Teacher/Add")]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("api/Teacher/Create/{firstName}/{lastName}/{employeeNumber}/{hireDate}/{salary}")]
        public ActionResult Create(string firstName, string lastName, string employeeNumber, string hireDate, decimal salary)
        {
            Teacher teacher = new Teacher();
            teacher.TeacherFname =  firstName;
            teacher.TeacherLname = lastName;
            teacher.EmployeeNumber = employeeNumber;
            teacher.Salary = salary;

            teacher.HireDate = Convert.ToDateTime( hireDate );
            TeacherDataController controller = new TeacherDataController();

            controller.AddTeacher( teacher );
            return RedirectToAction("List");
        }
    }
}