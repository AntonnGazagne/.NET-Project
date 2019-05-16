using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryClubRepository :
        BaseInMemoryRepository<Club>,
        IClubRepository
    {      
        public override List<Club> SampleData =>
            new List<Club>()
            {
                new Club() 
                { 
                    Id = 1, Name = "Olympique lyonnais", 
                    Adresse = "Groupama OL Training Center",
                    GPS="45° 45′ 35″ nord,4° 50′ 32″ est", 
                    Logo="https://fr.wikipedia.org/wiki/Fichier:Olympique_lyonnais_(logo).svg" 
                },
                new Club() 
                {
                    Id = 2, Name = "Paris Football Club",
                    Adresse = "Stade Robert-Bobin" ,
                    GPS="48° 37′ 20″ N,2° 23′ 35″ E",
                    Logo="https://fr.wikipedia.org/wiki/Fichier:Logo_Paris_FC_2011.svg"
                },
                new Club() 
                {
                    Id = 3, Name = "En avant de Guingamp",
                    Adresse = "Stade Fred-Aubert",
                    GPS="48° 30′ 32″ N,2° 44′ 37″ O",
                    Logo="https://fr.wikipedia.org/wiki/Fichier:En_Avant_de_Guingamp_logo.svg" 
                },
                new Club() 
                {
                    Id = 4, Name = "Montpellier Hérault Sport Club",
                    Adresse = "Stade Jules Rime",
                    GPS="43° 36′ 43″ nord,3° 52′ 38″ est", 
                    Logo="https://commons.wikimedia.org/wiki/File:Montpellier_H%C3%A9rault_Sport_Club_(logo,_2000).svg?uselang=fr" 
                },
                new Club() 
                { 
                    Id = 5, Name = "Arsenal Women Football Club", 
                    Adresse = "Meadow Park",
                    GPS="51° 39′ 43″ N,0° 16′ 20″ O", 
                    Logo="https://fr.wikipedia.org/wiki/Fichier:Arsenal_FC.svg" 
                },
                new Club() { 
                    Id = 6, Name = "Association sportive de Saint-Étienne", 
                    Adresse = "Stade Salif Keita",
                    GPS="45° 26′ 05″ nord, 4° 23′ 25″ est", 
                    Logo="https://commons.wikimedia.org/wiki/File:Logo_AS_Saint-%C3%89tienne.svg?uselang=fr" 
                }
                //Les autres clubs ne seront pas fait(Trop Long), je prendrai au hasard ceux-ci pour les joueurs
            };
    }
}