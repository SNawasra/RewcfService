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
    
    public partial class Account
    {
        public string PrimaryContactIdName { get; set; }
        public string dm_TermsDiscountAccountName { get; set; }
        public string dm_FranchiseeName { get; set; }
        public string dm_TemplateName { get; set; }
        public string MasterAccountIdName { get; set; }
        public string ModifiedByName { get; set; }
        public string ParentAccountIdName { get; set; }
        public string CreatedByName { get; set; }
        public string dm_LocationName { get; set; }
        public string PreferredSystemUserIdName { get; set; }
        public string dm_DefaultExpenseAccountName { get; set; }
        public string dm_PaymentTermsName { get; set; }
        public Nullable<int> Address1_AddressTypeCode { get; set; }
        public string Address1_City { get; set; }
        public string Address1_Country { get; set; }
        public string Address1_County { get; set; }
        public Nullable<System.Guid> Address1_AddressId { get; set; }
        public string Address1_Fax { get; set; }
        public Nullable<int> Address1_FreightTermsCode { get; set; }
        public Nullable<decimal> Address1_Latitude { get; set; }
        public string Address1_Line1 { get; set; }
        public string Address1_Line2 { get; set; }
        public string Address1_Line3 { get; set; }
        public Nullable<decimal> Address1_Longitude { get; set; }
        public string Address1_Name { get; set; }
        public string Address1_PostalCode { get; set; }
        public string Address1_PostOfficeBox { get; set; }
        public string Address1_PrimaryContactName { get; set; }
        public Nullable<int> Address1_ShippingMethodCode { get; set; }
        public string Address1_StateOrProvince { get; set; }
        public string Address1_Telephone1 { get; set; }
        public string Address1_Telephone2 { get; set; }
        public string Address1_Telephone3 { get; set; }
        public string Address1_UPSZone { get; set; }
        public Nullable<int> Address1_UTCOffset { get; set; }
        public Nullable<int> Address2_AddressTypeCode { get; set; }
        public string Address2_City { get; set; }
        public string Address2_Country { get; set; }
        public string Address2_County { get; set; }
        public Nullable<System.Guid> Address2_AddressId { get; set; }
        public string Address2_Fax { get; set; }
        public Nullable<int> Address2_FreightTermsCode { get; set; }
        public Nullable<decimal> Address2_Latitude { get; set; }
        public string Address2_Line1 { get; set; }
        public string Address2_Line2 { get; set; }
        public string Address2_Line3 { get; set; }
        public Nullable<decimal> Address2_Longitude { get; set; }
        public string Address2_Name { get; set; }
        public string Address2_PostalCode { get; set; }
        public string Address2_PostOfficeBox { get; set; }
        public string Address2_PrimaryContactName { get; set; }
        public Nullable<int> Address2_ShippingMethodCode { get; set; }
        public string Address2_StateOrProvince { get; set; }
        public string Address2_Telephone1 { get; set; }
        public string Address2_Telephone2 { get; set; }
        public string Address2_Telephone3 { get; set; }
        public string Address2_UPSZone { get; set; }
        public Nullable<int> Address2_UTCOffset { get; set; }
        public System.Guid AccountId { get; set; }
        public Nullable<int> AccountCategoryCode { get; set; }
        public Nullable<System.Guid> TerritoryId { get; set; }
        public Nullable<System.Guid> DefaultPriceLevelId { get; set; }
        public Nullable<int> CustomerSizeCode { get; set; }
        public Nullable<int> PreferredContactMethodCode { get; set; }
        public Nullable<int> CustomerTypeCode { get; set; }
        public Nullable<int> AccountRatingCode { get; set; }
        public Nullable<int> IndustryCode { get; set; }
        public Nullable<int> TerritoryCode { get; set; }
        public Nullable<int> AccountClassificationCode { get; set; }
        public Nullable<int> BusinessTypeCode { get; set; }
        public Nullable<System.Guid> OwningBusinessUnit { get; set; }
        public Nullable<System.Guid> OriginatingLeadId { get; set; }
        public Nullable<int> PaymentTermsCode { get; set; }
        public Nullable<int> ShippingMethodCode { get; set; }
        public Nullable<System.Guid> PrimaryContactId { get; set; }
        public Nullable<bool> ParticipatesInWorkflow { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<decimal> Revenue { get; set; }
        public Nullable<int> NumberOfEmployees { get; set; }
        public string Description { get; set; }
        public string SIC { get; set; }
        public Nullable<int> OwnershipCode { get; set; }
        public Nullable<decimal> MarketCap { get; set; }
        public Nullable<int> SharesOutstanding { get; set; }
        public string TickerSymbol { get; set; }
        public string StockExchange { get; set; }
        public string WebSiteURL { get; set; }
        public string FtpSiteURL { get; set; }
        public string EMailAddress1 { get; set; }
        public string EMailAddress2 { get; set; }
        public string EMailAddress3 { get; set; }
        public Nullable<bool> DoNotPhone { get; set; }
        public Nullable<bool> DoNotFax { get; set; }
        public string Telephone1 { get; set; }
        public Nullable<bool> DoNotEMail { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string Telephone3 { get; set; }
        public Nullable<bool> DoNotPostalMail { get; set; }
        public Nullable<bool> DoNotBulkEMail { get; set; }
        public Nullable<bool> DoNotBulkPostalMail { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public Nullable<bool> CreditOnHold { get; set; }
        public Nullable<bool> IsPrivate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public byte[] VersionNumber { get; set; }
        public Nullable<System.Guid> ParentAccountId { get; set; }
        public Nullable<decimal> Aging30 { get; set; }
        public Nullable<int> StateCode { get; set; }
        public Nullable<decimal> Aging60 { get; set; }
        public Nullable<int> StatusCode { get; set; }
        public Nullable<decimal> Aging90 { get; set; }
        public Nullable<int> PreferredAppointmentDayCode { get; set; }
        public Nullable<System.Guid> PreferredSystemUserId { get; set; }
        public Nullable<int> PreferredAppointmentTimeCode { get; set; }
        public Nullable<bool> Merged { get; set; }
        public Nullable<bool> DoNotSendMM { get; set; }
        public Nullable<System.Guid> MasterId { get; set; }
        public Nullable<System.DateTime> LastUsedInCampaign { get; set; }
        public Nullable<System.Guid> PreferredServiceId { get; set; }
        public Nullable<System.Guid> PreferredEquipmentId { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<int> UTCConversionTimeZoneCode { get; set; }
        public Nullable<System.DateTime> OverriddenCreatedOn { get; set; }
        public Nullable<int> TimeZoneRuleVersionNumber { get; set; }
        public Nullable<int> ImportSequenceNumber { get; set; }
        public Nullable<System.Guid> TransactionCurrencyId { get; set; }
        public Nullable<decimal> CreditLimit_Base { get; set; }
        public Nullable<decimal> Aging30_Base { get; set; }
        public Nullable<decimal> Revenue_Base { get; set; }
        public Nullable<decimal> Aging90_Base { get; set; }
        public Nullable<decimal> MarketCap_Base { get; set; }
        public Nullable<decimal> Aging60_Base { get; set; }
        public Nullable<System.Guid> CreatedOnBehalfBy { get; set; }
        public Nullable<System.Guid> ModifiedOnBehalfBy { get; set; }
        public Nullable<bool> dm_1099Vendor { get; set; }
        public Nullable<bool> dm_AvailableAllLocations { get; set; }
        public Nullable<decimal> dm_Balance { get; set; }
        public Nullable<decimal> dm_balance_Base { get; set; }
        public string dm_CheckName { get; set; }
        public string dm_IDinAccountingSystem { get; set; }
        public string dm_Number { get; set; }
        public Nullable<bool> dm_ShortPay { get; set; }
        public Nullable<bool> dm_Taxable { get; set; }
        public string dm_TaxID { get; set; }
        public Nullable<int> dm_Type { get; set; }
        public Nullable<System.Guid> dm_Template { get; set; }
        public Nullable<System.Guid> dm_Location { get; set; }
        public Nullable<System.Guid> dm_PaymentTerms { get; set; }
        public Nullable<decimal> dm_DiscountPercent { get; set; }
        public Nullable<System.Guid> dm_DefaultExpenseAccount { get; set; }
        public Nullable<System.Guid> dm_TermsDiscountAccount { get; set; }
        public string dm_DefaultCheckMemo { get; set; }
        public Nullable<int> dm_1099Box { get; set; }
        public Nullable<int> dm_Entry { get; set; }
        public Nullable<int> dm_PaymentMethod { get; set; }
        public string dm_RoutingNumber { get; set; }
        public string dm_BankAccountNumber { get; set; }
        public Nullable<int> dm_BankAccountType { get; set; }
        public Nullable<bool> dm_FranchiseeLocation { get; set; }
        public Nullable<bool> dm_UseTax { get; set; }
        public Nullable<System.Guid> dm_Franchisee { get; set; }
        public Nullable<System.DateTime> dm_OpenDate { get; set; }
        public string dm_RadiusProtection { get; set; }
        public Nullable<System.DateTime> dm_ContractualOpenDate { get; set; }
        public Nullable<bool> dm_inactive { get; set; }
        public Nullable<System.Guid> CommissaryLocation { get; set; }
        public Nullable<bool> CommissaryCustomer { get; set; }
    }
}
