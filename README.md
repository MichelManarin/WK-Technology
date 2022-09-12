# Michel Manarin - Teste Técnico - WK Technology 

[Comandos Utilizados]

	dotnet tool install --global dotnet-ef
	dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
	dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.1
	Install-Package Newtonsoft.Json -Version 11.0.0
  
 [MySQL]
	create database apiwk;
	
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
