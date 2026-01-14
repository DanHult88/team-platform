namespace server.Models;

public class ProjectMember
{
    public Guid UserId { get; set; }
    public Guid ProjectId { get; set; }
    public string Role { get; set; } = "Member";
}
