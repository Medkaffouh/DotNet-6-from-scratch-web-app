using System.Collections;
using HelloWorldProject2.Model;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldProject2.Controllers{
    public class TestController:Controller{

        public IActionResult Index(){
            IList<string> items = new List<string>();
            items.Add("Mohamed");
            items.Add("Ahmed");
            items.Add("Meriam");
            ViewBag.contact = "medk@medkaffouh.ma";
            ViewData["email"] = "kaffouhmohamed@gmail.com";
            return View(items);
        }

        public IActionResult About(){
            return View();
        }

        public IActionResult List(){
            IList<Student> students = new List<Student>();
            students.Add(new Student{Id=1,Name="Hassan",Score=66});
            students.Add(new Student{Id=2,Name="Chaimae",Score=45});
            students.Add(new Student{Id=3,Name="Fatiha",Score=99});
            return View(students);
        }
    }
}