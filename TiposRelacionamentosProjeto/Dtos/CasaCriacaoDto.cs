namespace TiposRelacionamentosProjeto.Dtos
{
    public class CasaCriacaoDto
    {
        public string Descricao { get; set; }
        public EnderecoCriacaoDto endereco { get; set; }
        public List<QuartoCriacaoDto> quartos { get; set; }
        public List<MoradorCriacaoDto> moradores { get; set; }

    }
}
