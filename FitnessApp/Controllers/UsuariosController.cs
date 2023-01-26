using FitnessApp.Data;
using FitnessApp.Data.Entities;
using FitnessApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FitnessApp.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public UsuariosController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public ActionResult Index()
        {
            var x = dbContext.Ejercicos.Where(x => x.Id == 1).FirstOrDefault();
            return View();
        }
        public IActionResult Login() => View();
        public IActionResult SingIn() => View();

        [HttpPost]
        public async Task<IActionResult> SingIn(SingInModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

           var user = new IdentityUser() { Email = modelo.Email, UserName = modelo.Email };

            var result = await userManager.CreateAsync(user, password: modelo.Password);

            //  var claimsPersonalizados = new List<Claim>()
            //{
            // new Claim("TenandID", user.Id)
            //};
            var imcvar = (modelo.estatura * modelo.peso);
            Persona persona = new Persona { idUsuario = user.Id, nombre = modelo.nombre, edad=modelo.edad, correo=modelo.Email, estatura=modelo.estatura, peso=modelo.peso, genero=modelo.genero,complexion=modelo.complexion, diasActividad=modelo.diasActividad, meta=modelo.meta, imc=imcvar,password=modelo.Password };
            dbContext.Add(persona);
            await dbContext.SaveChangesAsync();
        //    await userManager.AddClaimsAsync(user, claimsPersonalizados);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(modelo);
            }



        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel modelo)
        {
            if (!ModelState.IsValid) return View(modelo);

            var result = await signInManager.PasswordSignInAsync(modelo.Email, modelo.Password, modelo.Recuerdame, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Show", "Platillos");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Nombre de usuario o password incorrecto.");
                return View(modelo);
            }
        }

    }
}