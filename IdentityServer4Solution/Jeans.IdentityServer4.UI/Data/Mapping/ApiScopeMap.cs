﻿using Jeans.IdentityServer4.UI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jeans.IdentityServer4.UI.Data.Mapping
{
    public class ApiScopeMap : IEntityTypeConfiguration<ApiScope>
    {
        public void Configure(EntityTypeBuilder<ApiScope> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();
            builder.Property(p => p.DisplayName).HasMaxLength(200);
            builder.Property(p => p.Description).HasMaxLength(1000);

            builder.HasMany(m => m.ApiScopeClaims).WithOne(o => o.ApiScope).HasForeignKey(fk => fk.ApiScopeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
