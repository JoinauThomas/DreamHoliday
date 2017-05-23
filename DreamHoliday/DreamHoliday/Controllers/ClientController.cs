using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DreamHoliday.Web.Models;

namespace DreamHoliday.Web.Controllers
{
    public class ClientController : Controller
    {
        private static List<ClientModels> _listClient = new List<ClientModels>();
        private static int _lastId = 0;

        // GET: Client
        public ActionResult Index()
        {
            return View(_listClient);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<EtatCivil> lstEtat = new List<EtatCivil>();
            lstEtat.Add(new EtatCivil { Id = 0, Libelle = "vide" });
            lstEtat.Add(new EtatCivil { Id = 1, Libelle = "Célibataire" });
            lstEtat.Add(new EtatCivil { Id = 2, Libelle = "Marié" });

            ViewBag.ListEtatCivil = new SelectList(lstEtat,"Id","Libelle");

            return View();
        }

        [HttpPost]
        public ActionResult Create(ClientModels model)
        {
            if (ModelState.IsValid)
            {
                _listClient.Add(model);

                return RedirectToAction("Index");
            }

            List<EtatCivil> lstEtat = new List<EtatCivil>();
            lstEtat.Add(new EtatCivil { Id = 0, Libelle = "vide" });
            lstEtat.Add(new EtatCivil { Id = 1, Libelle = "Célibataire" });
            lstEtat.Add(new EtatCivil { Id = 2, Libelle = "Marié" });

            ViewBag.ListEtatCivil = new SelectList(lstEtat, "Id", "Libelle");

            return View(model);
        }
    }
}