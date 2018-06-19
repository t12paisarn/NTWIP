using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MFOWebCoreMaster.Models

{
    public class MisProdOrder
    {   [Key]
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public int LineNo { get; set; }
        public string OrderDesc { get; set; }
        public string ItemId { get; set; }
        public string CustId { get; set; }
        public double? OrderQty { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Priority { get; set; }
        public int? SeqNo { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string AuxAttrOne { get; set; }
        public string AuxAttrTwo { get; set; }
        public double? AuxValueOne { get; set; }
        public double? AuxValueTwo { get; set; }
        public bool? AuxFlagOne { get; set; }
        public bool? AuxFlagTwo { get; set; }
        public DateTime? AuxDateOne { get; set; }
        public DateTime? AuxDateTwo { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}
