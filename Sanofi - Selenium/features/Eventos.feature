﻿#language: pt-BR


Funcionalidade:  Evento
                 Como usuario do sistema
				 Preciso ter acesso aos Eventos 
				 Para obter as informacoes que eu preciso


Cenario: Salvar evento no calendário através de um Link no body 
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/evento-zinpass-eze-2021-automacao-data-futura"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico" 
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
E eu devo ver o modal de Pesquisa
Quando eu Fecho a pesquisa
E escolho o Estado "SC"
E preencho o campo Número do registro com "2103"
E preencho o campo Senha com "123456"
E clico em Logar
Entao eu visualizo o evento "https://stg-cd.sanoficonecta.com.br/eventos/evento-zinpass-eze-2021-automacao-data-futura"
Quando clico em Salvar no calendário dentro da palestra
E escolho Apple dentro da palestra

Cenario: Tentar acessar evento exclusivo, utilizando perfil sem permissão
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico" 
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Quando escolho tipo de HCP "Farmacêutico (CRF)"
E escolho o Estado "CE"
E preencho o campo Número do registro com "19861"
E preencho o campo Senha com "123456"
E clico em Logar
Entao devo ver a mensagem do evento "Olá farmaceutico, Esse conteúdo é exclusivo para Médico."

Cenario: Tentar acessar evento exclusivo para outro perfil, a partir do SoftLogin 
Dado que eu acesse a campanha "https://stg-cd.sanoficonecta.com.br/campanha/dits"
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Médica e Farmacêutica"
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao 
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "SC"
E preencho o campo do registro com "1781"
E preencho o Email com "ledadentista@grr.la"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
Entao devo ver a mensagem do evento "Olá, Esse conteúdo é exclusivo para Médico e Farmacêutico."
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/evento-zinpass-eze-2021-automacao-data-futura"
E eu Fecho a pesquisa
Entao devo ver a mensagem do evento "Olá, Esse conteúdo é exclusivo para Médico." 

Cenario: Tentar adicionar evento aos favoritos, utilizando perfil sem permissão
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico"  
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "SC"
E preencho o campo Número do registro com "1781"
E preencho o campo Senha com "123456"
E clico em Logar
Entao devo ver a mensagem do evento "Olá Leda, Esse conteúdo é exclusivo para Médico."
Quando Eu clico em fechar
E eu clico em Favoritos Eventos
Entao devo ver a mensagem do evento "Olá Leda, Esse conteúdo é exclusivo para Médico."

Cenario: Adicionar e Retirar Evento dos favoritos
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico"
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "2103"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu visualizo o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Quando eu clico em Favoritos Eventos
Entao devo ver a mensagem de salvamento "Evento adicionado à sua área pessoal" 
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Então devo ver a mensagem de salvamento "Item removido da sua área pessoal"

Cenario: Compartilhar evento nas redes sociais e Copiar link
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
#E eu clico em Rejeitar Todos
E clico em Logar
Então devo ver meu nome "Medico Teste" no menu profile
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao eu visualizo o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Quando eu clico em Compartilhar Evento
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

Cenario: Acessar evento exclusivo data passada
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico" 
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Entao eu visualizo o evento "https://stg-cd.sanoficonecta.com.br/eventos/hipoplay-now-hipotireoidismo-e-o-coracao"
E não devo ver o botão de Adicionar a meu calendário


Cenario: Adicionar evento ao calendário
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/evento-zinpass-eze-2021-automacao-data-futura"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico" 
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Entao eu devo ver o modal de Pesquisa
Quando eu Fecho a pesquisa 
E escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Entao eu visualizo o evento "https://stg-cd.sanoficonecta.com.br/eventos/evento-zinpass-eze-2021-automacao-data-futura"
E devo ver o botão de "Adicionar a meu calendário"
Quando eu clico em "Adicionar a meu calendário"
E seleciono a opcao "Google"
Entao eu devo ver o botão "Adicionado"


Cenario:  Acessar evento dentro do periodo do evento
Dado que eu acesse o sistema
Quando eu acesso o evento "https://stg-cd.sanoficonecta.com.br/eventos/evento-zinpass-eze-2021-automacao-ao-vivo"
Entao devo ver a mensagem do evento exclusivo "Conteúdo exclusivo para Médico" 
#E eu devo ver as configurações de cookies
#Quando eu clico em Rejeitar Todos
Entao eu devo ver o modal de Pesquisa
Quando eu Fecho a pesquisa
E escolho o Estado "SC"
E preencho o campo Número do registro com "2103"
E preencho o campo Senha com "123456"
E clico em Logar 
Entao devo ver o botão "Ao vivo agora!" 