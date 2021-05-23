using desafio_automacao_busca_cep_correios.elementMapper;
using desafio_automacao_busca_cep_correios.utils;
using SeleniumExtras.PageObjects;

namespace desafio_automacao_busca_cep_correios.pageObjects
{
    public class ResultadoPorEnderecoOuCEPPageObjects : ResultadoDaBuscaPorEnderecoOuCEPElementMapper
    {
        public ResultadoPorEnderecoOuCEPPageObjects()
        {
            PageFactory.InitElements(Browser.GetCurrentDriver(), this);
        }

        public string getTextLogradouroOuNome()
        {
            return LogradouroOuNome.Text;
        }

        public string getTextBairroOuDistrito()
        {
            return BairroOuDistrito.Text;
        }

        public string getTextLocalidadeOuUF()
        {
            return LocalidadeOuUF.Text;
        }

        public string getTextCEP()
        {
            return CEP.Text;
        }

        public void ClickBotaoVoltar()
        {
            BotaoVoltar.Click();
        }
    }
}
