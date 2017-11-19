# Desafio-Musical-Web-App

Visual Studio C# Web App with Database integration (SQL Server) to implement a musical librarie using Localdb and after publish through MS Azure Webservers. Nawadays, the site is offline 

The home page presents the web site functionalities and the site menu navigation

## Folders Table of Contents ( MVC pattern)

  ### Models Set: 
  
   Media: Contains the model class wich difines the database columms and set up the context (Using Entity Framework and Code First paradigm)
   
  ### Views Set: (cshtml files, html with .ASP technology)
  
   -Home/About/Create/Index: Primary website layout  + different renderBodys sections (ASP) to each page 
   -Context/Nominal: Secondary layout, Search Fields and get/ post methods imput define on Render Section (ASP)
   
  ### Controllers Set:
 
   -Media Controller: Contains the methods get, update, post implementation of the forms of some views. 
   -Home Controller: Controller for the static pages (Home/About/Contact)
   

# _Nowadays Status:_ 
   
   -Offline. However, the website can be imported to VS enviroment and has its SGBD setted through the edition the context settings lines on the configurating file web.config
