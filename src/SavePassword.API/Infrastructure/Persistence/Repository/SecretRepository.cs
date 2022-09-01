using MongoDB.Driver;
using SavePassword.API.Application.DTO.InputModel;
using SavePassword.API.Application.Entity;
using SavePassword.API.Core.Contracts.Infrastructure;
using SavePassword.API.Infrastructure.Persistence.Context;

namespace SavePassword.API.Infrastructure.Persistence.Repository
{
    public class SecretRepository : ISecretRepository
    {
        private readonly IMongoCollection<Secret> _secret;

        public SecretRepository(DatabaseContext context) => _secret = context.Database.GetCollection<Secret>(nameof(Secret));

        public IQueryable<Secret> GetAll() => _secret.AsQueryable();

        public async Task AddAsync(SecretInputModel dto, CancellationToken ct)
        {
            await _secret.InsertOneAsync(dto.ToEntity(), cancellationToken: ct);
        }

        public async Task DeleteAsync(string id, CancellationToken ct)
        {
            var entity = GetAsync(id);

            entity.Delete();

            var filter = Builders<Secret>.Filter.Where(w => w.Id == id);

            await _secret.ReplaceOneAsync(filter, entity, cancellationToken: ct);
        }
     
        public Secret GetAsync(string id)
        {
            return GetAll().FirstOrDefault(w => w.Id == id);
        }

        public async Task UpdateAsync(string id, SecretInputModel dto, CancellationToken ct)
        {
            var filter = Builders<Secret>.Filter.Where(w => w.Id == id);

            var entity = dto.ToEntity();

            entity.Id = id;

            await _secret.ReplaceOneAsync(filter, entity, cancellationToken: ct);
        }
    }
}
