﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class psLogsConfiguration : IEntityTypeConfiguration<psLogs>
    {
        public void Configure(EntityTypeBuilder<psLogs> entity)
        {
            entity.HasNoKey();

            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Exception).IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Level).IsUnicode(false);

            entity.Property(e => e.Logger).IsUnicode(false);

            entity.Property(e => e.Message).IsUnicode(false);

            entity.Property(e => e.Thread).IsUnicode(false);
        }
    }
}