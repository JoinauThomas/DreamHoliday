﻿using DreamHoliday_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DreamHoliday_API.Controllers.api
{
    
    [RoutePrefix("api/MembreAPI")]
    public class MembreAPIController : ApiController
    {
        [HttpGet]
        [Route("GetMembreByMail")]
        public Membre GetMembreByMail(string mail)
        {
            DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();

            DAL.MEMBRE moiDB = dbContext.MEMBRE.ToList().Find(m => m.MEM_mail == mail);
            Membre moi = new Membre { mail = moiDB.MEM_mail, nom = moiDB.MEM_nom, adresse = moiDB.MEM_adresse, dateDeNaissance = moiDB.MEM_dateDeNaissance, estProprietaire = moiDB.MEM_propriétaire, idMembre = moiDB.idMembre, photo = moiDB.MEM_Photo, prenom = moiDB.MEM_prenom, telephone = moiDB.MEM_telephone };

            return moi;
        }

        [HttpGet]
        [Route("GetMembreByIdForProfile")]
        public editProfile GetMembreByIdForProfile(int idMembre)
        {
            DAL.MEMBRE moi_Db = new DAL.MEMBRE();

            DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();
            List<DAL.MEMBRE> mesMem = dbContext.MEMBRE.ToList();

            moi_Db = mesMem.Find(m => m.idMembre == idMembre);
            editProfile moi = new editProfile { idMembre = moi_Db.idMembre, adresse = moi_Db.MEM_adresse, dateDeNaissance = moi_Db.MEM_dateDeNaissance, estProprietaire = moi_Db.MEM_propriétaire, mail = moi_Db.MEM_mail, nom = moi_Db.MEM_nom, photo = moi_Db.MEM_Photo, prenom = moi_Db.MEM_prenom, telephone = moi_Db.MEM_telephone };

            return moi;
        }




        [HttpPost]
        [Route("PostNewMembre")]
        public IHttpActionResult PostNewMembre(Membre nvMembre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("ERREUR, le formulaire a ete mal rempli!!!");
            }
            else
            {
                DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();
                dbContext.addNewMembre(nvMembre.mail, nvMembre.nom, nvMembre.prenom, nvMembre.adresse, nvMembre.dateDeNaissance, nvMembre.telephone);
                return Ok();
            }
        }

        [HttpPost]
        [Route("PostUpdateMembre")]
        public IHttpActionResult PostUpdateMembre(editProfile moi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("ERREUR, le formulaire a ete mal rempli!!!");
            }
            else
            {
                DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();
                dbContext.UpdateMembre(moi.idMembre, moi.mail, moi.nom, moi.prenom, moi.adresse, moi.dateDeNaissance, moi.telephone);
                return Ok();
            }
        }

        [HttpPost]
        [Route("PostQuestion")]
        public IHttpActionResult PostQuestion(question questionaire)
        {
            try
            {
                DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();
                dbContext.addNewMessage(questionaire.nom, questionaire.prenom, questionaire.mail, questionaire.message, questionaire.idMembre, questionaire.sujet);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex + "le message n'a pas pu etre envoyé");
            }

        }

        [HttpGet]
        [Route("GetMyLocations")]
        public List<MesLocations> GetMyLocations(int idMembre)
        {
            try
            {
                DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();
                List<MesLocations> mesLocations = new List<MesLocations>();

                List<DAL.getMyLocations_Result> mesLocationsDB = dbContext.getMyLocations(idMembre).ToList();

                foreach (var l in mesLocationsDB)
                {
                    mesLocations.Add(new MesLocations { dateArrivee = (DateTime)l.dateArrivee, dateDepart = (DateTime)l.dateDepart, idBien = (int)l.idBien, adresse = l.adresse, dateEnregistrement = (DateTime)l.dateEnregistrement, estCommente = (bool)l.estCommente, estNote = (bool)l.estNote, idLocation = (int)l.idLocation, nbNuits = (int)l.nbNuit, photo = l.photo });
                }
                return mesLocations;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetAllMembres")]
        public List<Membre> GetAllMembres()
        {
            DAL.DreamHollidayEntities dbContext = new DAL.DreamHollidayEntities();
            List<DAL.MEMBRE> mesMem = dbContext.MEMBRE.ToList();
            List<Membre> mesMembres = new List<Membre>();

            return mesMembres;
        }
        
    }
}
