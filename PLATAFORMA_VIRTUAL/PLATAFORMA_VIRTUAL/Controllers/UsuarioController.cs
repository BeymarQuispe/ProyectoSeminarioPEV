using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PLATAFORMA_VIRTUAL.Models;

namespace PLATAFORMA_VIRTUAL.Controllers
{
    public class UsuarioController : Controller
    {
        private AULA_VIRTUALEntities db = new AULA_VIRTUALEntities();

        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View(db.USUARIO.ToList());
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id = 0)
        {
            USUARIO usuario = db.USUARIO.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(USUARIO usuario)
        {
            
            if (ModelState.IsValid)
            {
                usuario.Fecha = DateTime.Now;
                db.USUARIO.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            USUARIO usuario = db.USUARIO.Find(id);
            if (usuario == null)
            {
                
                return HttpNotFound();
            }
            ViewBag.Validar = true;
            return View(usuario);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(USUARIO usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Fecha = DateTime.Now;
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            USUARIO usuario = db.USUARIO.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            USUARIO usuario = db.USUARIO.Find(id);
            db.USUARIO.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}