using Arishma.Outreach.Application;
namespace Arishma.Outreach.Infrastructure;
public class EfCampaignRepository : ICampaignRepository
{
    private readonly AppDbContext _db;
    public EfCampaignRepository(AppDbContext db) => _db = db;
    // Phase 0: scaffold returns no rows and never requires a live DB for /health.
    // Phase 1: replace with a real query over _db.Campaigns.
    public Task<IReadOnlyList<CampaignDto>> ListAsync(CancellationToken ct = default)
        => Task.FromResult<IReadOnlyList<CampaignDto>>(Array.Empty<CampaignDto>());
}
