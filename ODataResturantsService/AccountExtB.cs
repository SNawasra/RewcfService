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
    
    public partial class AccountExtB
    {
        public System.Guid AccountId { get; set; }
        public Nullable<int> dm_1099Box { get; set; }
        public Nullable<bool> dm_1099Vendor { get; set; }
        public Nullable<bool> dm_AvailableAllLocations { get; set; }
        public Nullable<decimal> dm_Balance { get; set; }
        public Nullable<decimal> dm_balance_Base { get; set; }
        public string dm_BankAccountNumber { get; set; }
        public Nullable<int> dm_BankAccountType { get; set; }
        public string dm_BankRoutingNumber { get; set; }
        public string dm_CheckName { get; set; }
        public Nullable<System.DateTime> dm_ContractualOpenDate { get; set; }
        public string dm_DefaultCheckMemo { get; set; }
        public Nullable<decimal> dm_DiscountPercent { get; set; }
        public Nullable<int> dm_Entry { get; set; }
        public Nullable<bool> dm_FranchiseeLocation { get; set; }
        public string dm_IDinAccountingSystem { get; set; }
        public string dm_Number { get; set; }
        public Nullable<System.DateTime> dm_OpenDate { get; set; }
        public Nullable<int> dm_PaymentMethod { get; set; }
        public string dm_RadiusProtection { get; set; }
        public string dm_RoutingNumber { get; set; }
        public Nullable<bool> dm_ShortPay { get; set; }
        public Nullable<bool> dm_Taxable { get; set; }
        public string dm_TaxID { get; set; }
        public Nullable<int> dm_Type { get; set; }
        public Nullable<bool> dm_UseTax { get; set; }
        public Nullable<System.Guid> dm_Template { get; set; }
        public Nullable<System.Guid> dm_Franchisee { get; set; }
        public Nullable<System.Guid> dm_DefaultExpenseAccount { get; set; }
        public Nullable<System.Guid> dm_TermsDiscountAccount { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<System.Guid> dm_PaymentTerms { get; set; }
        public Nullable<bool> dm_inactive { get; set; }
        public Nullable<System.Guid> FranchiseeLocationLink { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> AvailableToManagers { get; set; }
        public Nullable<bool> CommissaryCustomer { get; set; }
        public Nullable<System.Guid> CommissaryLocation { get; set; }
        public string CustomersEmail { get; set; }
        public string CustomersPassword { get; set; }
        public Nullable<bool> ChangePassword { get; set; }
        public Nullable<bool> PortalAccess { get; set; }
        public Nullable<int> ItemsAvailableOnInvoice { get; set; }
        public Nullable<System.Guid> VendorGroup { get; set; }
    }
}