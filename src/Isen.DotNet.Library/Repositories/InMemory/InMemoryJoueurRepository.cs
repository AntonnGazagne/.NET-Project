using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryJoueurRepository :
        BaseInMemoryRepository<Joueur>,
        IJoueurRepository
    {   

        public override List<Joueur> SampleData =>
            new List<Joueur>()
            {
                new Joueur()
                { 
                    Id = 1, 
                    FirstName = "Sarah", 
                    LastName = "Bouhaddi", 
                    Name = "Bouhaddi Sarah",
                    DateOfBirth = new DateTime(1986,10, 17)
                },
                new Joueur()
                { 
                    Id = 2, 
                    FirstName = "Solène", 
                    LastName = "Durand", 
                    Name = "Durand Solène",
                    DateOfBirth = new DateTime(1994,11, 20)
                },
                new Joueur()
                { 
                    Id = 3, 
                    FirstName = "Pauline", 
                    LastName = "Peyraud-Magnin", 
                    Name = "Peyraud-Magnin Pauline",
                    DateOfBirth = new DateTime(1992, 3, 17)
                },
                new Joueur()
                { 
                    Id = 4, 
                    FirstName = "Julie", 
                    LastName = "Debever", 
                    Name = "Debever Julie",
                    DateOfBirth = new DateTime(1988, 4, 18)
                },
                new Joueur()
                { 
                    Id = 5, 
                    FirstName = "Sakina", 
                    LastName = "Karchaoui", 
                    Name = "Karchaoui Sakina",
                    DateOfBirth = new DateTime(1996, 1, 26)
                },
                new Joueur()
                { 
                    Id = 6, 
                    FirstName = "Amel", 
                    LastName = "Majiri", 
                    Name = "Majiri Amel",
                    DateOfBirth = new DateTime(1993, 1, 25)
                },
                new Joueur()
                { 
                    Id = 7, 
                    FirstName = "Griedge", 
                    LastName = "Mbock", 
                    Name = "Mbock Griedge",
                    DateOfBirth = new DateTime(1995, 1, 25)
                },
                new Joueur()
                { 
                    Id = 8, 
                    FirstName = "Eve", 
                    LastName = "Périsset", 
                    Name = "Périsset Eve",
                    DateOfBirth = new DateTime(1994, 12, 24)
                },
                new Joueur()
                { 
                    Id = 9, 
                    FirstName = "Wendie", 
                    LastName = "Renard", 
                    Name = "Renard Wendie",
                    DateOfBirth = new DateTime(1990, 7, 20)
                },
                new Joueur()
                { 
                    Id = 10, 
                    FirstName = "Marion", 
                    LastName = "Torrent", 
                    Name = "Torrent Marion",
                    DateOfBirth = new DateTime(1992, 4, 17)
                },
                new Joueur()
                { 
                    Id = 11, 
                    FirstName = "Aïssatou", 
                    LastName = "Tounkara", 
                    Name = "Tounkara Aïssatou",
                    DateOfBirth = new DateTime(1995, 3, 16)
                },
                new Joueur()
                { 
                    Id = 12, 
                    FirstName = "Charlotte", 
                    LastName = "Bibault", 
                    Name = "Bibault Charlotte",
                    DateOfBirth = new DateTime(1990, 6, 5)
                },
                new Joueur()
                { 
                    Id = 13, 
                    FirstName = "Elise", 
                    LastName = "Bussaglia", 
                    Name = "Bussaglia Elise",
                    DateOfBirth = new DateTime(1985, 9, 24)
                },
                new Joueur()
                { 
                    Id = 14, 
                    FirstName = "Maéva", 
                    LastName = "Clemaron", 
                    Name = "Clemaron Maéva",
                    DateOfBirth = new DateTime(1992, 11, 10)
                },
                new Joueur()
                { 
                    Id = 15, 
                    FirstName = "Grace", 
                    LastName = "Geyoro", 
                    Name = "Geyoro Grace",
                    DateOfBirth = new DateTime(1997, 7, 2)
                },
                new Joueur()
                { 
                    Id = 16, 
                    FirstName = "Amandine", 
                    LastName = "Henry", 
                    Name = "Henry Amandine",
                    DateOfBirth = new DateTime(1989, 9, 28)
                },
                new Joueur()
                { 
                    Id = 17, 
                    FirstName = "Gaëtane", 
                    LastName = "Thiney", 
                    Name = "Thiney Gaëtane",
                    DateOfBirth = new DateTime(1985, 10, 28)
                },
                new Joueur()
                { 
                    Id = 18, 
                    FirstName = "Viviane", 
                    LastName = "Asseyi", 
                    Name = "Asseyi Viviane",
                    DateOfBirth = new DateTime(1993, 11, 20)
                },
                new Joueur()
                { 
                    Id = 19, 
                    FirstName = "Delphine", 
                    LastName = "Cascarino", 
                    Name = "Cascarino Delphine",
                    DateOfBirth = new DateTime(1997, 2, 5)
                },
                new Joueur()
                { 
                    Id = 20, 
                    FirstName = "Kadidiatou", 
                    LastName = "Diani", 
                    Name = "Diani Kadidiatou",
                    DateOfBirth = new DateTime(1994, 4, 1)
                },
                new Joueur()
                { 
                    Id = 21, 
                    FirstName = "Valérie", 
                    LastName = "Gauvin", 
                    Name = "Gauvin Valérie",
                    DateOfBirth = new DateTime(1996, 6, 1)
                },
                new Joueur()
                { 
                    Id = 22, 
                    FirstName = "Emelyne", 
                    LastName = "Laurent", 
                    Name = "Laurent Emelyne",
                    DateOfBirth = new DateTime(1998, 11, 4)
                },
                new Joueur()
                { 
                    Id = 23, 
                    FirstName = "Eugénie", 
                    LastName = "Le Sommer", 
                    Name = "Le Sommer Eugénie",
                    DateOfBirth = new DateTime(1989, 5, 18)
                }
            };
    }
}