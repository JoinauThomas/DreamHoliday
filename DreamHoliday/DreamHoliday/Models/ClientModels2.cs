using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppClient.Web.Models
{
    public class ClientModels
    {
        [Display(Name = "Numéro de client")]
        [Range(1, int.MaxValue, ErrorMessage = "* [1 - ....]")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "* Nom obligatoire")]
        [StringLength(5, ErrorMessage = "Max 5 car")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "* Pffff ... prénom")]
        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        [Display(Name = "Etat civil")]
        [Range(1, 2, ErrorMessage = "Veuillez choisir")]
        public int EtcId { get; set; }
    }

    public class EtatCivil
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
    }
}