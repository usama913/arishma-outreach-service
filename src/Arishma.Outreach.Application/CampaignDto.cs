namespace Arishma.Outreach.Application;
public record CampaignDto(Guid Id, string Name);
public record ServiceInfoDto(string Service, string Subdomain, string Status, string DatabaseProvider);
