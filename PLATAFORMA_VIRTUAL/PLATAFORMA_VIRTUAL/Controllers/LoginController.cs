using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PLATAFORMA_VIRTUAL.Models;

namespace PLATAFORMA_VIRTUAL.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        private AULA_VIRTUALEntities db = new AULA_VIRTUALEntities();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String nick, String pass)
        {
            Models.Consultas consultas = new Consultas();
            Boolean v = consultas.Validar(nick,pass);
            int id = db.USUARIO.Where(a => a.Nick == nick && a.Pass == pass).First().Id;
            
            if (v)
            {
                USUARIO user = db.USUARIO.Find(id);
                
                    ViewBag.Validar = true;
                    ViewBag.dato1 = db.USUARIO.Find(id).Nick;
                    ViewBag.dato2 = db.USUARIO.Find(id).Nombre;
                    ViewBag.dato3 = db.USUARIO.Find(id).Apellidos;
                    return View("Perfil", user);
                    
            }
            else
            {
                ViewBag.Validar = false;
                return View("Error");
            }
            
        }
       
        public ActionResult Perfil(Login login)
        {
            return View(login);
        }
    }
}
