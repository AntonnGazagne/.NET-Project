using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Isen.DotNet.Library.Lists;

namespace Isen.DotNet.Library.Models
{
    public class Joueur : BaseModel<Joueur>
    {
        public override int Id { get;set; }
        [NotMapped]
        public override string Name
        {
            get { return _name ?? 
                (_name = $"{LastName} {FirstName}"); }
            set { _name = value; }
        }

        private string _name;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual MyCollection<Historique> HistoriqueCollection { get; set; }

        [NotMapped]
        public int? Age
        {
            get
            { 
                if (!DateOfBirth.HasValue)
                    return null;
                var age = 
                    DateTime.Now - DateOfBirth.Value;
                return (int)Math.Floor(
                    age.TotalDays / 365);
            }
        }


        [NotMapped]
        public override string Display
        {
            get
            {
                var sAge = Age.HasValue ?
                    Age.ToString() : 
                    "undef";
                var display = $"{base.Display}|Age={sAge}";
                return display;
            }
        }

        public override void Map(Joueur copy)
        {
            base.Map(copy);
            FirstName = copy.FirstName;
            LastName = copy.LastName;
            DateOfBirth = copy.DateOfBirth;
        }

        public override dynamic ToDynamic()
        {
            var baseDynamic = base.ToDynamic();
            baseDynamic.FirstName = FirstName;
            baseDynamic.LastName = LastName;
            baseDynamic.DateOfBirth = DateOfBirth;
            baseDynamic.Age = Age;
            return baseDynamic;
        }
    }
}