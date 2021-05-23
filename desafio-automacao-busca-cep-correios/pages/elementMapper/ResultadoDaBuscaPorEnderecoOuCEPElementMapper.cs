using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace desafio_automacao_busca_cep_correios.elementMapper
{
    public class ResultadoDaBuscaPorEnderecoOuCEPElementMapper
    {
        [FindsBy(How = How.CssSelector, Using = "#mensagem-resultado")]
        public IWebElement TitutoMensagemResultado { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@data-th='Logradouro/Nome']")]
        public IWebElement LogradouroOuNome { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@data-th='Bairro/Distrito']")]
        public IWebElement BairroOuDistrito { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@data-th='Localidade/UF']")]
        public IWebElement LocalidadeOuUF { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@data-th='CEP']")]
        public IWebElement CEP { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn_voltar")]
        public IWebElement BotaoVoltar { get; set; }
    }
}

