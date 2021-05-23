using desafio_automacao_busca_cep_correios.utils;
using desafio_automacao_busca_cep_correios.utils.providers;
using TechTalk.SpecFlow;

namespace desafio_automacao_busca_cep_correios.tests
{
    [Binding]
    public sealed class Hooks
    {
        [Before]
        public void Setup()
        {
            Browser.SetCurrentBrowser(Browser.Type.CHROME);
        }

        [After]
        public void TearDown()
        {
            Browser.QuitDriver();
        }
    }
}
