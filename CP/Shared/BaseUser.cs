using System.ComponentModel.DataAnnotations;

namespace CP.Shared;
public class BaseUser :Address
{
    [Key]
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;


}
