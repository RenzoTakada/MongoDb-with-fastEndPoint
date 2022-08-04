using Adapters.MongoDb.Core.Response;
using Domain.Core.Request;
using MongoDbProject.Adapters.MongoDb.Core.Response;

namespace Adapters.MongoDb.Service
{
    public interface IMongoService
    {
        Task<DadosContaMongo> GetConsultar(DadosContaRequest req);
        Task<EmpresasNome> GetNomes(DadosContaRequest req);
    }
}
