using Base.Domain;

namespace App.Domain;

public class GroupMember : BaseEntity
{
    public Guid GroupId { get; set; }
    public Group? Group { get; set; }
    
    public Guid PersonId { get; set; }
    public Person? Person { get; set; }
    
    public bool IsAdmin { get; set; }
}