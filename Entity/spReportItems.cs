﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class spReportItems
    {
        [Key]
        public long pkId { get; set; }
        [StringLength(200)]
        public string szItemDescription { get; set; }
        public long? iProjectId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dCreatedate { get; set; }
        [StringLength(5)]
        public string szType { get; set; }
        [StringLength(50)]
        public string szOperator { get; set; }
    }
}