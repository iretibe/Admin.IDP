﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class psAdReportSortConfiguration : IEntityTypeConfiguration<psAdReportSort>
    {
        public void Configure(EntityTypeBuilder<psAdReportSort> entity)
        {
            entity.Property(e => e.dCreatedate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.iId).HasDefaultValueSql("((-1))");

            entity.Property(e => e.iMenuId).HasDefaultValueSql("((-1))");
        }
    }
}
