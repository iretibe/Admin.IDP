﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psAdSegment
    {
        [Key]
        public long pkId { get; set; }
        [Required]
        [StringLength(50)]
        public string szName { get; set; }
        [StringLength(50)]
        public string szTable { get; set; }
    }
}