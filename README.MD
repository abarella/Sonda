# SONDA - MONITORA��O

Este projeto tem o objetivo de elaborar as documenta��es de notas fiscais, iatas, guias e etc. quando o produto passa na esteira e faz a leitura do codigo de barras e a atividade radioativa (geiger) de cada produto da linha.

## ?? Tecnologias

Este projeto foi desenvolvido com as seguintes tecnologias:

- [.NET 8](https://dotnet.microsoft.com/)
- [ASP.NET Core](https://learn.microsoft.com/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/ef/core)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Swagger / Swashbuckle](https://swagger.io/)

## ?? Pr�-requisitos

Antes de come�ar, certifique-se de ter instalado:

- [.NET SDK 8.0 ou superior](https://dotnet.microsoft.com/download)
- [SQL Server ou outro banco de dados compat�vel](https://www.microsoft.com/sql-server)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## ?? Como executar

1. Clone o reposit�rio:
```bash
git clone https://github.com/seu-usuario/NomeDoProjeto.git
Navegue at� a pasta do projeto:

cd NomeDoProjeto
Restaure os pacotes:

dotnet restore
Atualize o banco de dados (caso use EF Core):

dotnet ef database update
Execute a aplica��o:

dotnet run
A API estar� dispon�vel em: https://localhost:5001 ou http://localhost:5000

?? Testes
Para rodar os testes unit�rios:

dotnet test
?? Estrutura do Projeto
NomeDoProjeto/
?
??? Controllers/       # Controllers da API
??? Models/            # Modelos de dados
??? Data/              # Contexto do banco de dados
??? Services/          # Regras de neg�cio
??? DTOs/              # Objetos de transfer�ncia de dados
??? Program.cs         # Ponto de entrada da aplica��o
??? appsettings.json   # Configura��es do projeto
?? Licen�a
Este projeto est� sob a licen�a MIT. Veja o arquivo LICENSE para mais detalhes.

?? Autor
Desenvolvido por Alberto Barella Jr.



