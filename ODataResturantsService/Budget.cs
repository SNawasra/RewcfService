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
    
    public partial class Budget
    {
        public System.Guid BudgetID { get; set; }
        public string Name { get; set; }
        public Nullable<int> BudgetYear { get; set; }
        public Nullable<int> CalendarType { get; set; }
        public Nullable<int> BudgetBy { get; set; }
        public Nullable<bool> ReportingBudget { get; set; }
        public Nullable<bool> AccountType { get; set; }
        public Nullable<System.Guid> DefaultLocation { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
    }
}
