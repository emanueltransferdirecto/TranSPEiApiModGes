namespace TranSPEiApiModGes.Infrastructure.Presistence;

public interface IDispositionRepository
{
    Task<int?> GetCustomerIdFromDisposition(Guid userId);
}