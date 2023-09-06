namespace BuilderAux_MVC.Models
{
    public class Itens
    {
        public int Id { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }
        public double ValorPorUnidade { get; set; }
        public double MaoDeObra { get; set; }
        public int TipoServico { get; set; }
        public NomesServicos TipoServicoNavigation { get; set; } // Propriedade de navegação

        public Itens(int id, string unidade, double quantidade, double valorPorUnidade, double maoDeObra, int tipoServico, NomesServicos tipoServicoNavigation)
        {
            Id = id;
            Unidade = unidade ?? throw new ArgumentNullException(nameof(unidade));
            Quantidade = quantidade;
            ValorPorUnidade = valorPorUnidade;
            MaoDeObra = maoDeObra;
            TipoServico = tipoServico;
            TipoServicoNavigation = tipoServicoNavigation ?? throw new ArgumentNullException(nameof(tipoServicoNavigation));
        }

        public Itens(int id, string unidade, double quantidade, double valorPorUnidade, double maoDeObra, int tipoServico)
        {
            Id = id;
            Unidade = unidade ?? throw new ArgumentNullException(nameof(unidade));
            Quantidade = quantidade;
            ValorPorUnidade = valorPorUnidade;
            MaoDeObra = maoDeObra;
            TipoServico = tipoServico;
        }
    }
}
