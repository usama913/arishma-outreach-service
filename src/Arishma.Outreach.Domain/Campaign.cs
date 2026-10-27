namespace Arishma.Outreach.Domain;
public class Campaign
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Name { get; set; } = "";
    public string Channel { get; set; } = "Email";
    public string Status { get; set; } = "Draft";
}
