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
    
    public partial class dm_transactionApplyextensionbase
    {
        public System.Guid dm_transactionapplyId { get; set; }
        public string dm_name { get; set; }
        public Nullable<bool> dm_Applied { get; set; }
        public Nullable<decimal> dm_ApplyAmount { get; set; }
        public Nullable<decimal> dm_applyamount_Base { get; set; }
        public Nullable<System.DateTime> dm_ApplyDate { get; set; }
        public string dm_CheckRun { get; set; }
        public Nullable<bool> dm_delete { get; set; }
        public Nullable<decimal> dm_DiscountAmount { get; set; }
        public Nullable<decimal> dm_discountamount_Base { get; set; }
        public Nullable<bool> dm_DiscountApplied { get; set; }
        public Nullable<decimal> dm_SourceAmount { get; set; }
        public Nullable<decimal> dm_sourceamount_Base { get; set; }
        public Nullable<System.Guid> dm_DiscountAccount { get; set; }
        public Nullable<System.Guid> dm_ApplyTo { get; set; }
        public Nullable<System.Guid> dm_ApplyTransaction { get; set; }
        public Nullable<System.Guid> dm_SourceTransaction { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}
