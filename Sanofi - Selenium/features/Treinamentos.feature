#language: pt-BR
Funcionalidade: Treinamentos
	            Como usuario do sistema
				Preciso ter acesso aos Treinamentos
				Para assistir os cursos


#Cenario: Realizar Treinamento
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando Eu escolho o login por email
#E preencho o campo Email com "medico@servidor.com"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Dado eu clico no menu profile Logado para expandir
#Quando eu clico em Treinamentos
#Então eu devo ser direcionado para página de treinamentos
#Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/automation/automation-test-crm"
#E clico em Abrir Módulo "UM"
#E clico no Menu PDF
#E clico para baixar pdf
#Então o sistema realiza o download
#Então eu devo ver a mensagem "Sucesso! Você concluiu o curso"



Cenario: Realizar Treinamento com softLogin
Dado que eu acesse o sistema
Quando eu acesso o artigo "https://stg-cd.sanoficonecta.com.br/artigos/Hipotireoidismo-e-riscos-associados-modulo-III-dislipidemia"
Entao devo ver a mensagem "Conteúdo exclusivo para Médico"
Quando eu clico em SIM
E eu clico em Prosseguir
Entao eu devo ser direcionado para página de validacao 
Quando escolho tipo de HCP "Farmacêutico (CRF)"
E escolho o Estado "CE"
E preencho o campo do registro com "19861"
E preencho o Email com "farma_ce@teste.com"
E marco a opcao Li e concordo com os Termos e Condições.
E clico em Finalizar Validacao
Entao devo ver a mensagem do artigo "Olá,Esse conteúdo é exclusivo para Médico."
Quando Eu clico para voltar pra Home
E eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/crf/farmaceuticos"
Entao eu devo ser direcionado para Home deslogada

Cenario: Responder Pesquisa de Satisfação
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Treinamentos
Então eu devo ser direcionado para página de treinamentos
Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/crm/t2i-leaders"
E respondo "1" na questao "1" 
E respondo "2" na questao "2"
E respondo "3" na questao "3"
E respondo "4" na questao "4"
E clico em Proximo
E respondo "1" na questao "1"  
E respondo "2" na questao "2"
E clico em Proximo
E respondo "1" na questao "1" 
E respondo "2" na questao "2"
E clico em Enviar
Entao eu devo ver a mensagem: "Respostas enviadas! Obrigado!"

Cenario: Responder Quiz 
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "testemedico@grr.la"
E preencho o campo Senha com "123456"
E clico em Logar
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Treinamentos
Então eu devo ser direcionado para página de treinamentos
Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/crm/t2i-leaders"
E clico em Abrir Módulo "3 Comunicação Eficiente"
E respondo "3" na pergunta "1" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "1" na pergunta "2" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "3" na pergunta "3" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "1" na pergunta "4" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "4" na pergunta "5" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
Então devo ver a mensagem: "Você completou o Módulo 3. Comunicação Eficiente"

Cenario: Fazer download do Certificado
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico01@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Treinamentos
Então eu devo ser direcionado para página de treinamentos
Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/crf/farmaceuticos"
E clico em Fazer download do Certificado
Então eu devo visualizar o certificado em outra janela

Cenario: Adicionar e Retirar Treinamentos dos favoritos
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico@servidor.com"
E preencho o campo Senha com "123456"
E clico em Logar
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Treinamentos
Então eu devo ser direcionado para página de treinamentos
Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/crm/asma"
E eu clico em Favoritos
Entao devo ver a mensagem de salvamento "Treinamento adicionado à sua área pessoal" 
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Então devo ver a mensagem de salvamento "Item removido da sua área pessoal"

Cenario: Compartilhar Treinamentos nas redes sociais e Copiar link
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "medico@servidor.com"
E preencho o campo Senha com "123456"
E clico em Logar
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Treinamentos
E eu clico em Compartilhar treinamento
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"


