﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class psAdUserGroup_LogConfiguration : IEntityTypeConfiguration<psAdUserGroup_Log>
    {
        public void Configure(EntityTypeBuilder<psAdUserGroup_Log> entity)
        {
            entity.Property(e => e.dCreateDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.dStampDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.szCompanyId)
                .IsUnicode(false)
                .HasDefaultValueSql("((-1))");

            entity.Property(e => e.szGroupName)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            entity.Property(e => e.szStatus)
                .IsUnicode(false)
                .HasDefaultValueSql("((-1))")
                .HasComment("This filed describes the status of a record whether in-use or not-in-use");

            entity.Property(e => e.szUserId)
                .IsUnicode(false)
                .HasDefaultValueSql("((-1))");
        }
    }
}
