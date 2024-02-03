using System.ComponentModel.DataAnnotations;

namespace CP.Shared;
public class CustomerRequestModel 
{
    public string MDMId { get; set; }
    [Key]
    public string GUID { get; set; }
    public string Action { get; set; } = "View";
    public string Title { get; set; }
    public string RequestType { get; set; }
    public string ChangeType { get; set; }
    public string FEID { get; set; }
    public string OracleSoldTo { get; set; }
    public string OracleSiteId { get; set; }
    public string MSABranchCode { get; set; }
    public decimal ActualAmountRequested { get; set; }
    public string AfterMarketSalesOrder { get; set; }
    public bool SameDayDelivery { get; set; }
    public bool KrackCIA { get; set; }
    public string PaymentTerm { get; set; }
    public string Category { get; set; }
    public string CustomerClass { get; set; }
    public string TaxStatus { get; set; }
    public string TaxCalculation { get; set; }
    public string Comments { get; set; }
    public string BillToCustomerName { get; set; }
    public string BillToAddressLine1 { get; set; }
    public string BillToAddressLine2 { get; set; }
    public string BillToAddressLine3 { get; set; }
    public string BillToCity { get; set; }
    public string BillToCounty { get; set; }
    public string BillToState { get; set; }
    public string BillToZip { get; set; }
    public string BillToProvince { get; set; }
    public string BillToCountry { get; set; }
    public string BillToContactName { get; set; }
    public string BillToEmail { get; set; }
    public string BillToPhoneNumber { get; set; }
    public string InvoiceDeliveryEmail { get; set; }
    public string TaxCode { get; set; }
    public string InvoiceCommunication { get; set; }
    public string InvoiceTemplate { get; set; }
    public string CreditRepresentative { get; set; }
    public string InvoiceDeliveryMethods { get; set; }
    public string MajMinBranches { get; set; }
    public string NotifyTo { get; set; }
    public string BSSNo { get; set; }
    public string BSSShortName { get; set; }
    public string OracleCustNo { get; set; }
    public string OracleBillToSite { get; set; }
    public string CustomerType { get; set; }
    public string AssigningOrganization { get; set; }
    public string Tolerance { get; set; }
    public string Currency { get; set; }
    public string OrderLimit { get; set; }
    public string Company { get; set; }
    public string CrossReferenceType { get; set; }
    public string CustomerSiteType { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ReviewedBy { get; set; }
    public string ReviewAction { get; set; }
    public string Status { get; set; }
    public string Systems { get; set; }
    public bool SubmittedToWF { get; set; }
    public string AddressTypeCode { get; set; }
    public string DataSource { get; set; }
    public int PublishORAStatus { get; set; }
    public int PublishCEStatus { get; set; }
    public int PublishBSSStatus { get; set; }
    public int StoreMainOffice { get; set; }
    public string SpecialInstructions { get; set; }
    public int ModemNumber { get; set; }
    public int ServiceCenter { get; set; }
    public int ServicePriority { get; set; } = 1;
    public int ServiceRespTime { get; set; } = 1;
    public int TelephoneRespTime { get; set; } = 1;
   
  
}
