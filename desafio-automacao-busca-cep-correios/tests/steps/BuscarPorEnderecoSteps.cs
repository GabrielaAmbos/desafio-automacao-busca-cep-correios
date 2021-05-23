using desafio_automacao_busca_cep_correios.pageObjects;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using desafio_automacao_busca_cep_correios.utils;
using desafio_automacao_busca_cep_correios.utils.providers;

namespace desafio_automacao_busca_cep_correios.tests.steps
{
    [Binding]
    public class BuscarPorEnderecoSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public BuscarPorEnderecoSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        BuscaPorEnderecoOuCEPPageObjects buscaPorEnderecoOuCEPPage = new BuscaPorEnderecoOuCEPPageObjects();
        ResultadoPorEnderecoOuCEPPageObjects resultadoPorEnderecoOuCEPPage = new ResultadoPorEnderecoOuCEPPageObjects();


        [Given(@"que eu acesse a página de Busca por Endereço ou CEP")]
        public void DadoQueEuAcesseAPaginaDeBuscaPorEnderecoOuCEP()
        {
            Browser.LoadApplication(UrlProvider.BaseUrl());
        }

        [When(@"eu solicito buscar por ""(.*)""")]
        public void QuandoEuSolicitoBuscarPor(string cepOuEndereco)
        {
            buscaPorEnderecoOuCEPPage.BuscaSimples(cepOuEndereco);
        }

        [Then(@"devo visualizar os dados da pesquisa")]
        public void EntaoDevoVisualizarOsDadosDaPesquisa(Table dadosRetornados)
        {
            foreach (var row in dadosRetornados.Rows)
            {
                string logradouroOuNome = row["Logradouro/Nome"];
                string bairroOuDistrito = row["Bairro/Distrito"];
                string localidadeOuUF = row["Localidade/UF"];
                string CEP = row["CEP"];

                Assert.AreEqual(localidadeOuUF,resultadoPorEnderecoOuCEPPage.getTextLocalidadeOuUF());
                Assert.AreEqual(bairroOuDistrito, resultadoPorEnderecoOuCEPPage.getTextBairroOuDistrito());
                Assert.AreEqual(localidadeOuUF, resultadoPorEnderecoOuCEPPage.getTextLocalidadeOuUF());
                Assert.AreEqual(CEP, resultadoPorEnderecoOuCEPPage.getTextCEP());
            }
        }

    }
}
