﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class spStrings
    {
        [Key]
        public int pkID { get; set; }
        [Required]
        [StringLength(200)]
        public string szEnglish { get; set; }
        [Column(TypeName = "numeric(18, 4)")]
        public decimal iUniqueID { get; set; }
        [StringLength(100)]
        public string szParent { get; set; }
        public int? iParent { get; set; }
        [Required]
        [StringLength(10)]
        public string szType { get; set; }
        public string szDesc { get; set; }
        [StringLength(200)]
        public string szFrench { get; set; }
        [StringLength(200)]
        public string szSpanish { get; set; }
        [StringLength(200)]
        public string szPortuguese { get; set; }
        [StringLength(200)]
        public string szOtherLanguage { get; set; }
        public int? iApplication { get; set; }
        public int iStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dStampDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dCreateDate { get; set; }
    }
}