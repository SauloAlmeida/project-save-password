using SavePassword.API.Application.DTO.InputModel;
using SavePassword.API.Application.Entity;

namespace SavePassword.API.Core.Contracts.Infrastructure
{
    public interface ISecretRepository
    {
        IQueryable<Secret> GetAll();
        Secret GetAsync(string id);
        Task AddAsync(SecretInputModel dto, CancellationToken ct);
        Task UpdateAsync(string id, SecretInputModel dto, CancellationToken ct);
        Task DeleteAsync(string id, CancellationToken ct);
    }
}
