﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psAdSegmentTrans
    {
        [Key]
        public long pkId { get; set; }
        public long iAccountId { get; set; }
        public long iSegmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dStampDate { get; set; }
        public long iUserId { get; set; }
    }
}