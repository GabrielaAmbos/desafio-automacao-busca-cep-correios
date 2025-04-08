[![Typing SVG](https://readme-typing-svg.demolab.com?font=Fira+Code&pause=1000&color=DF62F7&width=435&lines=Projeto+de+Automa%C3%A7%C3%A3o+CEP+Correios)](https://git.io/typing-svg)


Projeto de automação no site https://buscacepinter.correios.com.br/ utilizando a linguagem C# e o framework de automação Selenium WebDriver, explorando a funcionalidade 'Busca por CEP'.

## Feature testada:

**Funcionalidade:** Buscar por um endereço ou CEP <br>
	_Como um usuário_ <br>
	_Desejo consultar um endereço ou CEP_ <br>
	_Para que eu possa visualizar os dados completos do local que estou buscando_ <br>

    Cenário: Buscar por um CEP válido 
	Dado que eu acesse a página de Busca por Endereço ou CEP
	Quando eu solicito buscar por "69005-040"
	Então devo visualizar os dados da pesquisa
		| Logradouro/Nome  | Bairro/Distrito | Localidade/UF | CEP       |
		| Rua Miranda Leão | Centro          | Manaus/AM     | 69005-040 |

    Cenário: Buscar por um endereço válido
	Dado que eu acesse a página de Busca por Endereço ou CEP
	Quando eu solicito buscar por "Lojas Bemol"
	Então devo visualizar os dados da pesquisa
		| Logradouro/Nome                  | Bairro/Distrito | Localidade/UF | CEP       |
		| Rua Miranda Leão, 41 Lojas Bemol | Centro          | Manaus/AM     | 69005-901 |
