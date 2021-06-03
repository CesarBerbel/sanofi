#language: pt-BR
Funcionalidade: Treinamentos
	            Como usuario do sistema
				Preciso ter acesso aos Treinamentos
				Para assistir os cursos


Cenario: Realizar Treinamento
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
E eu preencho o Celular com "7912345678"
E preencho o campo Adicionar Senha com "123456"
E preencho o campo Repetir Senha com "123456"
E clico em Finalizar
E eu clico em Deixar para depois
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Treinamentos
E eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/automation/automation-test-crm"
E clico em Abrir Módulo
E clico para baixar pdf
Então o conteúdo é marcado como concluído
Quando respondo "3" na pergunta "1" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
E respondo "1" na pergunta "2" 
E Clico em Enviar resposta
Entao eu devo ver a mensagem de sucesso "Resposta Certa"
Quando eu clico em Proxima pergunta
Então devo ver a mensagem: "Você completou o Módulo Aula 01"
Quando eu clico em fechar
Então devo ver a mensagem de conclusão de curso "Sucesso! Você concluiu o curso. Faça o download do seu certificado no topo da página."

Cenario: Realizar Treinamento com perfil sem permissão
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando Eu escolho o login por email
E preencho o campo Email com "farmaceutico01@teste.com"
E preencho o campo Senha com "123456"
E clico em Logar
Dado eu clico no menu profile Logado para expandir
Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/automation/automation-test-crm"
Entao devo ver a mensagem de conteúdo exclusivo "Olá Farmaceutico, Esse conteúdo é exclusivo para Médico e Dentista."


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
Quando eu acesso o Treinamento "https://stg-cd.sanoficonecta.com.br/treinamentos/automation/automation-test-crm"
E respondo "1" na questao "1" 
E respondo "2" na questao "2"
E respondo "3" na questao "3"
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