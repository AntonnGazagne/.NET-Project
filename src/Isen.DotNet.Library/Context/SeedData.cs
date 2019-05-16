using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;

namespace Isen.DotNet.Library.Context
{
    public class SeedData
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IClubRepository _clubRepository;
        private readonly IJoueurRepository _joueurRepository;
        private readonly IHistoriqueRepository _historiqueRepository;

        public SeedData(
            ApplicationDbContext dbContext,
            IClubRepository clubRepository,
            IJoueurRepository joueurRepository,
            IHistoriqueRepository historiqueRepository)
        {
            _dbContext = dbContext;
            _clubRepository = clubRepository;
            _joueurRepository = joueurRepository;
            _historiqueRepository = historiqueRepository;
        }

        public void DropCreateDatabase()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
        }

        public void AddClubs()
        {
            // Ne rien faire s'il y a déjà des villes
            if (_dbContext.ClubCollection.Any()) return;

            var clubs = new List<Club>()
            {
                new Club() 
                { 
                    Name = "Olympique lyonnais", 
                    Adresse = "Groupama OL Training Center",
                    GPS="45° 45′ 35″ nord,4° 50′ 32″ est", 
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/e/e2/Olympique_lyonnais_%28logo%29.svg/800px-Olympique_lyonnais_%28logo%29.svg.png" 
                },
                new Club() 
                {
                    Name = "Paris Football Club",
                    Adresse = "Stade Robert-Bobin" ,
                    GPS="48° 37′ 20″ N,2° 23′ 35″ E",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/d/db/Logo_Paris_FC_2011.svg/800px-Logo_Paris_FC_2011.svg.png"
                },
                new Club() 
                {
                    Name = "En avant de Guingamp",
                    Adresse = "Stade Fred-Aubert",
                    GPS="48° 30′ 32″ N,2° 44′ 37″ O",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/9/99/En_Avant_de_Guingamp_logo.svg/1920px-En_Avant_de_Guingamp_logo.svg.png" 
                },
                new Club() 
                {
                    Name = "Montpellier Hérault Sport Club",
                    Adresse = "Stade Jules Rime",
                    GPS="43° 36′ 43″ nord,3° 52′ 38″ est", 
                    Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Montpellier_H%C3%A9rault_Sport_Club_%28logo%2C_2000%29.svg/800px-Montpellier_H%C3%A9rault_Sport_Club_%28logo%2C_2000%29.svg.png" 
                },
                new Club() 
                { 
                    Name = "Arsenal Women Football Club", 
                    Adresse = "Meadow Park",
                    GPS="51° 39′ 43″ N,0° 16′ 20″ O", 
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/5/53/Arsenal_FC.svg/800px-Arsenal_FC.svg.png" 
                },
                new Club() {
                    Name = "Association sportive de Saint-Étienne", 
                    Adresse = "Stade Salif Keita",
                    GPS="45° 26′ 05″ nord, 4° 23′ 25″ est", 
                    Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Logo_AS_Saint-%C3%89tienne.svg/800px-Logo_AS_Saint-%C3%89tienne.svg.png" 
                }
                //Les autres clubs ne seront pas fait(Trop Long), je prendrai au hasard ceux-ci pour les joueurs
            };
            clubs.ForEach(club => _clubRepository.Update(club));
            _clubRepository.SaveChanges();
        }

        public void AddJoueurs()
        {
            // Ne rien faire si non vide
            if(_dbContext.JoueurCollection.Any()) return;

            var joueurs =new List<Joueur>()
            {
                new Joueur()
                { 
                    FirstName = "Sarah", 
                    LastName = "Bouhaddi", 
                    Name = "Bouhaddi Sarah",
                    DateOfBirth = new DateTime(1986,10, 17)
                },
                new Joueur()
                { 
                    FirstName = "Solène", 
                    LastName = "Durand", 
                    Name = "Durand Solène",
                    DateOfBirth = new DateTime(1994,11, 20)
                },
                new Joueur()
                { 
                    FirstName = "Pauline", 
                    LastName = "Peyraud-Magnin", 
                    Name = "Peyraud-Magnin Pauline",
                    DateOfBirth = new DateTime(1992, 3, 17)
                },
                new Joueur()
                { 
                    FirstName = "Julie", 
                    LastName = "Debever", 
                    Name = "Debever Julie",
                    DateOfBirth = new DateTime(1988, 4, 18)
                },
                new Joueur()
                { 
                    FirstName = "Sakina", 
                    LastName = "Karchaoui", 
                    Name = "Karchaoui Sakina",
                    DateOfBirth = new DateTime(1996, 1, 26)
                },
                new Joueur()
                {  
                    FirstName = "Amel", 
                    LastName = "Majiri", 
                    Name = "Majiri Amel",
                    DateOfBirth = new DateTime(1993, 1, 25)
                },
                new Joueur()
                { 
                    FirstName = "Griedge", 
                    LastName = "Mbock", 
                    Name = "Mbock Griedge",
                    DateOfBirth = new DateTime(1995, 1, 25)
                },
                new Joueur()
                { 
                    FirstName = "Eve", 
                    LastName = "Périsset", 
                    Name = "Périsset Eve",
                    DateOfBirth = new DateTime(1994, 12, 24)
                },
                new Joueur()
                { 
                    FirstName = "Wendie", 
                    LastName = "Renard", 
                    Name = "Renard Wendie",
                    DateOfBirth = new DateTime(1990, 7, 20)
                },
                new Joueur()
                { 
                    FirstName = "Marion", 
                    LastName = "Torrent", 
                    Name = "Torrent Marion",
                    DateOfBirth = new DateTime(1992, 4, 17)
                },
                new Joueur()
                {  
                    FirstName = "Aïssatou", 
                    LastName = "Tounkara", 
                    Name = "Tounkara Aïssatou",
                    DateOfBirth = new DateTime(1995, 3, 16)
                },
                new Joueur()
                { 
                    FirstName = "Charlotte", 
                    LastName = "Bibault", 
                    Name = "Bibault Charlotte",
                    DateOfBirth = new DateTime(1990, 6, 5)
                },
                new Joueur()
                { 
                    FirstName = "Elise", 
                    LastName = "Bussaglia", 
                    Name = "Bussaglia Elise",
                    DateOfBirth = new DateTime(1985, 9, 24)
                },
                new Joueur()
                { 
                    FirstName = "Maéva", 
                    LastName = "Clemaron", 
                    Name = "Clemaron Maéva",
                    DateOfBirth = new DateTime(1992, 11, 10)
                },
                new Joueur()
                { 
                    FirstName = "Grace", 
                    LastName = "Geyoro", 
                    Name = "Geyoro Grace",
                    DateOfBirth = new DateTime(1997, 7, 2)
                },
                new Joueur()
                { 
                    FirstName = "Amandine", 
                    LastName = "Henry", 
                    Name = "Henry Amandine",
                    DateOfBirth = new DateTime(1989, 9, 28)
                },
                new Joueur()
                { 
                    FirstName = "Gaëtane", 
                    LastName = "Thiney", 
                    Name = "Thiney Gaëtane",
                    DateOfBirth = new DateTime(1985, 10, 28)
                },
                new Joueur()
                { 
                    FirstName = "Viviane", 
                    LastName = "Asseyi", 
                    Name = "Asseyi Viviane",
                    DateOfBirth = new DateTime(1993, 11, 20)
                },
                new Joueur()
                { 
                    FirstName = "Delphine", 
                    LastName = "Cascarino", 
                    Name = "Cascarino Delphine",
                    DateOfBirth = new DateTime(1997, 2, 5)
                },
                new Joueur()
                { 
                    FirstName = "Kadidiatou", 
                    LastName = "Diani", 
                    Name = "Diani Kadidiatou",
                    DateOfBirth = new DateTime(1994, 4, 1)
                },
                new Joueur()
                { 
                    FirstName = "Valérie", 
                    LastName = "Gauvin", 
                    Name = "Gauvin Valérie",
                    DateOfBirth = new DateTime(1996, 6, 1)
                },
                new Joueur()
                { 
                    FirstName = "Emelyne", 
                    LastName = "Laurent", 
                    Name = "Laurent Emelyne",
                    DateOfBirth = new DateTime(1998, 11, 4)
                },
                new Joueur()
                { 
                    FirstName = "Eugénie", 
                    LastName = "Le Sommer", 
                    Name = "Le Sommer Eugénie",
                    DateOfBirth = new DateTime(1989, 5, 18)
                }
            };
            joueurs.ForEach(city => _joueurRepository.Update(city));
            _joueurRepository.SaveChanges();
        }

        public void AddHistorique()
        {
            // Ne rien faire si non vide
            if(_dbContext.HistoriqueCollection.Any()) return;

            var historiques =new List<Historique>()
            {
                new Historique()
                {
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Olympique lyonnais"),
                    Debut = new DateTime(2009, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    JoueurId = 1
                },
                new Historique()
                {
                    Name = "Club Précedent",
                    Club = _clubRepository.Single("Paris Football Club"),
                    Debut = new DateTime(2006, 1, 1),
                    Fin = new DateTime(2009, 1, 1),
                    JoueurId = 1
                },
                new Historique()
                {
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("En avant de Guingamp"),
                    Debut = new DateTime(2017, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    JoueurId = 2
                },
                new Historique()
                {
                    Name = "Club Précedent",
                    Club = _clubRepository.Single("Montpellier Hérault Sport Club"),
                    Debut = new DateTime(2011, 1, 1),
                    Fin = new DateTime(2017, 1, 1),
                    JoueurId = 2
                },
                new Historique()
                {
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Arsenal Women Football Club"),
                    Debut = new DateTime(2018, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    JoueurId = 3
                },
                new Historique()
                {
                    Name = "Club Précedent",
                    Club = _clubRepository.Single("Olympique lyonnais"),
                    Debut = new DateTime(2017, 1, 1),
                    Fin = new DateTime(2018, 1, 1),
                    JoueurId = 3
                },
                new Historique()
                {
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Montpellier Hérault Sport Club"),
                    Debut = new DateTime(2012, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    JoueurId = 4
                },
                new Historique()
                {
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Olympique lyonnais"),
                    Debut = new DateTime(2010, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    JoueurId = 5
                }
            };

            historiques.ForEach(historique => _historiqueRepository.Update(historique));
            _historiqueRepository.SaveChanges();
        }
    }
}
