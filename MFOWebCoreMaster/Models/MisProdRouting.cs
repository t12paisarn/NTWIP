using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MFOWebCoreMaster.Models
{
    public class MisProdRouting
    {
        public int Routing_Id { get; set; }

        [Key]
        public int?  Order_Id { get; set; }
        public string Order_No { get; set; }
        public int Line_No { get; set; }
        public string Op_No { get; set; }
        public string Op_Desc { get; set; }
        public string Work_Cntr { get; set; }
        public string Resource { get; set; }
        public double? Setup_Time { get; set; }
        public double? Proc_Time { get; set; }
        public double? Clean_Time { get; set; }
        public bool? Proc_Batch_Flag { get; set; }
        public double? Op_Qty { get; set; }
        public string Uom { get; set; }
        public DateTime? Setup_Start_Time { get; set; }
        public DateTime? Proc_Start_Time { get; set; }
        public DateTime? Proc_End_Time { get; set; }
        public DateTime? Clean_End_Time { get; set; }
        public string Prede_Op { get; set; }
        public string Succ_Op { get; set; }
        public int? Pdm_Type { get; set; }
        public double? Pdm_Time { get; set; }
        public int? Prefer_Resource_Id { get; set; }
        public int? Prefer_Resource_Set_Id { get; set; }
        public DateTime? Earliest_Start_Time { get; set; }
        public int? Allocated_Resource_Id { get; set; }
        public bool? Locked_Flag { get; set; }
        public int? Actual_Resource_Id { get; set; }
        public double? Actual_Qty { get; set; }
        public DateTime? Actual_Setup_Start_Time { get; set; }
        public DateTime? Actual_Proc_Start_Time { get; set; }
        public DateTime? Midbatch_Time { get; set; }
        public DateTime? Midbatch_Calc_Proc_End_Time { get; set; }
        public DateTime? Midbatch_Calc_Clean_End_Time { get; set; }
        public DateTime? Actual_Proc_End_Time { get; set; }
        public DateTime? Actual_Clean_End_Time { get; set; }
        public string Ref_Id { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Aux_Attr_One { get; set; }
        public string Aux_Attr_Two { get; set; }
        public double? Aux_Value_One { get; set; }
        public double? Aux_Value_Two { get; set; }
        public bool? Aux_Flag_One { get; set; }
        public bool? Aux_Flag_Two { get; set; }
        public DateTime? Aux_Date_One { get; set; }
        public DateTime? Aux_Date_Two { get; set; }
        public DateTime? Create_Date { get; set; }
        public string Create_User { get; set; }
        public DateTime? Update_Date { get; set; }
        public string Update_User { get; set; }
    }
}
