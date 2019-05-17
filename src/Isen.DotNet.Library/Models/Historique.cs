using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Isen.DotNet.Library.Repositories.Interfaces;
using Newtonsoft.Json;

namespace Isen.DotNet.Library.Models
{
    public class Historique : BaseModel<Historique>
    {
        public override int Id { get;set; }
        public override string Name { get;set; }

        public int? ClubId { get;set; }
        public Club Club { get;set; }
        public DateTime Debut { get;set; }
        public DateTime Fin { get;set; }

        public int? JoueurId { get;set; }
        public Joueur Joueur {get;set;}
        

        [NotMapped]
        public override string Display => 
            $"{base.Display}|Club={Club}|Debut={Debut.Date}|Fin={Fin.Date}";

        public override void Map(Historique copy)
        {
            base.Map(copy);
            Club = copy.Club;
            ClubId = copy.ClubId;
            Debut = copy.Debut;
            Fin = copy.Fin;
            Joueur = copy.Joueur;
            JoueurId = copy.JoueurId;
        }

        
        public override dynamic ToDynamic()
        {
            var baseDynamic = base.ToDynamic();
            baseDynamic.Debut = Debut;
            baseDynamic.Fin = Fin;
            baseDynamic.Joueur = Joueur.ToDynamic();
            return baseDynamic;
        }
    }
}