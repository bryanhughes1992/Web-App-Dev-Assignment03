using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASSIGNMENT03_BRYANHUGHES.Models;

namespace ASSIGNMENT03_BRYANHUGHES.Controllers
{
    public class ClassesController : Controller
    {
        [HttpGet]
        [Route("api/Classes")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/Classes/List")]
        public ActionResult List()
        {
            ClassesDataController controller = new ClassesDataController();
            IEnumerable<Classes> Classes = controller.ListClasses();
            return View(Classes);
        }
    }




}