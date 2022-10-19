using MVCASFIES.Context;
using MVCASFIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Mvc;

namespace MVCASFIES.Controllers
{
    public class EstiloVidaController : Controller
    {
        private MVCASFIESContext db = new MVCASFIESContext();
        // GET: EstiloVida
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Encuesta(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = id;
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PDFEstiloVidaDato pdf)
        {
            if (ModelState.IsValid)
            {
                db.PDFEstiloVidaDatos.Add(pdf);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Encuesta");
        }
        public ActionResult Details()
        {
            var pdfs = db.PDFEstiloVidaDatos;
            return View(pdfs);
        }
    }
}