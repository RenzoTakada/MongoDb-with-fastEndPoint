using Adapters.MongoDb.Core.Response;
using Domain.Core.Response;

namespace Domain.Application.Mapping
{

    public static class MapConsultar
    {
        public static DadosContaResponse MappingConsulta(DadosContaMongo dadosContaMongo)
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

            };
            return DadosResponse;
        }
    }
}
