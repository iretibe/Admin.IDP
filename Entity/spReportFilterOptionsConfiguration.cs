﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class spReportFilterOptionsConfiguration : IEntityTypeConfiguration<spReportFilterOptions>
    {
        public void Configure(EntityTypeBuilder<spReportFilterOptions> entity)
        {
            entity.Property(e => e.dCreatedate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.iOperatorId).HasDefaultValueSql("((-1))");
        }
    }
}