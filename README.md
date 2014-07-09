uniTunes
========================

- Aplicação Web criada para a matéria de Arquitetura de Software.

========================
	- Site: unitunes.azurewebsites.net (User admin, pass 123)
========================
	Architecture:
	ASP.NET MVC 5

	Front-end: HTML5, CSS3, Javascript
	Javascript libraries: jQuery
	Design Patterns and Practices: Code-First, Entity Framework, Unit of Work, Repositories, Inversion of Control (StructureMap)
	Others: Windows Azure (Host), Amazon RDS (SGBD: SQL Server), Twitter Bootstrap
========================
	Solution:
	- uniTunes.Common
		- Extensions, Helpers
	- uniTunes.Data
	  	- Data access Layer
		- Configuration, Initializers and Infrastructure.
		- Generic repository and individuals repositories.
	- uniTunes.Models
		- Models, Classes
	- uniTunes.Services.Contracts
		- Services interfaces
	- uniTunes.Services
		- Business logic and rules
	- uniTunes.Tests
		- Unit tests
	- uniTunes.UI
		- Controllers, Views (Front-end)
