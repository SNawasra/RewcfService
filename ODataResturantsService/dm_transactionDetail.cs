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
    
    public partial class dm_transactionDetail
    {
        public System.Guid dm_transactiondetailId { get; set; }
        public string dm_name { get; set; }
        public string dm_AccountingSystemID { get; set; }
        public Nullable<decimal> dm_Adjustment { get; set; }
        public Nullable<decimal> dm_adjustment_Base { get; set; }
        public Nullable<int> dm_BudgetAs { get; set; }
        public string dm_BudgetFiscalPeriodYear { get; set; }
        public Nullable<decimal> dm_BudgetonPercent { get; set; }
        public string dm_Comment { get; set; }
        public Nullable<decimal> dm_Credit { get; set; }
        public Nullable<decimal> dm_credit_Base { get; set; }
        public Nullable<System.DateTime> dm_DateReference { get; set; }
        public Nullable<decimal> dm_Debit { get; set; }
        public Nullable<decimal> dm_debit_Base { get; set; }
        public Nullable<System.DateTime> dm_DeliveryDate { get; set; }
        public Nullable<decimal> dm_DetailSort { get; set; }
        public Nullable<int> dm_DetailType { get; set; }
        public Nullable<decimal> dm_EachAmount { get; set; }
        public Nullable<decimal> dm_eachamount_Base { get; set; }
        public Nullable<bool> dm_Exclude { get; set; }
        public Nullable<bool> dm_Intercompany { get; set; }
        public Nullable<bool> dm_MissingReceipt { get; set; }
        public Nullable<bool> dm_Offset { get; set; }
        public Nullable<decimal> dm_PreviousCountTotal { get; set; }
        public Nullable<decimal> dm_previouscounttotal_Base { get; set; }
        public Nullable<decimal> dm_Quantity { get; set; }
        public Nullable<int> dm_R365Category { get; set; }
        public Nullable<bool> dm_Reconciled { get; set; }
        public string dm_StorageLocation { get; set; }
        public Nullable<decimal> dm_StorageLocationSort { get; set; }
        public Nullable<bool> dm_Taxable { get; set; }
        public Nullable<decimal> dm_Total { get; set; }
        public Nullable<decimal> dm_total_Base { get; set; }
        public string dm_UofM { get; set; }
        public string dm_VendorItemNumber { get; set; }
        public Nullable<System.Guid> dm_Company { get; set; }
        public Nullable<System.Guid> dm_Attribute1 { get; set; }
        public Nullable<System.Guid> dm_IntercompanyCreditAttribute1 { get; set; }
        public Nullable<System.Guid> dm_IntercompanyDebitAttribute1 { get; set; }
        public Nullable<System.Guid> dm_TransactionAttribute1 { get; set; }
        public Nullable<System.Guid> dm_Attribute2 { get; set; }
        public Nullable<System.Guid> dm_IntercompanyCreditAttribute2 { get; set; }
        public Nullable<System.Guid> dm_IntercompanyDebitAttribute2 { get; set; }
        public Nullable<System.Guid> dm_TransactionAttribute2 { get; set; }
        public Nullable<System.Guid> dm_ReconciledtoActivity { get; set; }
        public Nullable<System.Guid> dm_BankReconciliation { get; set; }
        public Nullable<System.Guid> dm_BudgetonAccount { get; set; }
        public Nullable<System.Guid> dm_GLAccount { get; set; }
        public Nullable<System.Guid> dm_IntercompanyCreditAccount { get; set; }
        public Nullable<System.Guid> dm_IntercompanyDebitAccount { get; set; }
        public Nullable<System.Guid> dm_OffsetAccount { get; set; }
        public Nullable<System.Guid> dm_BudgetonSubtype { get; set; }
        public Nullable<System.Guid> dm_Item { get; set; }
        public Nullable<System.Guid> dm_R365Job { get; set; }
        public Nullable<System.Guid> dm_IntercompanyCreditLegalEntity { get; set; }
        public Nullable<System.Guid> dm_IntercompanyDebitLegalEntity { get; set; }
        public Nullable<System.Guid> dm_LegalEntity { get; set; }
        public Nullable<System.Guid> dm_TransactionLegalEntity { get; set; }
        public Nullable<System.Guid> dm_IntercompanyCreditLocation { get; set; }
        public Nullable<System.Guid> dm_IntercompanyDebitLocation { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<System.Guid> dm_TransactionLocation { get; set; }
        public Nullable<System.Guid> dm_R365PaymentTypeAccount { get; set; }
        public Nullable<System.Guid> dm_R365SalesAccount { get; set; }
        public Nullable<System.Guid> dm_R365SalesPayment { get; set; }
        public Nullable<System.Guid> dm_Deposit { get; set; }
        public Nullable<System.Guid> dm_Invoice { get; set; }
        public Nullable<System.Guid> dm_Transaction { get; set; }
        public Nullable<System.Guid> dm_TransactionApply { get; set; }
        public Nullable<System.Guid> dm_IntercompanyLink { get; set; }
        public Nullable<System.Guid> dm_UndepositedFundDetail { get; set; }
        public Nullable<System.Guid> dm_unitofmeasure { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<decimal> FulfillQuantity { get; set; }
        public Nullable<decimal> BudgetPercent { get; set; }
        public Nullable<int> BudgetAs { get; set; }
        public Nullable<int> PercentBasedOn { get; set; }
        public Nullable<System.Guid> dm_BudgetPercentOfType { get; set; }
        public Nullable<System.Guid> dm_BudgetPercentOfAccount { get; set; }
        public Nullable<int> dm_BudgetPercentOfCategories { get; set; }
        public Nullable<System.Guid> CountUOfM1 { get; set; }
        public Nullable<System.Guid> CountUOfM2 { get; set; }
        public Nullable<System.Guid> CountUOfM3 { get; set; }
        public Nullable<decimal> CountQty1 { get; set; }
        public Nullable<decimal> CountQty2 { get; set; }
        public Nullable<decimal> CountQty3 { get; set; }
    }
}
