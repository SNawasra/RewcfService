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
    
    public partial class dm_jobTitle
    {
        public System.Guid dm_jobtitleId { get; set; }
        public string dm_JobTitle1 { get; set; }
        public string dm_Description { get; set; }
        public string dm_JobCode { get; set; }
        public Nullable<int> dm_JobType { get; set; }
        public Nullable<decimal> dm_payrate { get; set; }
        public Nullable<decimal> dm_payrate_Base { get; set; }
        public string dm_POSID { get; set; }
        public Nullable<System.Guid> dm_GLAccount { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<int> Rating { get; set; }
        public string color { get; set; }
        public Nullable<bool> ExcludeFromSchedule { get; set; }
        public Nullable<bool> ExcludeFromPOSImport { get; set; }
    }
}
