using System.Text.Json.Serialization;

namespace TiposRelacionamentosProjeto.Models
{
    public class QuartoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CasaId { get; set; }
        [JsonIgnore]
        public CasaModel Casa { get; set; }
    }
}
