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
    
    public partial class dm_bankReconciliationextensionbase
    {
        public System.Guid dm_bankreconciliationId { get; set; }
        public string dm_name { get; set; }
        public Nullable<int> dm_ApprovalStatus { get; set; }
        public Nullable<System.DateTime> dm_ApprovedOn { get; set; }
        public Nullable<decimal> dm_BeginningBalance { get; set; }
        public Nullable<decimal> dm_beginningbalance_Base { get; set; }
        public Nullable<bool> dm_BrandNew { get; set; }
        public Nullable<decimal> dm_ChecksandExpenses { get; set; }
        public Nullable<decimal> dm_checksandexpenses_Base { get; set; }
        public Nullable<decimal> dm_ClearedBalance { get; set; }
        public Nullable<decimal> dm_clearedbalance_Base { get; set; }
        public string dm_Comment { get; set; }
        public Nullable<System.DateTime> dm_DateApproved { get; set; }
        public Nullable<decimal> dm_DepositsandCredits { get; set; }
        public Nullable<decimal> dm_depositsandcredits_Base { get; set; }
        public Nullable<decimal> dm_Difference { get; set; }
        public Nullable<decimal> dm_difference_Base { get; set; }
        public Nullable<decimal> dm_StatementEndBalance { get; set; }
        public Nullable<decimal> dm_statementendbalance_Base { get; set; }
        public Nullable<System.DateTime> dm_StatementEndDate { get; set; }
        public Nullable<System.Guid> dm_Attribute1 { get; set; }
        public Nullable<System.Guid> dm_Attribute2 { get; set; }
        public Nullable<System.Guid> dm_CheckingAccount { get; set; }
        public Nullable<System.Guid> dm_LegalEntity { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<System.Guid> dm_ApprovedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}