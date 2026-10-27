namespace Arishma.Outreach.Application;
public interface ICampaignRepository
{
    Task<IReadOnlyList<CampaignDto>> ListAsync(CancellationToken ct = default);
}
