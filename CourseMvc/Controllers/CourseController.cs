using CourseMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseMvc.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course{CId=1,CName="Web Development", CFee=10000, Technology="Computer Science",CStartDate=new DateTime(day:12,month:1,year:2023),CEndDate=new DateTime(day:01,month:04,year:2023)},
            new Course{CId=2,CName="CyberSecurity", CFee=12000, Technology="IT",CStartDate=new DateTime(day:22,month:1,year:2022),CEndDate=new DateTime(day:05,month:04,year:2022)},
            new Course{CId=3,CName="C# .NET", CFee=8000, Technology="Computer Science",CStartDate=new DateTime(day:31,month:01,year:2023),CEndDate=new DateTime(day:10,month:06,year:2023)},
            new Course{CId=4,CName="Cloud Computing", CFee=15000, Technology="Computer Science",CStartDate=new DateTime(day:01,month:11,year:2023),CEndDate=new DateTime(day:01,month:04,year:2024)}
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course cse)
        {
           if(ModelState.IsValid)
            {
                courses.Add(cse);
                return RedirectToAction("Index");
            }
            return View(cse);
        }
    }
}