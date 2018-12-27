using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testMVC2.Models;

namespace testMVC2.Controllers
{
    public class gestionAlbumController : Controller
    {
        static Album mon_album = new Album();
        //
        // GET: /gestionAlbum/
        public ActionResult creerAlbum()
        {
            string[] type_album = { "Rock", "Classic", "Pop" };

            ViewBag.categorie = new SelectList(type_album, null, null);
            return View();
        }

        [HttpPost]
        public ActionResult creerAlbum(Album a)
        {
            // verification des donnees saisies
            if (ModelState.IsValid) // si tout est validé
            {
                mon_album = a;
                // rederiger vers la page d'accueil
                return RedirectToAction("afficherAlbum", mon_album);
            }
            else 
            {
                // preparer la liste (encore une autre fois)
                string[] type_album = { "Rock", "Classic", "Pop" };
                ViewBag.categorie = new SelectList(type_album, null, null);

                return View(a);
            }
        }
        public ActionResult afficherAlbum(Album a)
        {
            return View(a);
        }

        public ActionResult modifierAlbum(Album a)
        {
            // preparer la liste (encore une autre fois)
            string[] type_album = { "Rock", "Classic", "Pop" };
            ViewBag.categorie = new SelectList(type_album, null, null);
           
            return View(a);
        }
       

	}
}