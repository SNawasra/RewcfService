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
    
    public partial class dm_franchisingFee
    {
        public System.Guid dm_franchisingfeeId { get; set; }
        public string dm_name { get; set; }
        public Nullable<decimal> dm_Amount { get; set; }
        public Nullable<int> dm_ChargeType { get; set; }
        public string dm_Description { get; set; }
        public Nullable<System.DateTime> dm_EndDate { get; set; }
        public Nullable<bool> dm_Recurring { get; set; }
        public Nullable<int> dm_SalesType { get; set; }
        public Nullable<System.DateTime> dm_StartDate { get; set; }
        public Nullable<System.Guid> dm_Store { get; set; }
        public Nullable<System.Guid> dm_Item { get; set; }
        public Nullable<System.Guid> dm_Invoice { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}