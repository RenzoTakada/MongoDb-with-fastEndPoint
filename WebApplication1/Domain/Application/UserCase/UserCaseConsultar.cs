using Adapters.MongoDb.Core.Response;
using Adapters.MongoDb.Service;
using Domain.Application.Mapping;
using Domain.Core.Request;
using Domain.Core.Response;

namespace Domain.Application.UserCase
{
    public interface IUSCConsultar
    {
        Task<DadosContaResponse> USCConsultar(DadosContaRequest request);
    }
    public class UserCaseConsultar : IUSCConsultar
    {
        private readonly IMongoService _mongoService;


        public UserCaseConsultar(IMongoService services)
        {
            _mongoService = services;

        }

        public async Task<DadosContaResponse> USCConsultar(DadosContaRequest request)
        {
            var RepositoryMongo = _mongoService.GetConsultar(request);

            var resultMap = MapConsultar.MappingConsulta(RepositoryMongo.Result);
            return resultMap;

        }

    }
}
