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
    
    public partial class CateringEventDetail
    {
        public System.Guid CateringEventDetailID { get; set; }
        public Nullable<System.Guid> Item { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.Guid> UofM { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> EachAmount { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<System.Guid> Category { get; set; }
        public string Menu { get; set; }
        public Nullable<System.Guid> Segment { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> CateringEvent { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
