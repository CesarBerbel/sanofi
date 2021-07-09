#language: pt-BR
Funcionalidade: Logar no sistema
                Para garantir que o login funciona
                Eu, como usuário já cadastrado
                Desejo me logar no sistema para ter acesso ao conteúdo para meu usuário.

Cenario: Logar no sistema com Número do registro
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "BA"
E preencho o campo Número do registro com "4163"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
E devo ver meu nome "Doctor" no menu profile 
 
Cenario: Realizar Login no sistema utilizando Email
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico04@teste.com "
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
E devo ver meu nome "Doctor" no menu profile 
Dado eu clico no menu profile logado para expandir
Quando eu clico em Encerrar Sessao
Entao eu devo ser direcionado para Home deslogada

Cenario: Tentar Logar no sistema utilizando dados invalido 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "TO"
E preencho o campo Número do registro com "6666"
E preencho o campo Senha com "1946852"
E clico em Logar
Então devo ver as mensagens de erro do Login "Documento e/ou senha inválidos"
Quando Eu escolho o login por email
E preencho o campo Email com "nuumexiste@nuncavi.com"
E preencho o campo Senha com "1946852"
E clico em Logar
Então devo ver as mensagens de erro do Login "E-mail e/ou senha inválidos"

Cenario: Verificar obrigatoriedade dos campos no Login
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Logar
Então devo ver as mensagens de erro do Login "Escolher Estado,Favor informar seu número de registro,Favor informar sua senha"
Quando Eu escolho o login por email
Quando clico em Logar
Então devo ver as mensagens de erro do Login "Email inválido,Favor informar sua senha"