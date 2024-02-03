namespace CP.Shared;
public class Customer : BaseUser
{
    public CustomerType CustomerType { get; set; }


}

public enum CustomerType
{
    Customer = 1,
    Vendor = 2
}
