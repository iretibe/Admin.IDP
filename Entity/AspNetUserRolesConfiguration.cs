﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.IDP.Entity
{
    public class AspNetUserRolesConfiguration : IEntityTypeConfiguration<AspNetUserRoles>
    {
        public void Configure(EntityTypeBuilder<AspNetUserRoles> entity)
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.HasIndex(e => e.RoleId);
        }
    }
}
