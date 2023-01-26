using FitnessApp.Data;
using FitnessApp.Data.Entities;
using FitnessApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Controllers
{
    public class AvanceRutinaController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<IdentityUser> userManager;

        public AvanceRutinaController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.dbContext = dbContext;
            //var x= dbContext.Avances.Where(x=>x.Id==1);
           // this.userManager = userManager;
            //this.signInManager = signInManager;
        }
       public IActionResult InsertarAvances() => View();
        [HttpPost]
        public async Task<IActionResult> InsertarAvances(InsertarAvancesModel model)
             {
            var user = new IdentityUser() { Id = model.idAvance };
           // var result = await userManager.CreateAsync(user);
            Avance avance = new Avance { idAvance=user.Id, fecha=model.fecha,idSerieAvance=model.idSerieAvance};
            dbContext.Add(avance);
            dbContext.SaveChanges();
            await  dbContext.SaveChangesAsync();


            RedirectToAction("Index", "Home");

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
