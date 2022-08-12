using SavePassword.API.Application.DTO.InputModel;
using SavePassword.API.Application.Entity;

namespace SavePassword.API.Core.Contracts.Infrastructure
{
    public interface ISecretRepository
    {
        Task<IList<Secret>> GetAllAsync(CancellationToken ct);
        Task<Secret> GetAsync(Guid id);
        Task AddAsync(SecretInputModel dto, CancellationToken ct);
        Task UpdateAsync(Guid id, SecretInputModel dto, CancellationToken ct);
        Task DeleteAsync(Guid id);   
    }
}
