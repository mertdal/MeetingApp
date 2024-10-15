using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller{
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            ViewData["Selamlama"] = saat > 12 ? "İyi Akşamlar":"Günaydın";
            int UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "Bartın Üniversitesi, İİBF Konferans Salonu",
                Date = new DateTime(2024,10,21,20,0,0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }
}