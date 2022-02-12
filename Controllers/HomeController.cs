using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyASPNetCoreMVC.Controllers
{
    public class HomeController: Controller
    {
        //public string Index()
        //{
        //    return "This is Index action from MVC Controller";
        //}

        //##Without Dipendancy Injection
        //public JsonResult Index()
        //{
        //    TestStudentRepository repository = new TestStudentRepository();
        //    List<Student> allStudentDetails = repository.GetAllStudent();
        //    return Json(allStudentDetails);
        //}
        //public JsonResult GetStudentDetails(int Id)
        //{
        //    TestStudentRepository repository = new TestStudentRepository();
        //    Student studentDetails = repository.GetStudentById(Id);
        //    return Json(studentDetails);
        //}

        //##With Dependancy Injection
        //private readonly IStudentRepository _repository = null;
        //public HomeController(IStudentRepository repository)
        //{
        //    _repository = repository;
        //}
        //public JsonResult Index()
        //{
        //    List<Student> allStudentDetails = _repository.GetAllStudent();
        //    return Json(allStudentDetails);
        //}
        //public JsonResult GetStudentDetails(int Id)
        //{
        //    Student studentDetails = _repository.GetStudentById(Id);
        //    return Json(studentDetails);
        //}
        //Action Method Injectoin
        public JsonResult Index([FromServices] IStudentRepository repository)
        {
            List<Student> allStudentDetails = repository.GetAllStudent();
            return Json(allStudentDetails);
        }
    }
}
