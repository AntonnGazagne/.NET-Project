using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Isen.DotNet.Library.Lists;
using Newtonsoft.Json.Linq;

namespace Isen.DotNet.Library.Models
{
    public class Club : BaseModel<Club>
    {
        public override int Id { get;set; }
        public override string Name { get;set; }
        public string Adresse { get;set; }
        public string Logo { get;set; }
        public string GPS { get;set; }
        public virtual MyCollection<Historique> HistoriqueCollection { get;set; }

        [NotMapped]
        public override string Display => 
            $"{base.Display}|Name={Name}";

        public override void Map(Club copy)
        {
            base.Map(copy);
            Adresse = copy.Adresse;
            Logo = copy.Logo;
            GPS = copy.GPS;
        }

        public override dynamic ToDynamic()
        {
            var baseDynamic = base.ToDynamic();
            baseDynamic.Adresse = Adresse;
            baseDynamic.Logo = Logo;
            baseDynamic.GPS = GPS;
            if(HistoriqueCollection.Count > 0)
            {
                baseDynamic.Historiques = new dynamic[HistoriqueCollection.Count] ;  
                for (int i = 0; i < HistoriqueCollection.Count; i++)
                {
                    baseDynamic.Historiques[i] = HistoriqueCollection[i].ToDynamic();
                }
            }
            return baseDynamic;
        }
    }
}