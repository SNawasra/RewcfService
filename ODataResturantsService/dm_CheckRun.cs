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
    
    public partial class dm_CheckRun
    {
        public System.Guid checkRunId { get; set; }
        public string checkingAccountId { get; set; }
        public string checkRunName { get; set; }
        public string checkNumber { get; set; }
        public string userId { get; set; }
        public string legalEntity { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string locationId { get; set; }
    }
}
