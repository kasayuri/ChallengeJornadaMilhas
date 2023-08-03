using ChallengeJornadaMilhas.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JornadaMilhas.Data.Context
{
    public class JornadaMilhasDbContext : DbContext
    {
        public JornadaMilhasDbContext(DbContextOptions<JornadaMilhasDbContext> options) : base(options) { }
    
        public DbSet<Depoimento> Depoimentos { get; set; }
    }
}
