using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            //TODO: Save userInfo to database
            Repository.AddUser(userInfo);
            ViewBag.UserCount = Repository.Users.Where(u => u.WillAttend == true).Count(); 
            return View("Thanks", userInfo);
        }

        public IActionResult List()
        {
            return View(Repository.Users);
        }
    }
}
