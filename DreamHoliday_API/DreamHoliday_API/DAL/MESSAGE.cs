//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DreamHoliday_API.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MESSAGE
    {
        public int idMessage { get; set; }
        public string MES_nom { get; set; }
        public string MES_prenom { get; set; }
        public string MES_mail { get; set; }
        public string MES_Sujet { get; set; }
        public string MES_message { get; set; }
        public System.DateTime MES_date { get; set; }
        public int MES_MEM_idMembre { get; set; }
    }
}
