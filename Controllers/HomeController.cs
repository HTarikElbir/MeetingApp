using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost/
        //localhost/Home/Index
        public IActionResult Index()
        {
            int clock = DateTime.Now.Hour;

            // ViewBag is a dynamic object that can be used to pass data from the controller to the view
            ViewBag.Greeting = clock < 12 ? "Good Morning" : "Good Afternoon";
            //ViewData["Greeting"] = clock < 12 ? "Good Morning" : "Good Afternoon";

            int userCount = Repository.Users.Where(u => u.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo
            {
                Id = 1,
                Location = "Antalya",
                Date = new DateTime(2025, 03, 10, 14, 0,0),
                NumberOfPeople = userCount
            };

            return View(meetingInfo);
        }

    }
}
