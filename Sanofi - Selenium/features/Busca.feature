#language: pt-BR

Funcionalidade:  Busca
                 Como usuario do sistema
				 devo conseguir realizar Buscas
				 Para localizar o que preciso, mais rápido


Cenario: Pesquisar registro pelo nome completo 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Busca
E preencho o campo Buscar com "dipirona"
E clico em Pesquisar
Então eu devo visualizar os registros "Dorflex®,Novalgina®"

Cenario: Pesquisar registro por parte do nome
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Busca
E preencho o campo Buscar com "ai"
E clico em Pesquisar
Então eu devo visualizar o registro "Aixa"
Quando eu clico no registro "Aixa"
Então eu devo ser direcionado para página de "produtos"

Cenario: Pesquisar por um item utilizando Palavras com Traços 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Busca no footer
E preencho o campo Buscar com "os-cal"
E clico em Pesquisar
Então eu devo visualizar os registros "Mobility Os-cal,Os-cal® 500,Os-cal® 500 + D,Os-cal® CIT,Os-cal® D 1000,Os-cal® D 400"

Cenario: Pesquisar por um item utilizando Palavras acentuadas e com preposições  
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Busca no footer
Quando preencho o campo Buscar com "instruções da automação" 
E clico em Pesquisar
Então eu devo visualizar os registros "Evento Zinpass Eze 2021 - Automação Data Futura,automacao-ao-vivo"


Cenario: Buscar sem preencher nada
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Busca
E clico em Pesquisar
Então eu devo visualizar a lista de A a Z com os Produtos "A"


Cenario: Pesquisar por um item que não retorne resultado
Dado que eu acesse o sistema
Quando eu clico em Busca
E preencho o campo Buscar com "automation"
E clico em Pesquisar
Então eu não devo visualizar o registro "automation"

Cenario: Pesquisar por um item, deslogado do sistema
Dado que eu acesse o sistema
Quando eu clico em Busca 
E preencho o campo Buscar com "importância"
E clico em Pesquisar
Então eu não devo visualizar as páginas de "Produtos" 
E eu não devo visualizar as páginas de "Eventos"
