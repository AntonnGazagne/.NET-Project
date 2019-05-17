using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Isen.DotNet.Library.Context;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Isen.DotNet.Library.Repositories.Db
{
    public class DbContextHistoriqueRepository :
        BaseDbRepository<Historique>,
        IHistoriqueRepository
    {
        ApplicationDbContext _dbContext;
        public DbContextHistoriqueRepository(
            ApplicationDbContext dbContext) : 
            base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override IQueryable<Historique> Includes(IQueryable<Historique> includes)
        {
            var inc = base.Includes(includes);
            inc = inc.Include(e => e.Club);
            inc = inc.Include(e => e.Joueur);
            return inc;
        }

        public new void Update(Historique entity)
        {
            if (entity.IsNew)
            {
                DbContext.Add(entity);
            }
            else
            {
                DbContext.Update(entity);
            }
        }
    }
}
