//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODataResturantsService
{
    using System;
    using System.Collections.Generic;
    
    public partial class dm_gltype
    {
        public System.Guid dm_gltypeId { get; set; }
        public string dm_name { get; set; }
        public Nullable<bool> dm_FinancialReport { get; set; }
        public Nullable<int> dm_PercentOf { get; set; }
        public string dm_RunningTotalLabel { get; set; }
        public Nullable<int> dm_RunningTotalPercentOf { get; set; }
        public Nullable<bool> dm_ShowRunningTotal { get; set; }
        public Nullable<bool> dm_ShowTotal { get; set; }
        public Nullable<decimal> dm_SortOrder { get; set; }
        public Nullable<int> dm_Type { get; set; }
        public Nullable<bool> dm_TypicalBalance { get; set; }
        public Nullable<System.Guid> dm_PercentofAccount { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofAccount { get; set; }
        public Nullable<System.Guid> dm_PercentofSubtype { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofSubtype { get; set; }
        public Nullable<System.Guid> dm_PercentOfType { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofType { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofGroup { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofSubgroup { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}
