#language: pt-BR
Funcionalidade: CriarConta
	Para garantir que a Criacao de Conta funciona
    Eu, como usuário do sistema
    Desejo Criar minha conta para ter acesso completo ao conteudo do sistema.

Cenario: Criar Conta  
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
E Eu preencho o campo Nome com "Doctor Angry"
E preencho o campo Sobrenome com "Birds"
E eu preencho o Celular com "79123456789"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"



Cenario: Tentar Criar Conta utilizando Número do registro ja cadastrado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo do registro com "21660"
E preencho o Email com "abcd@automacao.com"
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
Entao eu devo ser direcionado para página para validar o email
Quando preencho o campo de validação de Email com "dentista@servidor.com"
E clico em Prosseguir
E preencho o campo Adicionar Senha com "123456"
E clico em Finalizar
Então devo ver meu nome "jose" no menu profile 

Cenario: Criar Conta utilizando Email ja cadastrado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo do registro com "3921"
E preencho o Email com "maria@teste.com" 
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
Entao devo ver as mensagens de erro do Login "Este email já está cadastrado,"

Cenario: Tentar criar conta utilizando um Numero de registro invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho o Estado "BA"
E preencho o campo do registro com "1234567"
E preencho o Email com "abc12345@testing.com"
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
Entao devo ver as mensagens de erro do Login "CRM invalido no CFM,"

Cenario: Verificar obrigatoriedade dos campos ao criar conta
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando eu clico em Continuar
Entao devo ver as mensagens de erro do Login "Escolher Estado,Favor informar seu número de registro,Email inválido,Marcar o aceite,"


Cenario: Tentar criar conta com Celular invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Dentista(CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
E Eu preencho o campo Nome com "Doctor Angry"
E preencho o campo Sobrenome com "Birds"
E eu preencho o Celular com "111111"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
Entao devo ver as mensagens de erro do Login "Celular inválido"

Cenario: Criar conta com usuario Validado (SoftLogin)
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Farmaceutico (CRF)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
Entao eu devo ser direcionado para página de finalizacao de cadastro
Quando clico em Fechar
E eu clico no menu profile validado para expandir
E clico em Criar conta
E insiro o email aleatório
E clico em Logar
Entao eu devo ser direcionado para página de finalizacao de cadastro
Quando Eu preencho o campo Nome com "Doctor Bob"
E preencho o campo Sobrenome com "Esponja"
E eu preencho o Celular com "79123456789"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"
