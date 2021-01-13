﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class DeviceCodesConfiguration : IEntityTypeConfiguration<DeviceCodes>
    {
        public void Configure(EntityTypeBuilder<DeviceCodes> entity)
        {
            entity.HasIndex(e => e.DeviceCode)
                .IsUnique();

            entity.HasIndex(e => e.Expiration);
        }
    }
}