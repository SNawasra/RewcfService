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
    
    public partial class dm_employeeJobTitleextensionbase
    {
        public System.Guid dm_employeejobtitleId { get; set; }
        public string dm_EmpJobTitle { get; set; }
        public Nullable<System.DateTime> dm_DateRcvdPosition { get; set; }
        public string dm_EmpJobPOS { get; set; }
        public Nullable<decimal> dm_PayRate { get; set; }
        public Nullable<decimal> dm_payrate_Base { get; set; }
        public Nullable<System.Guid> dm_Employee { get; set; }
        public Nullable<System.Guid> dm_JobTitle { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<int> Rating { get; set; }
    }
}