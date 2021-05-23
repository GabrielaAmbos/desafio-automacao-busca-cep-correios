using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace desafio_automacao_busca_cep_correios.elementMapper
{
    public class BuscaPorEnderecoOuCEPElementMapper
    {
        [FindsBy(How = How.CssSelector, Using = "#endereco")]
        public IWebElement CampoEndereco { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn_pesquisar")]
        public IWebElement BotaoBuscar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#trilha b")]
        public IWebElement NomeDaPagina { get; set; }
    }
}
