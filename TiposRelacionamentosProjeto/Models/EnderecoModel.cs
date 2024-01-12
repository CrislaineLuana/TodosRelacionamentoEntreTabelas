using System.Text.Json.Serialization;

namespace TiposRelacionamentosProjeto.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int CasaId { get; set; }
        [JsonIgnore]
        public CasaModel Casa { get; set; }
    }
}
