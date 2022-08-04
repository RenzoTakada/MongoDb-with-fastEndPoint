using Adapters.MongoDb.Core.Response;
using Domain.Core.Response;
using MongoDbProject.Adapters.MongoDb.Core.Response;

namespace Domain.Application.Mapping
{

    public static class MapConsultar
    {
        public static DadosContaResponse MappingConsulta(DadosContaMongo dadosContaMongo, EmpresasNome empresa)
        {
            var DadosResponse = new DadosContaResponse()
            {
                Agencia = dadosContaMongo.Agencia,
                NumeroConta = dadosContaMongo.NumeroConta,
                nomeCliente = dadosContaMongo.nomeCliente,
                Saldo = dadosContaMongo.Saldo,
                cpf = dadosContaMongo.cpf,
                DataNasc = dadosContaMongo.DataNasc,
                tipoConta = dadosContaMongo.tipoConta,
                nomeEmpresa = empresa.nomeEmpresa

            };
            return DadosResponse;
        }
    }
}
