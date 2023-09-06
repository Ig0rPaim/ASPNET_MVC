namespace BuilderAux_MVC.Models
{
    public class NomesServicos
    {
        public int Id { get; set; }
        public string NomeServico { get; set; }

        public NomesServicos(int id, string nomeServico)
        {
            Id = id;
            NomeServico = nomeServico ?? throw new ArgumentNullException(nameof(nomeServico));
        }

        public NomesServicos(string nomeServico)
        {
            NomeServico = nomeServico ?? throw new ArgumentNullException(nameof(nomeServico));
        }
    }
}
