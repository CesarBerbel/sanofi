#language: pt-BR
Funcionalidade:Campanhas
               Como usuario do sistema
			   Preciso ter acesso as Campanhas 
			   Para obter as informacoes que eu preciso


Cenario: Acessar campanha exclusiva
Dado que eu acesse a campanha "https://stg-cd.sanoficonecta.com.br/farmaceuticos"
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Médica e Farmacêutica" 
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao
Quando escolho o Estado "SC"
E preencho o campo do registro com "11655"
E preencho o Email com "testemedico@grr.la"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
Entao devo ver a mensagem de sucesso "Olá, identificamos que você já tem uma conta!"
Quando preencho o campo Adicionar Senha com "123456"
E clico em Logar
Entao eu visualizo a campanha "https://stg-cd.sanoficonecta.com.br/farmaceuticos"  

Cenario: Tentar acessar campanha exclusiva, utilizando perfil sem permissão
Dado que eu acesse a campanha "https://stg-cd.sanoficonecta.com.br/farmaceuticos"
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Médica e Farmacêutica" 
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
Entao devo ver a mensagem da campanha "Olá,Esse conteúdo é exclusivo para Médico e Farmacêutico."

Cenario: Tentar acessar campanha exclusiva para outro perfil, a partir do SoftLogin
Dado que eu acesse a campanha "https://stg-cd.sanoficonecta.com.br/campanha/dupilumabe-dermatite-atopica"
Entao devo ver a mensagem "Conteúdo exclusivo para a(s) área(s) Odontológica e Médica" 
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao
Quando escolho tipo de HCP "Dentista (CRO)"
E escolho o Estado "BA"
E preencho o campo Número do registro com registro aleatório
E preencho o Email com email aleatório
E Eu preencho o campo Nome com "Farma"
E preencho o campo Sobrenome com "Four"
E eu preencho o Celular com "71987165507"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
E clico em Deixar para depois
Entao eu visualizo a campanha "https://stg-cd.sanoficonecta.com.br/campanha/dupilumabe-dermatite-atopica"  
Dado que eu retorne para home
Quando eu acesso a campanha "https://stg-cd.sanoficonecta.com.br/farmaceuticos"
Entao devo ver a mensagem da campanha "Olá,Esse conteúdo é exclusivo para Médico e Farmacêutico."

Cenario: Adicionar e Retirar Campanha dos favoritos
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "farma_ce@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então devo ver meu nome "farmaceutico teste" no menu profile
Quando eu acesso a campanha "https://stg-cd.sanoficonecta.com.br/farmaceuticos"
Entao eu visualizo a campanha "https://stg-cd.sanoficonecta.com.br/farmaceuticos"  
Quando eu clico em Favoritos
Entao devo ver a mensagem de salvamento "Campanha adicionada à sua área pessoal" 
Dado eu clico no menu profile para expandir em Campanha
Quando eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Então devo ver a mensagem de salvamento "Item removido da sua área pessoal"

Cenario: Compartilhar Campanha nas redes sociais e Copiar Link 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "farma_ce@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Então devo ver meu nome "farmaceutico teste" no menu profile
Quando eu acesso a campanha "https://stg-cd.sanoficonecta.com.br/campanha/pasteur"
Entao eu visualizo a campanha "https://stg-cd.sanoficonecta.com.br/campanha/pasteur"  
Quando eu clico em Compartilhar 
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

#Cenario: Tentar adicionar Campanha aos favoritos sem estar logado no sistema
#Cenario: Tentar adicionar Campanha aos favoritos com SoftLogin 
