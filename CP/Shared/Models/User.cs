namespace CP.Shared.Models;
public class User : BaseUser
{

    public bool IsAdmin { get; set; }
    public bool IsActive { get; set; } = true;

    public Role Role { get; set; }

}


public enum Role
{
    Admin = 1,
    Representative = 2,
    Reviewer = 3,
}