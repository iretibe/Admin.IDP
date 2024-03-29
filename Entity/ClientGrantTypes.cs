﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class ClientGrantTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string GrantType { get; set; }
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty(nameof(Clients.ClientGrantTypes))]
        public virtual Clients Client { get; set; }
    }
}