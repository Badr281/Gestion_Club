using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using testMVC2.Models;

namespace testMVC2.Controllers
{
    public class AdherentController : Controller
    {
        private Gestion_clubEntities db = new Gestion_clubEntities();

        // GET: /Adherent/
        public ActionResult Index()
        {
            return View(db.adherents.ToList());
        }

        public ActionResult adherentPaye()
        {
            var liste_payes = (from s in db.abonnements.Include("adherent")
                                                       .Include("sport")
                          from c in db.payements
                            where c.payer == 1
                       select new adherent_paye() { nom = s.adherent.nom,
                 prenom = s.adherent.prenom, _payer = (byte)c.payer, _sport = s.sport.libele}
                                ).ToList();

            return View(liste_payes);
        }

        // GET: /Adherent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            adherent adherent = db.adherents.Find(id);
            if (adherent == null)
            {
                return HttpNotFound();
            }
            return View(adherent);
        }

        // GET: /Adherent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Adherent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,nom,prenom,adresse,tel")] adherent adherent)
        {
            if (ModelState.IsValid)
            {
                db.adherents.Add(adherent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adherent);
        }

        // GET: /Adherent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            adherent adherent = db.adherents.Find(id);
            if (adherent == null)
            {
                return HttpNotFound();
            }
            return View(adherent);
        }

        // POST: /Adherent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,nom,prenom,adresse,tel")] adherent adherent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adherent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adherent);
        }

        // GET: /Adherent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            adherent adherent = db.adherents.Find(id);
            if (adherent == null)
            {
                return HttpNotFound();
            }
            return View(adherent);
        }

        // POST: /Adherent/Delete/5
  [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            adherent adherent = db.adherents.Find(id);
            db.adherents.Remove(adherent);
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
