using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryHistoriqueRepository :
        BaseInMemoryRepository<Historique>,
        IHistoriqueRepository
    {
        
        private readonly IJoueurRepository _joueurRepository;
        private readonly IClubRepository _clubRepository;
        
        // Pattern d'Injection de Dépendance
        // aka IoC : Inversion of Control
        // aka DI : Dependency Injection
        public InMemoryHistoriqueRepository(
        IJoueurRepository joueurRepository,IClubRepository clubRepository)
        {
            _joueurRepository = joueurRepository;
            _clubRepository = clubRepository;
        }      
        public override List<Historique> SampleData =>
            new List<Historique>()
            {
                new Historique()
                {
                    Id = 1,
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Olympique lyonnais"),
                    Debut = new DateTime(2009, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    Joueur = _joueurRepository.Single(1)
                },
                new Historique()
                {
                    Id = 2,
                    Name = "Club Précedent",
                    Club = _clubRepository.Single("Paris Football Club"),
                    Debut = new DateTime(2006, 1, 1),
                    Fin = new DateTime(2009, 1, 1),
                    Joueur = _joueurRepository.Single(1)
                },
                new Historique()
                {
                    Id = 3,
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("En avant de Guingamp"),
                    Debut = new DateTime(2017, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    Joueur = _joueurRepository.Single(2)
                },
                new Historique()
                {
                    Id = 4,
                    Name = "Club Précedent",
                    Club = _clubRepository.Single("Montpellier Hérault Sport Club"),
                    Debut = new DateTime(2011, 1, 1),
                    Fin = new DateTime(2017, 1, 1),
                    Joueur = _joueurRepository.Single(2)
                },
                new Historique()
                {
                    Id = 5,
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Arsenal Women Football Club"),
                    Debut = new DateTime(2018, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    Joueur = _joueurRepository.Single(3)
                },
                new Historique()
                {
                    Id = 6,
                    Name = "Club Précedent",
                    Club = _clubRepository.Single("Olympique lyonnais"),
                    Debut = new DateTime(2017, 1, 1),
                    Fin = new DateTime(2018, 1, 1),
                    Joueur = _joueurRepository.Single(3)
                },
                new Historique()
                {
                    Id = 7,
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Montpellier Hérault Sport Club"),
                    Debut = new DateTime(2012, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    Joueur = _joueurRepository.Single(4)
                },
                new Historique()
                {
                    Id = 8,
                    Name = "Club Actuel",
                    Club = _clubRepository.Single("Olympique lyonnais"),
                    Debut = new DateTime(2010, 1, 1),
                    Fin = new DateTime(2019, 1, 1),
                    Joueur = _joueurRepository.Single(5)
                }
            };
    }
}