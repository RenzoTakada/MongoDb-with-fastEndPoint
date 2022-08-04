using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbProject.Adapters.MongoDb.Core.Response
{
    public class EmpresasNome
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? id { get; set; }
        [BsonElement("empresa")]
        public string nomeEmpresa { get; set; }

    }
}
