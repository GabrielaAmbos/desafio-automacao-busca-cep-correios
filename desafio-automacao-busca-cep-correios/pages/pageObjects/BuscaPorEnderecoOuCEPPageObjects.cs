using desafio_automacao_busca_cep_correios.elementMapper;
using desafio_automacao_busca_cep_correios.utils;
using SeleniumExtras.PageObjects;

namespace desafio_automacao_busca_cep_correios.pageObjects
{
    public class BuscaPorEnderecoOuCEPPageObjects : BuscaPorEnderecoOuCEPElementMapper
    {
        public BuscaPorEnderecoOuCEPPageObjects()
        {
            PageFactory.InitElements(Browser.GetCurrentDriver(), this);
        }

        public void SendKeysCampoEndereco(string endereco)
        {
            CampoEndereco.SendKeys(endereco);
        }

        public void ClickBotaoBuscar()
        {
            BotaoBuscar.Click();
        }

        public string GetTextNomeDaPagina()
        {
            return NomeDaPagina.Text;
        }

        public void BuscaSimples(string cepOuEndereco)
        {
            SendKeysCampoEndereco(cepOuEndereco);
            ClickBotaoBuscar();
        }

    }
}
