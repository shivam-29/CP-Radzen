using System.ComponentModel.DataAnnotations;

namespace CP.Shared;
public class Work
{
    [Key]

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public RequestType RequestType { get; set; }

    public RequestType ChangeType { get; set; }

    public string RepresentativeName { get; set; }=string.Empty;


    public string ReviewerName { get; set; } = string.Empty;

    public Status Status { get; set; }

    public DateTime? Created { get; set; } = DateTime.Now;

    public string RequestedBy { get; set; } = string.Empty;



}

public enum RequestType
{
    New=1,
    Old=2
}

public enum Status
{
    Open = 1,
    InProgress= 2,
    Closed = 3,
    Cancelled =4
}

