﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.IDP.Entity
{
    public partial class psExchangeRate_Log
    {
        [Key]
        public long pkId { get; set; }
        public long Id { get; set; }
        [Required]
        [StringLength(150)]
        public string szCurrency { get; set; }
        [Column(TypeName = "money")]
        public decimal mBuyingRate { get; set; }
        [Column(TypeName = "money")]
        public decimal mSellingRate { get; set; }
        [Column(TypeName = "money")]
        public decimal mAverageRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dExchangeRateDate { get; set; }
        [StringLength(250)]
        public string szUserId { get; set; }
    }
}