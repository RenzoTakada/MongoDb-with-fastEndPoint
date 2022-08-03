using Adapters.MongoDb.Core.Response;
using Domain.Core.Request;

namespace Adapters.MongoDb.Service
{
    public interface IMongoService
    {
        Task<DadosContaMongo> GetConsultar(DadosContaRequest req);
    }
}
