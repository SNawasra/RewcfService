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
    
    public partial class Labor
    {
        public string Batch { get; set; }
        public Nullable<System.DateTime> DateWorked { get; set; }
        public string EmployeePOSId { get; set; }
        public string JobCodePOSId { get; set; }
        public string EmployeeJobTitle { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<decimal> Hours { get; set; }
        public Nullable<decimal> PayRate { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Labor1 { get; set; }
        public string PayCode { get; set; }
        public string PayrollStatus { get; set; }
        public string DailySalesSummary { get; set; }
        public int Id { get; set; }
    }
}
