# Web-App Desafio Musical (To Publish)

Web App de organizacao basica de bilblioteca de midia usando banco de dados local LocalDB criada com Visual Studio.
O banco de dados SQL foi posteriormente  foi migrado para o servico em nuvem da Microsoft Azure

A pagina home da aplicacao apresenta as funcionalidades do aplicativo web  e os redirecionamentos principais do site!

## Sumario da aplicacao MVC

  ### Models Set: 
  
   Media: Contem a classe que define as colunas do banco de dados e contexto (usando Entitity Framework and Code First) 
 
  ### Views Set:
  
   -Home/About/Create/Index: layout principal + campo renderBody 
   -Context/Nominal: layout secundário, campos de pesquisa e seus metodos get definos nas views em campos Render Section
   
  ### Controller Set:
 
   -Media Controller: Contém todos os metodos dos views e dos formularios de Context/Nominal -camps de pesquisa, alem dos de edicao, criacao
   -Home Controller: Controla as paginas principal de informacoes (Home/About/Contact)
   

_Status Atual da Aplicação:_ 
   
   -Fora do ar
