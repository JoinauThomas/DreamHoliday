﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DreamHollidayEntities : DbContext
    {
        public DreamHollidayEntities()
            : base("name=DreamHollidayEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BIEN> BIEN { get; set; }
        public virtual DbSet<COMMENTAIRE> COMMENTAIRE { get; set; }
        public virtual DbSet<LOCATION> LOCATION { get; set; }
        public virtual DbSet<MEMBRE> MEMBRE { get; set; }
        public virtual DbSet<MESSAGE> MESSAGE { get; set; }
        public virtual DbSet<NOTE> NOTE { get; set; }
        public virtual DbSet<OPTIONS> OPTIONS { get; set; }
        public virtual DbSet<PIECE> PIECE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual int addCommentAndNote(Nullable<int> note, Nullable<int> idLocation, string libelle)
        {
            var noteParameter = note.HasValue ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(int));
    
            var idLocationParameter = idLocation.HasValue ?
                new ObjectParameter("idLocation", idLocation) :
                new ObjectParameter("idLocation", typeof(int));
    
            var libelleParameter = libelle != null ?
                new ObjectParameter("libelle", libelle) :
                new ObjectParameter("libelle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addCommentAndNote", noteParameter, idLocationParameter, libelleParameter);
        }
    
        public virtual int addNewBien(string pays, string ville, string rue, string numero, Nullable<int> idMembre, Nullable<int> tarifNuit, Nullable<int> tarifNettoyage, string libelle, Nullable<int> nbMaxDePers, Nullable<int> sdb, Nullable<int> salon, Nullable<int> sam, Nullable<int> toilette, Nullable<int> cuisine, Nullable<int> chambre, Nullable<int> dressing, Nullable<int> veranda, Nullable<bool> bbq, Nullable<bool> piscine, Nullable<bool> jacuzzi, Nullable<bool> sauna, Nullable<bool> tv, Nullable<bool> teleDistrib, Nullable<bool> wifi, Nullable<bool> pingPong, Nullable<bool> tennis, Nullable<bool> transat, Nullable<bool> cuisineEqu, Nullable<bool> machineALaver, Nullable<bool> jardin, Nullable<bool> parking)
        {
            var paysParameter = pays != null ?
                new ObjectParameter("pays", pays) :
                new ObjectParameter("pays", typeof(string));
    
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var rueParameter = rue != null ?
                new ObjectParameter("rue", rue) :
                new ObjectParameter("rue", typeof(string));
    
            var numeroParameter = numero != null ?
                new ObjectParameter("numero", numero) :
                new ObjectParameter("numero", typeof(string));
    
            var idMembreParameter = idMembre.HasValue ?
                new ObjectParameter("idMembre", idMembre) :
                new ObjectParameter("idMembre", typeof(int));
    
            var tarifNuitParameter = tarifNuit.HasValue ?
                new ObjectParameter("tarifNuit", tarifNuit) :
                new ObjectParameter("tarifNuit", typeof(int));
    
            var tarifNettoyageParameter = tarifNettoyage.HasValue ?
                new ObjectParameter("tarifNettoyage", tarifNettoyage) :
                new ObjectParameter("tarifNettoyage", typeof(int));
    
            var libelleParameter = libelle != null ?
                new ObjectParameter("libelle", libelle) :
                new ObjectParameter("libelle", typeof(string));
    
            var nbMaxDePersParameter = nbMaxDePers.HasValue ?
                new ObjectParameter("nbMaxDePers", nbMaxDePers) :
                new ObjectParameter("nbMaxDePers", typeof(int));
    
            var sdbParameter = sdb.HasValue ?
                new ObjectParameter("sdb", sdb) :
                new ObjectParameter("sdb", typeof(int));
    
            var salonParameter = salon.HasValue ?
                new ObjectParameter("salon", salon) :
                new ObjectParameter("salon", typeof(int));
    
            var samParameter = sam.HasValue ?
                new ObjectParameter("sam", sam) :
                new ObjectParameter("sam", typeof(int));
    
            var toiletteParameter = toilette.HasValue ?
                new ObjectParameter("toilette", toilette) :
                new ObjectParameter("toilette", typeof(int));
    
            var cuisineParameter = cuisine.HasValue ?
                new ObjectParameter("cuisine", cuisine) :
                new ObjectParameter("cuisine", typeof(int));
    
            var chambreParameter = chambre.HasValue ?
                new ObjectParameter("chambre", chambre) :
                new ObjectParameter("chambre", typeof(int));
    
            var dressingParameter = dressing.HasValue ?
                new ObjectParameter("dressing", dressing) :
                new ObjectParameter("dressing", typeof(int));
    
            var verandaParameter = veranda.HasValue ?
                new ObjectParameter("veranda", veranda) :
                new ObjectParameter("veranda", typeof(int));
    
            var bbqParameter = bbq.HasValue ?
                new ObjectParameter("bbq", bbq) :
                new ObjectParameter("bbq", typeof(bool));
    
            var piscineParameter = piscine.HasValue ?
                new ObjectParameter("piscine", piscine) :
                new ObjectParameter("piscine", typeof(bool));
    
            var jacuzziParameter = jacuzzi.HasValue ?
                new ObjectParameter("jacuzzi", jacuzzi) :
                new ObjectParameter("jacuzzi", typeof(bool));
    
            var saunaParameter = sauna.HasValue ?
                new ObjectParameter("sauna", sauna) :
                new ObjectParameter("sauna", typeof(bool));
    
            var tvParameter = tv.HasValue ?
                new ObjectParameter("tv", tv) :
                new ObjectParameter("tv", typeof(bool));
    
            var teleDistribParameter = teleDistrib.HasValue ?
                new ObjectParameter("teleDistrib", teleDistrib) :
                new ObjectParameter("teleDistrib", typeof(bool));
    
            var wifiParameter = wifi.HasValue ?
                new ObjectParameter("wifi", wifi) :
                new ObjectParameter("wifi", typeof(bool));
    
            var pingPongParameter = pingPong.HasValue ?
                new ObjectParameter("pingPong", pingPong) :
                new ObjectParameter("pingPong", typeof(bool));
    
            var tennisParameter = tennis.HasValue ?
                new ObjectParameter("tennis", tennis) :
                new ObjectParameter("tennis", typeof(bool));
    
            var transatParameter = transat.HasValue ?
                new ObjectParameter("transat", transat) :
                new ObjectParameter("transat", typeof(bool));
    
            var cuisineEquParameter = cuisineEqu.HasValue ?
                new ObjectParameter("cuisineEqu", cuisineEqu) :
                new ObjectParameter("cuisineEqu", typeof(bool));
    
            var machineALaverParameter = machineALaver.HasValue ?
                new ObjectParameter("machineALaver", machineALaver) :
                new ObjectParameter("machineALaver", typeof(bool));
    
            var jardinParameter = jardin.HasValue ?
                new ObjectParameter("jardin", jardin) :
                new ObjectParameter("jardin", typeof(bool));
    
            var parkingParameter = parking.HasValue ?
                new ObjectParameter("parking", parking) :
                new ObjectParameter("parking", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addNewBien", paysParameter, villeParameter, rueParameter, numeroParameter, idMembreParameter, tarifNuitParameter, tarifNettoyageParameter, libelleParameter, nbMaxDePersParameter, sdbParameter, salonParameter, samParameter, toiletteParameter, cuisineParameter, chambreParameter, dressingParameter, verandaParameter, bbqParameter, piscineParameter, jacuzziParameter, saunaParameter, tvParameter, teleDistribParameter, wifiParameter, pingPongParameter, tennisParameter, transatParameter, cuisineEquParameter, machineALaverParameter, jardinParameter, parkingParameter);
        }
    
        public virtual int addNewLocation(Nullable<int> idBien, Nullable<int> idMembre, Nullable<System.DateTime> dateArrivee, Nullable<System.DateTime> dateDepart)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            var idMembreParameter = idMembre.HasValue ?
                new ObjectParameter("idMembre", idMembre) :
                new ObjectParameter("idMembre", typeof(int));
    
            var dateArriveeParameter = dateArrivee.HasValue ?
                new ObjectParameter("dateArrivee", dateArrivee) :
                new ObjectParameter("dateArrivee", typeof(System.DateTime));
    
            var dateDepartParameter = dateDepart.HasValue ?
                new ObjectParameter("dateDepart", dateDepart) :
                new ObjectParameter("dateDepart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addNewLocation", idBienParameter, idMembreParameter, dateArriveeParameter, dateDepartParameter);
        }
    
        public virtual int addNewMembre(string mail, string nom, string prenom, string adresse, Nullable<System.DateTime> dateDeNaissance, string telephone)
        {
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("adresse", adresse) :
                new ObjectParameter("adresse", typeof(string));
    
            var dateDeNaissanceParameter = dateDeNaissance.HasValue ?
                new ObjectParameter("dateDeNaissance", dateDeNaissance) :
                new ObjectParameter("dateDeNaissance", typeof(System.DateTime));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("telephone", telephone) :
                new ObjectParameter("telephone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addNewMembre", mailParameter, nomParameter, prenomParameter, adresseParameter, dateDeNaissanceParameter, telephoneParameter);
        }
    
        public virtual int addNewMessage(string nom, string prenom, string mail, string message, Nullable<int> idMembre, string sujet)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("message", message) :
                new ObjectParameter("message", typeof(string));
    
            var idMembreParameter = idMembre.HasValue ?
                new ObjectParameter("idMembre", idMembre) :
                new ObjectParameter("idMembre", typeof(int));
    
            var sujetParameter = sujet != null ?
                new ObjectParameter("sujet", sujet) :
                new ObjectParameter("sujet", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addNewMessage", nomParameter, prenomParameter, mailParameter, messageParameter, idMembreParameter, sujetParameter);
        }
    
        public virtual int addNewNote(Nullable<decimal> note, Nullable<int> idMembre, Nullable<int> idBien, Nullable<int> idLocation)
        {
            var noteParameter = note.HasValue ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(decimal));
    
            var idMembreParameter = idMembre.HasValue ?
                new ObjectParameter("idMembre", idMembre) :
                new ObjectParameter("idMembre", typeof(int));
    
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            var idLocationParameter = idLocation.HasValue ?
                new ObjectParameter("idLocation", idLocation) :
                new ObjectParameter("idLocation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addNewNote", noteParameter, idMembreParameter, idBienParameter, idLocationParameter);
        }
    
        public virtual ObjectResult<detailBienWithIde_Result> detailBienWithIde(Nullable<int> idBien)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detailBienWithIde_Result>("detailBienWithIde", idBienParameter);
        }
    
        public virtual ObjectResult<GetFiveLastComment_Result> GetFiveLastComment(Nullable<int> idBien)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFiveLastComment_Result>("GetFiveLastComment", idBienParameter);
        }
    
        public virtual ObjectResult<getMyLocations_Result> getMyLocations(Nullable<int> idMembre)
        {
            var idMembreParameter = idMembre.HasValue ?
                new ObjectParameter("idMembre", idMembre) :
                new ObjectParameter("idMembre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getMyLocations_Result>("getMyLocations", idMembreParameter);
        }
    
        public virtual ObjectResult<RechercheDatePasDispo_Result> RechercheDatePasDispo(Nullable<int> idBien)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RechercheDatePasDispo_Result>("RechercheDatePasDispo", idBienParameter);
        }
    
        public virtual ObjectResult<SearchBiensDispo1_Result> SearchBiensDispo1(string paysOuVille, Nullable<System.DateTime> arrivee, Nullable<System.DateTime> depart, Nullable<int> nbPers)
        {
            var paysOuVilleParameter = paysOuVille != null ?
                new ObjectParameter("paysOuVille", paysOuVille) :
                new ObjectParameter("paysOuVille", typeof(string));
    
            var arriveeParameter = arrivee.HasValue ?
                new ObjectParameter("arrivee", arrivee) :
                new ObjectParameter("arrivee", typeof(System.DateTime));
    
            var departParameter = depart.HasValue ?
                new ObjectParameter("depart", depart) :
                new ObjectParameter("depart", typeof(System.DateTime));
    
            var nbPersParameter = nbPers.HasValue ?
                new ObjectParameter("nbPers", nbPers) :
                new ObjectParameter("nbPers", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchBiensDispo1_Result>("SearchBiensDispo1", paysOuVilleParameter, arriveeParameter, departParameter, nbPersParameter);
        }
    
        public virtual ObjectResult<SearchBiensDispo2_Result> SearchBiensDispo2(string paysOuVille, Nullable<System.DateTime> arrivee, Nullable<System.DateTime> depart, Nullable<int> nbPers)
        {
            var paysOuVilleParameter = paysOuVille != null ?
                new ObjectParameter("paysOuVille", paysOuVille) :
                new ObjectParameter("paysOuVille", typeof(string));
    
            var arriveeParameter = arrivee.HasValue ?
                new ObjectParameter("arrivee", arrivee) :
                new ObjectParameter("arrivee", typeof(System.DateTime));
    
            var departParameter = depart.HasValue ?
                new ObjectParameter("depart", depart) :
                new ObjectParameter("depart", typeof(System.DateTime));
    
            var nbPersParameter = nbPers.HasValue ?
                new ObjectParameter("nbPers", nbPers) :
                new ObjectParameter("nbPers", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchBiensDispo2_Result>("SearchBiensDispo2", paysOuVilleParameter, arriveeParameter, departParameter, nbPersParameter);
        }
    
        public virtual ObjectResult<searchBienWithOptions_Result> searchBienWithOptions(Nullable<bool> bbq, Nullable<bool> piscine, Nullable<bool> jacuzzi, Nullable<bool> sauna, Nullable<bool> tv, Nullable<bool> teleDis, Nullable<bool> wifi, Nullable<bool> pingpong, Nullable<bool> tennis, Nullable<bool> transat, Nullable<bool> cuisineEq, Nullable<bool> machineALaver, Nullable<bool> jardin, Nullable<bool> parking, Nullable<int> nbSdb, Nullable<int> nbToilette, Nullable<int> nbChambre, Nullable<int> prixMax, string villeOuPays, Nullable<int> nbPersMax)
        {
            var bbqParameter = bbq.HasValue ?
                new ObjectParameter("bbq", bbq) :
                new ObjectParameter("bbq", typeof(bool));
    
            var piscineParameter = piscine.HasValue ?
                new ObjectParameter("piscine", piscine) :
                new ObjectParameter("piscine", typeof(bool));
    
            var jacuzziParameter = jacuzzi.HasValue ?
                new ObjectParameter("jacuzzi", jacuzzi) :
                new ObjectParameter("jacuzzi", typeof(bool));
    
            var saunaParameter = sauna.HasValue ?
                new ObjectParameter("sauna", sauna) :
                new ObjectParameter("sauna", typeof(bool));
    
            var tvParameter = tv.HasValue ?
                new ObjectParameter("tv", tv) :
                new ObjectParameter("tv", typeof(bool));
    
            var teleDisParameter = teleDis.HasValue ?
                new ObjectParameter("teleDis", teleDis) :
                new ObjectParameter("teleDis", typeof(bool));
    
            var wifiParameter = wifi.HasValue ?
                new ObjectParameter("wifi", wifi) :
                new ObjectParameter("wifi", typeof(bool));
    
            var pingpongParameter = pingpong.HasValue ?
                new ObjectParameter("pingpong", pingpong) :
                new ObjectParameter("pingpong", typeof(bool));
    
            var tennisParameter = tennis.HasValue ?
                new ObjectParameter("tennis", tennis) :
                new ObjectParameter("tennis", typeof(bool));
    
            var transatParameter = transat.HasValue ?
                new ObjectParameter("transat", transat) :
                new ObjectParameter("transat", typeof(bool));
    
            var cuisineEqParameter = cuisineEq.HasValue ?
                new ObjectParameter("cuisineEq", cuisineEq) :
                new ObjectParameter("cuisineEq", typeof(bool));
    
            var machineALaverParameter = machineALaver.HasValue ?
                new ObjectParameter("machineALaver", machineALaver) :
                new ObjectParameter("machineALaver", typeof(bool));
    
            var jardinParameter = jardin.HasValue ?
                new ObjectParameter("jardin", jardin) :
                new ObjectParameter("jardin", typeof(bool));
    
            var parkingParameter = parking.HasValue ?
                new ObjectParameter("parking", parking) :
                new ObjectParameter("parking", typeof(bool));
    
            var nbSdbParameter = nbSdb.HasValue ?
                new ObjectParameter("nbSdb", nbSdb) :
                new ObjectParameter("nbSdb", typeof(int));
    
            var nbToiletteParameter = nbToilette.HasValue ?
                new ObjectParameter("nbToilette", nbToilette) :
                new ObjectParameter("nbToilette", typeof(int));
    
            var nbChambreParameter = nbChambre.HasValue ?
                new ObjectParameter("nbChambre", nbChambre) :
                new ObjectParameter("nbChambre", typeof(int));
    
            var prixMaxParameter = prixMax.HasValue ?
                new ObjectParameter("prixMax", prixMax) :
                new ObjectParameter("prixMax", typeof(int));
    
            var villeOuPaysParameter = villeOuPays != null ?
                new ObjectParameter("villeOuPays", villeOuPays) :
                new ObjectParameter("villeOuPays", typeof(string));
    
            var nbPersMaxParameter = nbPersMax.HasValue ?
                new ObjectParameter("nbPersMax", nbPersMax) :
                new ObjectParameter("nbPersMax", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<searchBienWithOptions_Result>("searchBienWithOptions", bbqParameter, piscineParameter, jacuzziParameter, saunaParameter, tvParameter, teleDisParameter, wifiParameter, pingpongParameter, tennisParameter, transatParameter, cuisineEqParameter, machineALaverParameter, jardinParameter, parkingParameter, nbSdbParameter, nbToiletteParameter, nbChambreParameter, prixMaxParameter, villeOuPaysParameter, nbPersMaxParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdateMembre(Nullable<int> idMembre, string mail, string nom, string prenom, string adresse, Nullable<System.DateTime> dateDeNaissance, string telephone)
        {
            var idMembreParameter = idMembre.HasValue ?
                new ObjectParameter("idMembre", idMembre) :
                new ObjectParameter("idMembre", typeof(int));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("adresse", adresse) :
                new ObjectParameter("adresse", typeof(string));
    
            var dateDeNaissanceParameter = dateDeNaissance.HasValue ?
                new ObjectParameter("dateDeNaissance", dateDeNaissance) :
                new ObjectParameter("dateDeNaissance", typeof(System.DateTime));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("telephone", telephone) :
                new ObjectParameter("telephone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMembre", idMembreParameter, mailParameter, nomParameter, prenomParameter, adresseParameter, dateDeNaissanceParameter, telephoneParameter);
        }
    
        public virtual ObjectResult<verifDates_Result> verifDates(Nullable<int> idBie, Nullable<System.DateTime> arrivee, Nullable<System.DateTime> depart)
        {
            var idBieParameter = idBie.HasValue ?
                new ObjectParameter("idBie", idBie) :
                new ObjectParameter("idBie", typeof(int));
    
            var arriveeParameter = arrivee.HasValue ?
                new ObjectParameter("arrivee", arrivee) :
                new ObjectParameter("arrivee", typeof(System.DateTime));
    
            var departParameter = depart.HasValue ?
                new ObjectParameter("depart", depart) :
                new ObjectParameter("depart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<verifDates_Result>("verifDates", idBieParameter, arriveeParameter, departParameter);
        }
    
        public virtual ObjectResult<verifDates2_Result> verifDates2(Nullable<int> idBie, Nullable<System.DateTime> arrivee, Nullable<System.DateTime> depart)
        {
            var idBieParameter = idBie.HasValue ?
                new ObjectParameter("idBie", idBie) :
                new ObjectParameter("idBie", typeof(int));
    
            var arriveeParameter = arrivee.HasValue ?
                new ObjectParameter("arrivee", arrivee) :
                new ObjectParameter("arrivee", typeof(System.DateTime));
    
            var departParameter = depart.HasValue ?
                new ObjectParameter("depart", depart) :
                new ObjectParameter("depart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<verifDates2_Result>("verifDates2", idBieParameter, arriveeParameter, departParameter);
        }
    
        public virtual ObjectResult<VerifSiDateEstDispo_Result> VerifSiDateEstDispo(Nullable<int> idBien, Nullable<System.DateTime> dateArrivee, Nullable<System.DateTime> dateDepart)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            var dateArriveeParameter = dateArrivee.HasValue ?
                new ObjectParameter("dateArrivee", dateArrivee) :
                new ObjectParameter("dateArrivee", typeof(System.DateTime));
    
            var dateDepartParameter = dateDepart.HasValue ?
                new ObjectParameter("dateDepart", dateDepart) :
                new ObjectParameter("dateDepart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerifSiDateEstDispo_Result>("VerifSiDateEstDispo", idBienParameter, dateArriveeParameter, dateDepartParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> VerifSiDateEstDispo0(Nullable<int> idBien, Nullable<System.DateTime> dateArrivee, Nullable<System.DateTime> dateDepart)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            var dateArriveeParameter = dateArrivee.HasValue ?
                new ObjectParameter("dateArrivee", dateArrivee) :
                new ObjectParameter("dateArrivee", typeof(System.DateTime));
    
            var dateDepartParameter = dateDepart.HasValue ?
                new ObjectParameter("dateDepart", dateDepart) :
                new ObjectParameter("dateDepart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("VerifSiDateEstDispo0", idBienParameter, dateArriveeParameter, dateDepartParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> VerifSiDateEstDispo2(Nullable<int> idBien, Nullable<System.DateTime> dateArrivee, Nullable<System.DateTime> dateDepart)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            var dateArriveeParameter = dateArrivee.HasValue ?
                new ObjectParameter("dateArrivee", dateArrivee) :
                new ObjectParameter("dateArrivee", typeof(System.DateTime));
    
            var dateDepartParameter = dateDepart.HasValue ?
                new ObjectParameter("dateDepart", dateDepart) :
                new ObjectParameter("dateDepart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("VerifSiDateEstDispo2", idBienParameter, dateArriveeParameter, dateDepartParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> VerifSiDateEstDispos(Nullable<int> idBien, Nullable<System.DateTime> dateArrivee, Nullable<System.DateTime> dateDepart)
        {
            var idBienParameter = idBien.HasValue ?
                new ObjectParameter("idBien", idBien) :
                new ObjectParameter("idBien", typeof(int));
    
            var dateArriveeParameter = dateArrivee.HasValue ?
                new ObjectParameter("dateArrivee", dateArrivee) :
                new ObjectParameter("dateArrivee", typeof(System.DateTime));
    
            var dateDepartParameter = dateDepart.HasValue ?
                new ObjectParameter("dateDepart", dateDepart) :
                new ObjectParameter("dateDepart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("VerifSiDateEstDispos", idBienParameter, dateArriveeParameter, dateDepartParameter);
        }
    }
}
