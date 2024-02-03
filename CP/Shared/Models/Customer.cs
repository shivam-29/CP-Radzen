namespace CP.Shared.Models;
public class Customer : BaseUser
{
    public CustomerType CustomerType { get; set; }


}

public enum CustomerType
{
    Customer = 1,
    Vendor = 2
}
