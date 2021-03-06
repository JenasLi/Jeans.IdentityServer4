﻿using Jeans.IdentityServer4.UI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeans.IdentityServer4.UI.Data.Mapping
{
    public class PersistedGrantMap : IEntityTypeConfiguration<PersistedGrant>
    {
        public void Configure(EntityTypeBuilder<PersistedGrant> builder)
        {
            builder.HasKey(k => k.Key);
            builder.Property(p => p.Key).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Type).HasMaxLength(50).IsRequired();
            builder.Property(p => p.SubjectId).HasMaxLength(200);
            builder.Property(p => p.ClientId).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Data).IsRequired();
        }
    }
}
