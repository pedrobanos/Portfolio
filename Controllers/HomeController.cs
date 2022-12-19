using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepo projectRepo;
        private readonly IServiceEmail serviceEmail;

        public HomeController(
            IProjectRepo projectRepo, IServiceEmail serviceEmail
            )
        {
           
            this.projectRepo = projectRepo;
            this.serviceEmail = serviceEmail;
        }

        public IActionResult Index()
        {

            var proyects = projectRepo.ObtainProjects().Take(3).ToList();
            
            var model = new HomeIndexViewModel(){
                Projects= proyects
            };
            return View(model);
        }

       
        public IActionResult Projects()
        {
            var projects = projectRepo.ObtainProjects();
            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Contact(ContactViewModel contactViewModel)
        {
            await serviceEmail.SendEmail(contactViewModel);
        return RedirectToAction("ThankYou");
        }

        public IActionResult ThankYou ()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}