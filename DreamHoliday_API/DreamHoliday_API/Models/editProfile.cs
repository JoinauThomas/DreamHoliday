﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DreamHoliday_API.Models
{
    public class editProfile
    {
        [Display(ResourceType = typeof(Resource), Name = "idMembre")]
        public int idMembre { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "mail")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Error_mailRequis")]
        public string mail { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "nom")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Error_nomRequis")]
        public string nom { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "prenom")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Error_PrenomRequis")]
        public string prenom { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "adresse")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Error_adresseRequise")]
        public string adresse { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "dateDeNaissance")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Error_DateNaissRequis")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dateDeNaissance { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "telephone")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Error_telephoneRequis")]
        public string telephone { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "photo")]
        public string photo { get; set; }
        [Display(ResourceType = typeof(Resource), Name = "estProprio")]
        public bool estProprietaire { get; set; }
    }
}