#language: pt-BR
Funcionalidade: EsqueciSenha
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Cenario: Recuperar Senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha

Cenario: Tentar recuperar senha utilizando Número do registro invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho o Estado "TO"
E preencho o campo Número do registro com "7777"
E clico em Prosseguir
Entao devo ver as mensagens de erro do Login "Registro não localizado"

Cenario: Reenviar email de recuperacao de senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho o Estado "SC" 
E preencho o campo Número do registro com "11655"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha
Dado que eu clique em Não recebeu? Reenviar email
Entao eu devo ver a tela de envio de senha

Cenario: Alterar email de recuperacao de senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com "21660"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha
Dado que eu clique em Não tenho mais acesso a este email
E seja exibido o final do numero do telefone "2222"
Quando eu preencho o campo Celular com "22222222222"
Quando eu preencho o campo Novo email com "dentista@servidor.com"
E clico em Habilitar novo email 
Entao eu devo ver a tela de envio de senha

# Bug: Realiza a alteração, mesmo com email inválido
Cenario: Tentar alterar email de recuperacao de senha utilizando Email invalido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "RR"
E preencho o campo Número do registro com "123456"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha
Dado que eu clique em Não tenho mais acesso a este email
E seja exibido o final do numero do telefone "2222"
Quando eu preencho o campo Celular com "22222222222"
Quando eu preencho o campo Novo email com "abc123.com"
E clico em Habilitar novo email
Entao devo ver as mensagens de erro do Login "Email inválido"

Cenario: Tentar alterar email de recuperacao de senha utilizando Email ja existente
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com "21660"
E clico em Prosseguir
Entao eu devo ver a tela de envio de senha
Dado que eu clique em Não tenho mais acesso a este email
E seja exibido o final do numero do telefone "2222"
Quando eu preencho o campo Celular com "22222222222"
Quando eu preencho o campo Novo email com "maria@teste.com"
E clico em Habilitar novo email
Entao devo ver as mensagens de erro do Login "Já existe um usuário com este e-mail"

Cenario: Verificar obrigatoriedade dos campos ao Recuperar senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando clico em Esqueceu sua senha?
E clico em Prosseguir
Entao devo ver as mensagens de erro do Login "Escolher Estado,Favor informar seu número de registro"