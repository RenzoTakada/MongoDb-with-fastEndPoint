
using Domain.Core.Enums;

namespace Domain.Core.Response
{
    public record DadosContaResponse
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string nomeCliente { get; set; }
        public double Saldo { get; set; }
        public DateTime DataNasc { get; set; }
        public string cpf { get; set; }
        public EnumTipoConta tipoConta { get; set; }
        public string nomeEmpresa { get; set; }



    }
}
