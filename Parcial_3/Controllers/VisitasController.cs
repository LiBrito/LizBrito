using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Parcial_3.Models;

namespace Parcial_3.Controllers
{
    public class VisitasController : Controller
    {
        private Parcial_3Context db = new Parcial_3Context();

        // GET: Visitas
        public ActionResult Index()
        {
            var visitas = db.Visitas.Include(v => v.area).Include(v => v.persona);
            return View(visitas.ToList());
        }
        public ActionResult Indexes(String nombre)
        {
            var visitas = db.Visitas.Include(v => v.area).Include(v => v.persona).Where(v => v.area.n_area.Contains(nombre));
            return View("Index", visitas.ToList());
        }


        // GET: Visitas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visita visita = db.Visitas.Find(id);
            if (visita == null)
            {
                return HttpNotFound();
            }
            return View(visita);
        }

        // GET: Visitas/Create
        public ActionResult Create()
        {
            ViewBag.areaID = new SelectList(db.Areas, "AreaID", "n_area");
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "nombre_p");
            return View();
        }

        // POST: Visitas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VisitaID,date_vis,bg_vis,end_vis,vis_motive,PersonaID,areaID")] Visita visita)
        {
            if (ModelState.IsValid)
            {
                db.Visitas.Add(visita);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.areaID = new SelectList(db.Areas, "AreaID", "n_area", visita.areaID);
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "nombre_p", visita.PersonaID);
            return View(visita);
        }

        // GET: Visitas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visita visita = db.Visitas.Find(id);
            if (visita == null)
            {
                return HttpNotFound();
            }
            ViewBag.areaID = new SelectList(db.Areas, "AreaID", "n_area", visita.areaID);
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "nombre_p", visita.PersonaID);
            return View(visita);
        }

        // POST: Visitas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VisitaID,date_vis,bg_vis,end_vis,vis_motive,PersonaID,areaID")] Visita visita)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visita).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.areaID = new SelectList(db.Areas, "AreaID", "n_area", visita.areaID);
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "nombre_p", visita.PersonaID);
            return View(visita);
        }

        // GET: Visitas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visita visita = db.Visitas.Find(id);
            if (visita == null)
            {
                return HttpNotFound();
            }
            return View(visita);
        }

        // POST: Visitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visita visita = db.Visitas.Find(id);
            db.Visitas.Remove(visita);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
