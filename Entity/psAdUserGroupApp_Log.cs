﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psAdUserGroupApp_Log
    {
        [Key]
        public long pkId { get; set; }
        public long Id { get; set; }
        public long iGroupId { get; set; }
        public long iAppId { get; set; }
        public long iMenuId { get; set; }
        public long iParent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dCreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dStampDate { get; set; }
    }
}