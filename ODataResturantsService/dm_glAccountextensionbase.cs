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
    
    public partial class dm_glAccountextensionbase
    {
        public System.Guid dm_glaccountId { get; set; }
        public string dm_name { get; set; }
        public string dm_AccountNumber { get; set; }
        public Nullable<bool> dm_AvailabletoManagers { get; set; }
        public Nullable<decimal> dm_Balance { get; set; }
        public Nullable<decimal> dm_balance_Base { get; set; }
        public Nullable<bool> dm_BankAccount { get; set; }
        public string dm_BankAccountNumber { get; set; }
        public string dm_BankNameoncheck { get; set; }
        public string dm_BankUserName { get; set; }
        public Nullable<int> dm_BudgetAs { get; set; }
        public Nullable<decimal> dm_BudgetDefault { get; set; }
        public Nullable<int> dm_CashFlowCategory { get; set; }
        public string dm_Description { get; set; }
        public Nullable<bool> dm_DisableEntry { get; set; }
        public Nullable<System.DateTime> dm_LastActivityEnd { get; set; }
        public Nullable<decimal> dm_LastReconciledBalance { get; set; }
        public Nullable<decimal> dm_lastreconciledbalance_Base { get; set; }
        public Nullable<System.DateTime> dm_LastReconciledDate { get; set; }
        public string dm_NextCheckNumber { get; set; }
        public Nullable<int> dm_OperationalReportCategory { get; set; }
        public Nullable<int> dm_PercentOf { get; set; }
        public Nullable<bool> dm_RetainedEarnings { get; set; }
        public string dm_RoutingNumber { get; set; }
        public string dm_RunningTotalLabel { get; set; }
        public Nullable<bool> dm_ShowRunningTotal { get; set; }
        public Nullable<int> dm_SpecialCategory { get; set; }
        public Nullable<System.Guid> dm_BankCompany { get; set; }
        public Nullable<System.Guid> dm_BudgetonAccount { get; set; }
        public Nullable<System.Guid> dm_ParentAccount { get; set; }
        public Nullable<System.Guid> dm_PercentofAccount { get; set; }
        public Nullable<System.Guid> dm_BudgetonSubtype { get; set; }
        public Nullable<System.Guid> dm_PercentofSubtype { get; set; }
        public Nullable<System.Guid> dm_Subtype { get; set; }
        public Nullable<System.Guid> dm_AccountType { get; set; }
        public Nullable<System.Guid> dm_PercentofType { get; set; }
        public Nullable<System.Guid> dm_LegalEntity { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<int> dm_RunningTotalPercentOf { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofAccount { get; set; }
        public Nullable<System.Guid> dm_RunningTotalPercentofType { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<bool> dm_DepositOnly { get; set; }
        public Nullable<bool> secondSignature { get; set; }
        public Nullable<decimal> secondSignatureThreshold { get; set; }
        public string CheckFormat { get; set; }
        public Nullable<int> dm_BudgetPercentBasedOn { get; set; }
        public Nullable<System.Guid> dm_BudgetPercentOfType { get; set; }
        public Nullable<decimal> dm_BudgetAmount { get; set; }
        public Nullable<System.Guid> dm_BudgetPercentOfAccount { get; set; }
        public Nullable<int> dm_BudgetPercentOfCategories { get; set; }
        public Nullable<System.DateTime> LastActivityUpload { get; set; }
    }
}