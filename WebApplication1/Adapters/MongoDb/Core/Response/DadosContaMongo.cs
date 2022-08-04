using MongoDB.Bson.Serialization.Attributes;
using Domain.Core.Enums;

namespace Adapters.MongoDb.Core.Response
{
    public record DadosContaMongo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? id { get; set; }
        [BsonElement("numeroConta")]
        public int NumeroConta { get; set; }
        [BsonElement("agencia")]
        public int Agencia { get; set; }

        [BsonElement("nomeCliente")]
        public string nomeCliente { get; set; }
        [BsonElement("saldo")]
        public double Saldo { get; set; }
        [BsonElement("dataNasc")]
        public DateTime DataNasc { get; set; }
        [BsonElement("cpf")]
        public string cpf { get; set; }
        [BsonElement("tipoConta")]
        public EnumTipoConta tipoConta { get; set; }
    }
}
