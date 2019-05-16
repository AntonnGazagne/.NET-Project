using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Isen.DotNet.Library.Context;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Isen.DotNet.Library.Repositories.Db
{
    public class DbContextJoueurRepository :
        BaseDbRepository<Joueur>,
        IJoueurRepository
    {
        ApplicationDbContext _dbContext;
        public DbContextJoueurRepository(
            ApplicationDbContext dbContext) : 
            base(dbContext)
        {
            _dbContext =dbContext;
        }

        public override IQueryable<Joueur> Includes(IQueryable<Joueur> includes)
        {
            var inc = base.Includes(includes);
            inc = inc.Include(e => e.HistoriqueCollection);
            return inc;
        }

        public new void Delete(int id)
        {
            var entity = Single(id);
            if (entity != null)
            {
                foreach(var c in _dbContext.HistoriqueCollection.ToList())
                {
                    if(c.Joueur == entity)
                        _dbContext.HistoriqueCollection.Remove(c);
                }
                DbContext.Remove(entity);
            }
        }

        public new void Delete(Joueur entity)
        {
            foreach(var c in _dbContext.HistoriqueCollection.ToList())
            {
                if(c.Joueur == entity)
                    _dbContext.HistoriqueCollection.Remove(c);
            }
            DbContext.Remove(entity);
        }
    }
}
