using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLATAFORMA_VIRTUAL.Controllers
{
    public class InicioController : Controller
    {
        //
        // GET: /Inicio/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Compania()
        {
            return View();
        }
        public ActionResult Equipo()
        {
            return View();
        }
    }
}
