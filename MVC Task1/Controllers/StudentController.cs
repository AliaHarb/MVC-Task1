using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Models;

namespace MVC_Task1.Controllers
{
    public class StudentController : Controller
    {
        //Student/Index
        public IActionResult Index()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> StudentListModel = studentBL.GetAll();

            return View("Index", StudentListModel);
        }

        //Student/Details?id=2
        public IActionResult Details(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student StudentModel = studentBL.GetById(id);
            return View("Details", StudentModel);
        }



    }
}
