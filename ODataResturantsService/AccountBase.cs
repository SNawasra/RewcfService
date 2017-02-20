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
    
    public partial class AccountBase
    {
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
        public string YomiName { get; set; }
        public Nullable<System.Guid> OwnerId { get; set; }
        public Nullable<System.Guid> ModifiedOnBehalfBy { get; set; }
        public Nullable<System.Guid> CreatedOnBehalfBy { get; set; }
        public Nullable<int> OwnerIdType { get; set; }
    }
}
