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
    
    public partial class dm_itemLocation
    {
        public System.Guid dm_itemlocationId { get; set; }
        public string dm_name { get; set; }
        public Nullable<decimal> dm_BaseUofMCost { get; set; }
        public Nullable<decimal> dm_Cost { get; set; }
        public Nullable<decimal> dm_cost_Base { get; set; }
        public Nullable<decimal> dm_ParQty { get; set; }
        public Nullable<System.Guid> dm_Item { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<System.Guid> dm_BaseUofM { get; set; }
        public Nullable<System.Guid> dm_InventoryUofM { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}