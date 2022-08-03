using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Adapters.MongoDb.Core.Response;
using Adapters.MongoDb.Settings;
using Domain.Core.Request;

namespace Adapters.MongoDb.Service
{
    public class MongoService : IMongoService
    {
        private readonly IMongoCollection<DadosContaMongo> _mongoCollection;


        public MongoService(IOptions<MongoDBSettings> mongoConnection)
        {
            var mongoCliente = new MongoClient(mongoConnection.Value.ConnectionString);
            var mongoDataBase = mongoCliente.GetDatabase(mongoConnection.Value.DataBaseName);


            _mongoCollection = mongoDataBase.GetCollection<DadosContaMongo>(mongoConnection.Value.CollectionName);
        }


        public async Task<DadosContaMongo> GetConsultar(DadosContaRequest req)
        {
            var result = await _mongoCollection.Find(x => x.NumeroConta == req.NumeroConta).FirstOrDefaultAsync();
            return result;
        }

    }
}
