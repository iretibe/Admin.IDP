﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psAdAccount
    {
        [Key]
        public long pkId { get; set; }
        [Required]
        [StringLength(20)]
        public string szAccountId { get; set; }
        [Required]
        [StringLength(100)]
        public string szAccountName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dStampDate { get; set; }
        [StringLength(20)]
        public string szHarewareKey { get; set; }
        [StringLength(100)]
        public string szContactFirstName { get; set; }
        [StringLength(100)]
        public string szContactLastName { get; set; }
        [StringLength(100)]
        public string szContactEmail { get; set; }
        [StringLength(50)]
        public string szContactCell { get; set; }
        [StringLength(50)]
        public string szContactPhone { get; set; }
        [StringLength(50)]
        public string szFax { get; set; }
        [StringLength(200)]
        public string szAddress { get; set; }
        [StringLength(100)]
        public string szWebsite { get; set; }
        [Required]
        [StringLength(50)]
        public string szRegKey { get; set; }
        public int iDuration { get; set; }
        public int iNoOfUsers { get; set; }
        public int? iNoOfCompanies { get; set; }
        public string szLogo { get; set; }
    }
}