#language: pt
Funcionalidade: Buscar por um endereço ou CEP
	Como um usuário
	Desejo consultar um endereço ou CEP
	Para que eu possa visualizar os dados completos do local que estou buscando

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

