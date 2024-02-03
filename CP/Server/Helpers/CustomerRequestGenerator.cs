using Bogus;
using CP.Shared.Models;

namespace CP.Server.Helpers;

public static class CustomerRequestGenerator
{
    public static List<CustomerRequestModel> Generate(Faker faker)
    {
        var testUsers = new Faker<CustomerRequestModel>()
           .RuleFor(u => u.MDMId, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.GUID, f => Guid.NewGuid().ToString())
           .RuleFor(u => u.Action, f => "View")
           .RuleFor(u => u.Title, f => f.Lorem.Sentence())
           .RuleFor(u => u.RequestType, f => f.Random.Word())
           .RuleFor(u => u.ChangeType, f => f.Random.Word())
           .RuleFor(u => u.FEID, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.OracleSoldTo, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.OracleSiteId, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.MSABranchCode, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.ActualAmountRequested, f => f.Random.Decimal(0, 10000))
           .RuleFor(u => u.AfterMarketSalesOrder, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.SameDayDelivery, f => f.Random.Bool())
           .RuleFor(u => u.KrackCIA, f => f.Random.Bool())
           .RuleFor(u => u.PaymentTerm, f => f.Random.Word())
           .RuleFor(u => u.Category, f => f.Random.Word())
           .RuleFor(u => u.CustomerClass, f => f.Random.Word())
           .RuleFor(u => u.TaxStatus, f => f.Random.Word())
           .RuleFor(u => u.TaxCalculation, f => f.Random.Word())
           .RuleFor(u => u.Comments, f => f.Lorem.Paragraph())
           .RuleFor(u => u.BillToCustomerName, f => f.Name.FullName())
           .RuleFor(u => u.BillToAddressLine1, f => f.Address.StreetAddress())
           .RuleFor(u => u.BillToAddressLine2, f => f.Address.SecondaryAddress())
           .RuleFor(u => u.BillToAddressLine3, f => f.Address.BuildingNumber())
           .RuleFor(u => u.BillToCity, f => f.Address.City())
           .RuleFor(u => u.BillToCounty, f => f.Address.County())
           .RuleFor(u => u.BillToState, f => f.Address.State())
           .RuleFor(u => u.BillToZip, f => f.Address.ZipCode())
           .RuleFor(u => u.BillToProvince, f => f.Address.State())
           .RuleFor(u => u.BillToCountry, f => f.Address.Country())
           .RuleFor(u => u.BillToContactName, f => f.Name.FullName())
           .RuleFor(u => u.BillToEmail, f => f.Internet.Email())
           .RuleFor(u => u.BillToPhoneNumber, f => f.Phone.PhoneNumber())
           .RuleFor(u => u.InvoiceDeliveryEmail, f => f.Internet.Email())
           .RuleFor(u => u.TaxCode, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.InvoiceCommunication, f => f.Random.Word())
           .RuleFor(u => u.InvoiceTemplate, f => f.Random.Word())
           .RuleFor(u => u.CreditRepresentative, f => f.Name.FullName())
           .RuleFor(u => u.InvoiceDeliveryMethods, f => f.Random.Word())
           .RuleFor(u => u.MajMinBranches, f => f.Random.Word())
           .RuleFor(u => u.NotifyTo, f => f.Internet.Email())
           .RuleFor(u => u.BSSNo, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.BSSShortName, f => f.Random.Word())
           .RuleFor(u => u.OracleCustNo, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.OracleBillToSite, f => f.Random.AlphaNumeric(10))
           .RuleFor(u => u.CustomerType, f => f.Random.Word())
           .RuleFor(u => u.AssigningOrganization, f => f.Company.CompanyName())
           .RuleFor(u => u.Tolerance, f => f.Random.Word())
           .RuleFor(u => u.Currency, f => f.Finance.Currency().Code)
           .RuleFor(u => u.OrderLimit, f => f.Random.Word())
           .RuleFor(u => u.Company, f => f.Company.CompanyName())
           .RuleFor(u => u.CrossReferenceType, f => f.Random.Word())
           .RuleFor(u => u.CustomerSiteType, f => f.Random.Word())
           .RuleFor(u => u.CreatedBy, f => f.Name.FullName())
           .RuleFor(u => u.CreatedOn, f => f.Date.Past())
           .RuleFor(u => u.ModifiedBy, f => f.Name.FullName())
           .RuleFor(u => u.ModifiedOn, f => f.Date.Recent())
           .RuleFor(u => u.ReviewedBy, f => f.Name.FullName())
           .RuleFor(u => u.ReviewAction, f => f.Random.Word())
           .RuleFor(u => u.Status, f => f.Random.Word())
           .RuleFor(u => u.Systems, f => f.Random.Word())
           .RuleFor(u => u.SubmittedToWF, f => f.Random.Bool())
           .RuleFor(u => u.AddressTypeCode, f => f.Random.Word())
           .RuleFor(u => u.DataSource, f => f.Random.Word())
           .RuleFor(u => u.PublishORAStatus, f => f.Random.Int(0, 1))
           .RuleFor(u => u.PublishCEStatus, f => f.Random.Int(0, 1))
           .RuleFor(u => u.PublishBSSStatus, f => f.Random.Int(0, 1))
           .RuleFor(u => u.StoreMainOffice, f => f.Random.Int(0, 1))
           .RuleFor(u => u.SpecialInstructions, f => f.Lorem.Sentence())
           .RuleFor(u => u.ModemNumber, f => f.Random.Int(0, 100))
           .RuleFor(u => u.ServiceCenter, f => f.Random.Int(0, 100))
           .RuleFor(u => u.ServicePriority, f => f.Random.Int(1, 5))
           .RuleFor(u => u.ServiceRespTime, f => f.Random.Int(1, 5))
           .RuleFor(u => u.TelephoneRespTime, f => f.Random.Int(1, 5))
           .Generate(100);

        return testUsers;

    }

}



