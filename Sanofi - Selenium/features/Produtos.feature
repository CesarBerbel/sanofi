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
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Contraceptivos"
Então eu devo ser direcionado para página de "contraceptivos"
Quando eu clico no produto "aixa"
Então eu devo ser direcionado para página de "aixa"
Quando eu clico na categoria "contraceptivos"
Então eu devo ser direcionado para página de "contraceptivos"
Quando eu clico no produto "aixa"
Então eu devo ser direcionado para página de "aixa"
Quando eu clico na Substância "Etinilestradiol"
Então eu devo ser direcionado para página de Tags Substancias "Etinilestradiol"
Quando eu clico no produto dentro da substancia "Aixa"
Então eu devo ser direcionado para página de "Aixa"

Cenario: tentar visualizar produtos, sem estar autenticado no sistema
Dado que eu acesse o sistema
Então eu não devo visualizar o menu Produtos

Cenario: Compartilhar Produtos nas redes sociais e Copiar Link
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Contraceptivos"
Então eu devo ser direcionado para página de "contraceptivos"
Quando eu clico no produto "aixa"
Então eu devo ser direcionado para página de "aixa"
Quando eu clico em Compartilhar
Entao devo ver os links "Whatsapp,Facebook,LinkedIn,Copiar link"

Cenario: Adicionar e Retirar Produtos dos favoritos
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Contraceptivos"
Então eu devo ser direcionado para página de "contraceptivos"
Quando eu clico no produto "aixa"
Então eu devo ser direcionado para página de "aixa"
Quando eu clico em Favoritos
Entao devo ver a mensagem de salvamento "Produto adicionado à sua área pessoal"
Dado eu clico no menu profile Logado para expandir
Quando eu clico em Itens Salvos
Então eu devo ser direcionado para página de Favoritos
Quando eu clico em Remover item dos favoritos
Entao devo ver a mensagem de salvamento "Item removido da sua área pessoal"

Cenario: Fazer download das Bulas do Profissional e do Paciente
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Alergia"
Então eu devo ser direcionado para página de "alergia"
Quando eu clico no produto "allegra"
Então eu devo ser direcionado para página de "allegra"
Quando eu clico em baixar "Bula do profissional"
Então eu devo visualizar o arquivo ".ashx" em outra janela
Quando eu clico em baixar "Bula do paciente"
Então eu devo visualizar o arquivo ".ashx" em outra janela
Quando eu clico no ícone da bula
E eu clico em fazer download da "Bula do paciente pediatrico" 
Então eu devo visualizar o arquivo ".ashx" em outra janela
Quando eu clico em fazer download da "Bula do profissional pediatrico" 
Então eu devo visualizar o arquivo ".ashx" em outra janela

Cenario: Pesquisar Produtos utilizando o filtro "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Alergia"
Então eu devo ser direcionado para página de "alergia"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Allegra®,Allegra® D"

Cenario: Pesquisar Produtos utilizando o filtro "Apenas genérico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Sintético"
Então eu devo ser direcionado para página de "sintetico"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Apenas genérico"  
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Teriflunomida"

Cenario: Pesquisar Produtos utilizando o filtro "Apenas genérico" e "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Apenas genérico"  
Quando eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Ácido fólico,Amido,Aprazolam"

Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Alergia"
Então eu devo ser direcionado para página de "alergia"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Isento de prescrição"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Allegra®"

Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição" e "Apenas genérico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Isento de prescrição"    
Quando eu clico no filtro "Apenas genérico"  
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Acácia,Ácido fólico"

Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição" e "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Alergia"
Então eu devo ser direcionado para página de "alergia"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Isento de prescrição"    
Quando eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Allegra®"

Cenario: Pesquisar Produtos utilizando o filtro "Isento de prescrição", "Apenas genérico" e "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Isento de prescrição"    
Quando eu clico no filtro "Apenas genérico"  
Quando eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Ácido fólico"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Disturbios do Sono"
Então eu devo ser direcionado para página de "disturbios-do-sono"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja vermelha"
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Stilnox®"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha" e "Apenas genérico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Outros"
Então eu devo ser direcionado para página de "outros"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja vermelha"
Quando eu clico no filtro "Apenas genérico"  
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Alfatirotropina"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha" e "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Alergia"
Então eu devo ser direcionado para página de "alergia"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja vermelha"
Quando eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Allegra® D"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja vermelha", "Apenas genérico" e "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja vermelha"
Quando eu clico no filtro "Apenas genérico"  
Quando eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Aprazolam"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Disturbios do Sono"
Então eu devo ser direcionado para página de "disturbios-do-sono"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja preta"
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Stilnox® CR"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta" e "Apenas genérico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC" 
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja preta"
Quando eu clico no filtro "Apenas genérico"  
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Alentuzumabe,Amido"

Cenario: Pesquisar Produtos utilizando o filtro "Tarja preta" e "Apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja preta"
E eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Amido,Tarja Preta Pediátrico"

Cenario: pesquisar produtos utilizando o filtro "tarja preta" e "apenas genérico" e "apenas pediátrico"
Dado que eu acesse o sistema
E eu clico no menu profile para expandir
E clico em Entrar
Quando escolho o Estado "SC"
E preencho o campo Número do registro com "11655"
E preencho o campo Senha com "123456"
E clico em Logar
Então eu devo ser direcionado para página de boas vindas
Quando eu clico no Menu "Produtos"
Então eu devo ser direcionado para página de Produtos
Quando eu clico em Categorias "Testes Automatizados"
Então eu devo ser direcionado para página de "testes-automatizados"
Quando eu clico em Filtro
Então o modal Filtrar se expande 
Quando eu clico no filtro "Tarja preta"
E eu clico no filtro "Apenas genérico"  
E eu clico no filtro "Apenas pediátrico"    
E eu clico em Aplicar filtros
Então eu devo visualizar os Produtos "Amido"
