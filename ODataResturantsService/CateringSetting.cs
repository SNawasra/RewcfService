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
    
    public partial class CateringSetting
    {
        public System.Guid CateringSettingsID { get; set; }
        public Nullable<int> ContractSubtotalBy { get; set; }
        public Nullable<decimal> FoodCommission { get; set; }
        public Nullable<decimal> BeverageCommission { get; set; }
        public Nullable<decimal> LiquorCommission { get; set; }
        public Nullable<decimal> EquipmentCommission { get; set; }
        public Nullable<decimal> LaborCommission { get; set; }
        public Nullable<decimal> VenueCommission { get; set; }
        public Nullable<decimal> DeliveryCommission { get; set; }
        public Nullable<decimal> OtherCommission { get; set; }
        public string Terms { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}
