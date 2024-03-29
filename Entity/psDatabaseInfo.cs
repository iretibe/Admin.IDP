﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psDatabaseInfo
    {
        [Key]
        public Guid pkId { get; set; }
        [Required]
        [StringLength(100)]
        public string szServerName { get; set; }
        [Required]
        [StringLength(50)]
        public string szDatabaseName { get; set; }
        [Required]
        [StringLength(50)]
        public string szServerUserID { get; set; }
        [Required]
        public string szServerUserPassword { get; set; }
        public bool bTrustedConnection { get; set; }
        public bool? bMultipleActiveResultSets { get; set; }
        public Guid iAssemblyId { get; set; }
        [Required]
        public string szConnectionString { get; set; }
        public Guid? iUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dCreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dLastUpdate { get; set; }
        public Guid? iUpdatedBy { get; set; }
    }
}