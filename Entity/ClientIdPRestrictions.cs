﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class ClientIdPRestrictions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Provider { get; set; }
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty(nameof(Clients.ClientIdPRestrictions))]
        public virtual Clients Client { get; set; }
    }
}