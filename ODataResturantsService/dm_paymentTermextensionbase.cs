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
    
    public partial class dm_paymentTermextensionbase
    {
        public System.Guid dm_paymenttermId { get; set; }
        public string dm_name { get; set; }
        public Nullable<int> dm_DaysDue { get; set; }
        public Nullable<decimal> dm_Discount { get; set; }
        public Nullable<int> dm_DiscountDays { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<int> TermType { get; set; }
    }
}
