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
    
    public partial class Sale
    {
        public string Batch { get; set; }
        public string SalesId { get; set; }
        public string checknumber { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> NumberofGuests { get; set; }
        public Nullable<decimal> SalesAmount { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> TipAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> TotalPayment { get; set; }
        public Nullable<decimal> totalpayment_Base { get; set; }
        public Nullable<bool> Void { get; set; }
        public string Server { get; set; }
        public string ServiceType { get; set; }
        public string DateText { get; set; }
        public string Comment { get; set; }
        public int Id { get; set; }
    }
}