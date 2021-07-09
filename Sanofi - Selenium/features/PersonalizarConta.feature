#language: pt-BR

Funcionalidade:  Personalizar Conta
                 Como usuario do sistema
				 devo conseguir alterar minhas preferências e dados pessoais 
				 Para deixar minha conta personalizada


Cenario: Alterar numero do celular
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta
E eu altero o Celular para um numero valido
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Alterar numero do celular utilizando um numero inválido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu altero o Celular para "00111111111"
Então eu nao devo ver o botao Salvar 

Cenario: Alterar email
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "maria@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E altero o Email com email válido
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando altero o Email para "maria@teste.com"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Tentar alterar email ja existente
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "maria@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E altero o Email para "testemedico@grr.la"
E eu clico em Salvar
Então devo ver a mensagem Email já cadastrado

Cenario: Tentar alterar email utilizando um email inválido
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "dentista01@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E altero o Email para "dentista@teste.c"
Então devo ver a mensagem E-mail inválido
E eu nao devo ver o botao Salvar 

Cenario: Alterar senha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "dentista01@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu clico em Alterar senha
E preencho o campo senha com a nova senha "abc@123"
E preencho o campo Repetir Senha com a nova senha "abc@123"
E eu clico em Cadastrar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando eu clico em Alterar senha
E preencho o campo senha com a nova senha "123456"
E preencho o campo Repetir Senha com a nova senha "123456"
E eu clico em Cadastrar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Tentar alterar senha, utilizando uma senha com menos de seis caracteres
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu clico em Alterar senha
E preencho o campo senha com a nova senha "abc@"
E preencho o campo Repetir Senha com a nova senha "abc@"
E eu clico em Cadastrar
Então devo ver a mensagem Senha inválida

Cenario: Tentar alterar senha, utilizando a senha de confirmacao diferente
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu clico em Alterar senha
E preencho o campo senha com a nova senha "abc@123"
E preencho o campo Repetir Senha com a nova senha "abc@321"
E eu clico em Cadastrar
Então devo ver a mensagem de erro "Os Passwords digitados estão diferentes."

Cenario: Alterar especialidades para usuário perfil médico ou dentista
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico01@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Especialidades e Interesses
E eu escolho a Especialidade primária "Acupuntura"
E eu escolho a Especialidade secundária "Cardiologia"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando eu escolho a Especialidade primária "Angiologia"
E eu escolho a Especialidade secundária "Cirurgia geral"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Adicionar Interesse e Especialidade 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Criar Conta
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E marco a opcao Li e concordo com os Termos e Condições.
E eu clico em Continuar
Quando Eu preencho o campo Nome com "Dentista"
E preencho o campo Sobrenome com "Automacao"
E eu preencho o Celular com "79987165507"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
Entao devo ver a mensagem de conta criada com sucesso "Sua conta foi criada com sucesso!"
Quando clico em Personalizar
Então devo ser direcionado para pagina de Perfil 
Quando eu clico em Especialidades e Interesses
Então devo ver a Mensagem "Finalize a personalização da sua conta. Selecione uma especialidade primária e selecione um ou mais interesses."
Quando eu escolho a Especialidade primária "Endodontia"
E eu escolho a Especialidade secundária "Pediatria"
E seleciono em interesses "Amostras de Medicamentos"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"


Cenario: Alterar interesses para usuário com perfil farmaceutico
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "maria@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico Interesses
E seleciono em interesses "Artigos Científicos"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"
Quando seleciono em interesses "Artigos Científicos"
E seleciono em interesses "Aulas Médicas"
E eu clico em Salvar
Então devo visualizar a mensagem "Dados alterados com sucesso"

#implementar seleção pelo Dropdown  (Cidade inválida pelo input Text)
#Cenario: Alterar Cidade e Empresa onde trabalha
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando Eu escolho o login por email
#E preencho o campo Email com "farmaceutico01@teste.com"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Dado eu clico no menu profile Logado para expandir
#E eu clico em Meu Perfil
#Então devo ser direcionado para pagina de Perfil
#Quando eu clico em Minha conta 
#E seleciono "Indiana" em Empresa onde trabalha
#E preencho a cidade com "Cabixi - RO"
#E eu clico em Salvar
#Então devo visualizar a mensagem "Dados alterados com sucesso"
#Quando seleciono "Moderna" em Empresa onde trabalha
#E preencho a cidade com "Cacoal - RO"
#E eu clico em Salvar
#Então devo visualizar a mensagem "Dados alterados com sucesso"

Cenario: Selecionar "Não se Aplica" em Empresa onde trabalha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "farmaceutico01@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E seleciono "Não Se Aplica" em Empresa onde trabalha
Então eu não devo ver o campo Cidade

#implementar seleção pelo Dropdown  (Cidade inválida pelo input Text)
#Cenario: Selecionar "Outra" em Empresa onde trabalha
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando Eu escolho o login por email
#E preencho o campo Email com "farmaceutico01@teste.com"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Dado eu clico no menu profile Logado para expandir
#E eu clico em Meu Perfil
#Então devo ser direcionado para pagina de Perfil
#Quando eu clico em Minha conta 
#E seleciono "Outra" em Empresa onde trabalha
#E preencho o campo Nome do local onde trabalha com "Aracaju"
#E preencho a cidade com "Cabixi"
#E eu clico em Salvar
#Então devo visualizar a mensagem "Dados alterados com sucesso"

#Aguardando correção do Bug 1040 para testar. Ou implementar seleção pelo Dropdown
#Cenario: Validar a obrigatoriedade dos campos Cidade e Nome do local onde trabalha
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando Eu escolho o login por email
#E preencho o campo Email com "farma04@teste.com"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Dado eu clico no menu profile Logado para expandir
#E eu clico em Meu Perfil
#Então devo ser direcionado para pagina de Perfil
#Quando eu clico em Minha conta 
#E seleciono "Outra" em Empresa onde trabalha
##E eu clico em Salvar
##Então devo ver a mensagem de cidade obrigatória "Cidade inválida"
##Quando seleciono a cidade "Alta"  // Dropdown
#Quando preencho a cidade com "Cacoal - RO"
#E eu clico em Salvar
#Então devo ver a mensagem de Local obrigatório "Local inválido"


Cenario: Validar a obrigatoriedade do campo Empresa onde trabalha
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "farma03@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Dado eu clico no menu profile Logado para expandir
E eu clico em Meu Perfil
Então devo ser direcionado para pagina de Perfil
Quando eu clico em Minha conta 
E eu altero o Celular para "(71) 9871-6550"
E eu clico em Salvar
Então devo ver a mensagem de campo obrigatorio "Selecione a empresa onde trabalha"


#Cenario: Validar conteúdo das listas: Empresa e Cidade?
#Cenario: Cadastrar para receber amostras
#Cenario: Descadastrar de receber amostras
 

