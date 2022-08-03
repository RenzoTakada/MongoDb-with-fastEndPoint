using FastEndpoints;
using Adapters.MongoDb.Core.Response;
using Domain.Application.UserCase;
using Domain.Core.Enums;
using Domain.Core.Request;
using Domain.Core.Response;

namespace MongoDbProject.Controller
{
    public class EndPointDadosConta : Endpoint<DadosContaRequest, DadosContaResponse>
    {
        private readonly IUSCConsultar _uSCConsultar;


        public EndPointDadosConta(IUSCConsultar services)
        {
            _uSCConsultar = services;

        }
        public override void Configure()
        {
            Post("/Consultar");
            AllowAnonymous();
        }

        public override async Task HandleAsync(DadosContaRequest request, CancellationToken ct)
        {
            var result = _uSCConsultar.USCConsultar(request);
            await SendAsync(result.Result);
        }



    }
}
