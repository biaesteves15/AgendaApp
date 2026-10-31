using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AgendaApp.Api.Models
{
    public class Tarefa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }

        [BsonElement("Nome")]
        public string Nome { get; set; } = string.Empty;

        [BsonElement("Descricao")]
        public string Descricao { get; set; } = string.Empty;

        [BsonElement("Data")]
        public DateTime Data { get; set; }

        [BsonElement("Finalizado")]
        public bool Finalizado { get; set; } = false;

        [BsonElement("DataCriacao")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
