﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class spPersonnel
    {
        [Key]
        public int pkID { get; set; }
        [Required]
        [StringLength(50)]
        public string szUserName { get; set; }
        [Required]
        [StringLength(50)]
        public string szFirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string szLastName { get; set; }
        [Required]
        [StringLength(50)]
        public string szEmailAddress { get; set; }
        [Column(TypeName = "text")]
        public string szImage { get; set; }
        public int? iEmployeeID { get; set; }
        [Required]
        [StringLength(5)]
        public string szType { get; set; }
        public int iUserID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dStampDate { get; set; }
        public int? iCompanyID { get; set; }
        public int? iConcurrency { get; set; }
    }
}