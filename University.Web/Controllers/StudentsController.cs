using System.Web.Mvc;
using University.Web.Models;

namespace University.Web.Controllers
{
    public class StudentsController : Controller
    {
        //  Students/Index {controller}/{action}
        [HttpGet]
        public ActionResult Index()
        {
            return View(); //Vista igual que la acción
            //return View("Index"); //Vista por nombre
            //return View("Account/Login"); //Vista por carpeta/nombre
        }

        // Students/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            var id = student.ID;
            var firstMidName = student.FirstMidName;
            var lastName = student.LastName;
            var enrollmentDate = student.EnrollmentDate;

            return View();
        }
    }
}