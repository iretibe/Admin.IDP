﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class IdentityResourcePropertiesConfiguration : IEntityTypeConfiguration<IdentityResourceProperties>
    {
        public void Configure(EntityTypeBuilder<IdentityResourceProperties> entity)
        {
            entity.HasIndex(e => e.IdentityResourceId);
        }
    }
}
