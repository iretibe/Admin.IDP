﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psAdPersonelSegmentRequest
    {
        [Key]
        public long pkId { get; set; }
        public long iPersonelId { get; set; }
        public long iSegmentId { get; set; }
        public long iSegmentItem { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dCreatedate { get; set; }
    }
}