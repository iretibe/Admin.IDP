﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class spAdReportGroup
    {
        [Key]
        public long pkId { get; set; }
        public long iMenuId { get; set; }
        public long iId { get; set; }
        public bool? iRequire { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dCreatedate { get; set; }
    }
}