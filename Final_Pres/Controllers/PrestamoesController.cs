using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final_Pres.Models;

namespace Final_Pres.Controllers
{
    public class PrestamoesController : Controller
    {
        private Final_PresContext db = new Final_PresContext();

        // GET: Prestamoes
        public ActionResult Index()
        {
            return View(db.Prestamoes.ToList());
        }

        // GET: Prestamoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestamo prestamo = db.Prestamoes.Find(id);
            if (prestamo == null)
            {
                return HttpNotFound();
            }
            return View(prestamo);
        }

        // GET: Prestamoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prestamoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PresID,Desembolso,Avances,Activo,PaysPerYear,Start_Date,PagosAdicionales,NumeroDePagos_p,NumeroDePagos_r,InteresRate,PagosAnticipados,Years")] Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                db.Prestamoes.Add(prestamo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prestamo);
        }

        // GET: Prestamoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestamo prestamo = db.Prestamoes.Find(id);
            if (prestamo == null)
            {
                return HttpNotFound();
            }
            return View(prestamo);
        }

        // POST: Prestamoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PresID,Desembolso,Avances,Activo,PaysPerYear,Start_Date,PagosAdicionales,NumeroDePagos_p,NumeroDePagos_r,InteresRate,PagosAnticipados,Years")] Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestamo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prestamo);
        }

        // GET: Prestamoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestamo prestamo = db.Prestamoes.Find(id);
            if (prestamo == null)
            {
                return HttpNotFound();
            }
            return View(prestamo);
        }

        // POST: Prestamoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prestamo prestamo = db.Prestamoes.Find(id);
            db.Prestamoes.Remove(prestamo);
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
