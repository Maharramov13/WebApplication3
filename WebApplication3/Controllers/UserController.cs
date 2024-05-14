using Microsoft.AspNetCore.Mvc;


namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {

            User user = new User() { Name = "Veli", Surname = "Maharramov", Age = 27, Country = "Azerbaijan", PhoneNumber = "0554765885" };

            ViewBag.User = user;
       
            return View();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
    }
    }

