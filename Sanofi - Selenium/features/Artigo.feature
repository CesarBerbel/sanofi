#language: pt-BR
Funcionalidade: Artigo
	            Como usuario do sistema
				Preciso ter acesso aos Artigos 
				Para obter as informacoes que eu preciso

Cenario: Acessar artigo exclusivo
Dado que eu acesso artigo "https://stg-cd.sanoficonecta.com.br/artigos/boletim-informacoes-medicas-servico-de-informacao-sobre-vacinacao-siv"
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Médica, Farmacêutica, Enfermagem e Odontológica" 
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo do registro com "6666666"
E preencho o Email com "dentista06@teste.com"
E Eu preencho o campo Nome com "Dentista"
E preencho o campo Sobrenome com "Six"
E eu preencho o Celular com "71987165507"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
E preencho o campo Adicionar Senha com "123456"
E clico em Finalizar Validacao
Entao eu visualizo o artigo "https://stg-cd.sanoficonecta.com.br/artigos/boletim-informacoes-medicas-servico-de-informacao-sobre-vacinacao-siv" 

Cenario: Acessar artigo exclusivo, utilizando perfil sem permissão
Dado que eu acesso artigo "https://stg-cd.sanoficonecta.com.br/artigos/Hipotireoidismo-e-riscos-associados-modulo-III-dislipidemia"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico" 
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao 
Quando escolho tipo de HCP "Farmacêutico (CRF)"
E escolho o Estado "BA"
E preencho o campo do registro com "4444444"
E preencho o Email com "farma04@teste.com"
E Eu preencho o campo Nome com "Farma"
E preencho o campo Sobrenome com "Four"
E eu preencho o Celular com "71987165507"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
Entao devo ver a mensagem do artigo "Olá,Esse conteúdo é exclusivo para Médico."

Cenario: Adicionar e Retirar Artigo dos favoritos
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então devo ver meu nome "Medico Teste" no menu profile
Quando eu acesso o artigo "https://stg-cd.sanoficonecta.com.br/artigos/4-consenso-brasileiro-rinites"
Entao eu visualizo o artigo "https://stg-cd.sanoficonecta.com.br/artigos/4-consenso-brasileiro-rinites"
Quando eu clico em Favoritos
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Então devo ver a mensagem de salvamento "Item removido da sua área pessoal"


Cenario: Compartilhar Artigo nas redes sociais e Copiar link
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então devo ver meu nome "Medico Teste" no menu profile
Quando eu acesso o artigo "https://stg-cd.sanoficonecta.com.br/artigos/4-consenso-brasileiro-rinites"
Entao eu visualizo o artigo "https://stg-cd.sanoficonecta.com.br/artigos/4-consenso-brasileiro-rinites"
Quando eu clico em Compartilhar
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

Cenario: Acessar artigo exclusivo, com Soft Login
Dado que eu acesse o sistema
Quando eu acesso o artigo "https://stg-cd.sanoficonecta.com.br/artigos/Hipotireoidismo-e-riscos-associados-modulo-III-dislipidemia"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico"
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao 
Quando escolho tipo de HCP "Farmacêutico (CRF)"
E escolho o Estado "BA"
E preencho o campo do registro com "4444444"
E preencho o Email com "farma04@teste.com"
E Eu preencho o campo Nome com "Farma"
E preencho o campo Sobrenome com "Four"
E eu preencho o Celular com "71987165507"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
Entao devo ver a mensagem do artigo "Olá,Esse conteúdo é exclusivo para Médico."
Quando Eu clico para voltar pra Home
E eu acesso o artigo "https://stg-cd.sanoficonecta.com.br/artigos/allenasal-na-rinite-alergica-pediatrica"
Entao eu visualizo o artigo "https://stg-cd.sanoficonecta.com.br/artigos/allenasal-na-rinite-alergica-pediatrica"