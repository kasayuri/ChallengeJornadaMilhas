using ChallengeJornadaMilhas.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JornadaMilhas.Data.Mappings
{
   public class DepoimentoMapping : IEntityTypeConfiguration<Depoimento>
    {
        public void Configure(EntityTypeBuilder<Depoimento> builder)
        {
            throw new NotImplementedException();
        }
    }
}
