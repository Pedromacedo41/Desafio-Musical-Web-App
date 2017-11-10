# Web-App-Desafio-Musical-To-Publish

Web App de organizacao basica de bilblioteca de midia usando banco de dados local LocalDB criada com Visual Studio
O banco de dados sql foi posteriormente  foi migrado para o servico em nuvem da Microsoft Azure

A pagina home da aplicacao apresenta as funcionalidades do aplicativo web  e os redirecionamentos principais do site!

## Sumario da aplicacao MVC

  ### Models Sets: 
  
   -Media: Contem a classe que define as colunas do banco de dados e contexto (usando EF) 
 
  ### Views Sets:
  
   -Home/About/Create/Index - usando o layout basico e seu renderBody
   -Context/Nominal - usando o segundo layout com os campos de pesquisa e seus metodos get definos nas views em campos Rebder Section
   
  ### Controller Sets:
 
   -Media Controller: tem todos os metodos dos views e dos formularios de Context/Nominal -camps de pesquisa, alem dos de edicao, criacao
   -Home Controller: Controla as paginas principal de informacoes (Home/About/Contact)
   
## Status Atual : 
   
   -Fora do ar
