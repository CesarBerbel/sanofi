#language: pt-BR
Funcionalidade:  Produtos
                 Como usuario do sistema
				 Preciso ter acesso aos Produtos
				 Para obter as informacoes que eu preciso

Cenario: Visualizar Produtos pela Categoria e Substância, autenticado no sistema
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Produtos
Então eu devo ser direcionado para página de Produtos
Quando eu clico no produto "aixa"
E eu clico na categoria "contraceptivos"
Então eu devo ser direcionado para página de Contraceptivos
Quando eu clico no produto "aixa"
Então eu devo ser direcionado para página de detalhes do produto "aixa"
Quando eu clico na Substância "Etinilestradiol"
Então eu devo ser direcionado para página de Tags Substancias "Etinilestradiol"
Quando eu clico no produto dentro da substancia "Aixa"
Então eu devo ser direcionado para página de detalhes do produto "Aixa"

#Cenario: Tentar visualizar Produtos, sem estar autenticado no sistema
#Dado que eu acesse o sistema
#Quando eu clico em Produtos deslogado
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico no produto "aixa"
#Entao eu devo ser direcionado para página de acesso exclusivo
#Quando eu clico em Nao
#E eu clico em Prosseguir
#Então eu devo ser direcionado para Home deslogada

Cenario: Compartilhar Produtos nas redes sociais e Copiar Link
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico em Produtos
Então eu devo ser direcionado para página de Produtos
Quando eu clico no produto "aixa"
Então eu devo ser direcionado para página de detalhes do produto "aixa"
Quando eu clico em Compartilhar Produtos
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"



#Cenario: Adicionar e Retirar Produtos dos favoritos
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico no produto "aixa"
#Então eu devo ser direcionado para página de detalhes do produto "aixa"
#Quando eu clico em Favoritos do Produto
#Entao devo ver a mensagem de salvamento "Produto adicionado à sua área pessoal"
#Dado eu clico no menu profile para expandir
#Quando eu clico em Itens Salvos
#Então eu devo ser direcionado para página de Favoritos
#Quando eu clico em Remover item dos favoritos
#Entao devo ver a mensagem de salvamento "Item removido da sua área pessoal"
#
#
#
#Cenario: Fazer download das Bulas do Profissional e do Paciente
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico no produto "Bi-Profenid®"
#Então eu devo ser direcionado para página de detalhes do produto "Bi-Profenid®"
#Quando eu clico em Compartilhar Evento
#Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

#Cenario: Pesquisar Produtos utilizando o filtro "Ver todos" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Ver todos", "Apenas genérico" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Apenas genérico
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Genéricos e Pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Isento de prescrição
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Isentos de prescrição
#
#Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição" e "Apenas genérico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Isento de prescrição
#E eu clico em Apenas genérico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Isentos de prescrição e Genéricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Isento de prescrição
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Isentos de prescrição e pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição", "Apenas genérico" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Isento de prescrição
#E eu clico em Apenas genérico
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Isentos de prescrição, genéricos e pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja vermelha
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja vermelha
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha" e "Apenas genérico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja vermelha
#E eu clico em Apenas genérico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja vermelha e genéricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja vermelha
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja vermelha e pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha", "Apenas genérico" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja vermelha
#E eu clico em Apenas genérico
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja vermelha, genéricos e pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja preta
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja preta
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta" e "Apenas genérico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja preta
#E eu clico em Apenas genérico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja preta e genéricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja preta
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja preta e pediátricos
#
#Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta" e "Apenas genérico" e "Apenas pediátrico"
#Dado que eu acesse o sistema
#E eu clico no menu profile para expandir
#E clico em Entrar
#Quando escolho o Estado "SC"
#E preencho o campo Número do registro com "11655"
#E preencho o campo Senha com "123456"
#E clico em Logar
#Então eu devo ser direcionado para página de boas vindas
#Quando eu clico em Produtos
#Então eu devo ser direcionado para página de Produtos
#Quando eu clico em Filtro
#Então o modal Filtrar se expande com o filtro "Ver todos" já selecionado
#Quando eu clico em Tarja preta
#E eu clico em Apenas genérico
#E eu clico em Apenas pediátrico
#E eu clico em Aplicar filtros
#Então eu devo visualizar a lista dos Produtos Tarja preta, genéricos e pediátricos