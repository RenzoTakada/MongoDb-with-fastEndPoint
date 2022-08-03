using MongoDB.Bson.Serialization.Attributes;
using Domain.Core.Enums;

namespace Adapters.MongoDb.Core.Response
{
    public record DadosContaMongo
    {
        [BsonId]
        public Guid id { get; set; }
        [BsonElement("NumeroConta")]
        public int NumeroConta { get; set; }
        [BsonElement("Agencia")]
        public int Agencia { get; set; }

        [BsonElement("nomeCliente")]
        public string nomeCliente { get; set; }
        [BsonElement("Saldo")]
        public double Saldo { get; set; }
        [BsonElement("DataNasc")]
        public DateTime DataNasc { get; set; }
        [BsonElement("cpf")]
        public string cpf { get; set; }
        [BsonElement("tipoConta")]
        public EnumTipoConta tipoConta { get; set; }
    }
}
