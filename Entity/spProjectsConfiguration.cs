﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class spProjectsConfiguration : IEntityTypeConfiguration<spProjects>
    {
        public void Configure(EntityTypeBuilder<spProjects> entity)
        {
            entity.Property(e => e.dCreatedate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.szDescription).IsUnicode(false);

            entity.Property(e => e.szProjectName).IsUnicode(false);

            entity.Property(e => e.szUniqueIdentifier).HasDefaultValueSql("(newid())");
        }
    }
}
