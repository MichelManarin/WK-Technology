# Michel Manarin - Teste Técnico - WK Technology 

[Projeto]
Consiste em uma Web API MVC e Web Application

[UX]
![appTask](https://user-images.githubusercontent.com/6588753/189559453-ce19efea-60e9-4e5e-a406-73c4e8d02c26.png)

[Comandos Utilizados]

	dotnet tool install --global dotnet-ef
	dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
	dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1
	Install-Package Newtonsoft.Json -Version 11.0.0
  
 [MySQL]
	create database apiwk;
	
	Alterar o connectionDatabase conforme seu Uid e Pwd do banco no appsettings.json da Web API MVC
	
	Os objetos do banco serão gerados via migration:
	Ao executar o projeto de API, por favor, rodar o comando para iniciazar o banco:
	dotnet ef database update
	
	Após isso para rodar tanto API como WEB Application com:
	dotnet run
	
[Swagger]
	Com o projeto aberto da API rodando, basta acessar 
	http://localhost:5005/swagger/index.html
	para ter acesso a documentação dos endpoints.
	
[Padrão de projeto utilizado]
	
	Repository

[Critérios de Avaliação]

	1. Utilizar MySQL como banco de dados

	2. Utilizar ASP NET MVC (C#), HTML5, CSS3 e Bootstrap
	
	3. Estruturação de Código e Qualidade de Escrita
	
	4. Uso de Pattern
	
	5. ASP NET Core
	
	6. Micro Serviços
	
	7. Injeção de Dependência – Swagger

	8. UI/UX
	
[Pontos de melhoria]

	Fixei a porta da WEB API na http://localhost:5005 e deixei isso fixo no código, a ideia é passar dentro do appsettings.json

	Falta Paginação

	Deixar no padrão rest...
	
