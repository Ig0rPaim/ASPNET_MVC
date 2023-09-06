using BuilderAux_MVC.Models;

namespace BuilderAux_MVC.Rotinas.Entrada_Saida_de_Materiais
{
    public class EntradaDeMateriais
    {
        public void Cadastrar(string NomeServico)
        {
            NomesServicos NovoServico = new NomesServicos(NomeServico);
        }
    }
}
