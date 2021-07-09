#language: pt-BR

Funcionalidade: Calendário
                Para ficar a par dos eventos 
                Eu, como usuário do sistema
                Devo visualizar e acessar meus eventos através do calendário

Cenario: Acessar evento com data passada 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico04@teste.com "
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Calendário"
Então eu devo ser direcionado para página de "calendario"
Quando eu clico no evento "top-experts-meeting"
Então eu devo ser direcionado para página de "top-experts-meeting"

Cenario: Acessar evento ao vivo
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico04@teste.com "
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Calendário"
Então eu devo ser direcionado para página de "calendario"
Quando eu clico no botão Ao vivo
Então eu devo visualizar o arquivo "webinarsanofi" em outra janela

Cenario: Adicionar evento ao calendário
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico04@teste.com "
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Calendário"
Então eu devo ser direcionado para página de "calendario"
Quando eu clico no botão Adicionar ao meu calendário
E seleciono a opcao "Google"
Entao eu devo ver o botão "Adicionado"
