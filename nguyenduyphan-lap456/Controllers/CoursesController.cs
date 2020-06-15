using nguyenduyphan_lap456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nguyenduyphan_lap456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
            public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
 
       
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };

            return View();
        }
[Authorize]
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModeState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Course.Add(course);
            _dbContext.SaveChanges();
        }
           
             return RedirectToAction("Index","Home");
    }
   
}