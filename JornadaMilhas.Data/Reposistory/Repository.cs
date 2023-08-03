using JornadaMilhas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JornadaMilhas.Data.Reposistory
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly JornadaMilhasDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(JornadaMilhasDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

    }
}
