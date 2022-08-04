using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Adapters.MongoDb.Core.Response;
using Adapters.MongoDb.Settings;
using Domain.Core.Request;
using MongoDbProject.Adapters.MongoDb.Core.Response;

namespace Adapters.MongoDb.Service
{
    public class MongoService : IMongoService
    {
        private IMongoCollection<DadosContaMongo> _collectioDadosContaMongo;
        private readonly IMongoDatabase mongoDataBase;
        private IMongoCollection<EmpresasNome> _collectionNomeEmpresas;
        public MongoService(IOptions<MongoDBSettings> mongoConnection)
        {
            var mongoCliente = new MongoClient(mongoConnection.Value.ConnectionString);
            mongoDataBase = mongoCliente.GetDatabase(mongoConnection.Value.DataBaseName);



        }


        public async Task<DadosContaMongo> GetConsultar(DadosContaRequest req)
        {
            _collectioDadosContaMongo = mongoDataBase.GetCollection<DadosContaMongo>("DataBaseName");
            var result = await _collectioDadosContaMongo.Find(x => x.NumeroConta == req.NumeroConta).FirstOrDefaultAsync();
            return result;
        }
        public async Task<EmpresasNome> GetNomes(DadosContaRequest req)
        {
            _collectionNomeEmpresas = mongoDataBase.GetCollection<EmpresasNome>("NomesDeEmpresas");
            var result = await _collectionNomeEmpresas.Find(x => x.nomeEmpresa == req.empresa).FirstOrDefaultAsync();
            return result;
        }

    }
}
