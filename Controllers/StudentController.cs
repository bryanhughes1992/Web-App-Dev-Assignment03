using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASSIGNMENT03_BRYANHUGHES.Models;

namespace ASSIGNMENT03_BRYANHUGHES.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        [Route("/api/Student")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/Student/List")]
        public ActionResult List()
        {
            StudentDataController controller = new StudentDataController();
            IEnumerable<Student> Students = controller.ListStudents();
            return View(Students);
        }

        [HttpGet]
        [Route("api/Student/Show/{id}")]
        public ActionResult Show(int id)
        {
            StudentDataController controller = new StudentDataController();
            return View();
        }
    }
}