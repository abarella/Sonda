# SONDA - MONITORAÇÃO

Este projeto tem o objetivo de elaborar as documentações de notas fiscais, iatas, guias e etc. quando o produto passa na esteira e faz a leitura do codigo de barras e a atividade radioativa (geiger) de cada produto da linha.

## 🚀 Tecnologias

Este projeto foi desenvolvido com as seguintes tecnologias:

- [.NET 8](https://dotnet.microsoft.com/)
- [ASP.NET Core](https://learn.microsoft.com/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/ef/core)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Swagger / Swashbuckle](https://swagger.io/)

## 💻 Pré-requisitos

Antes de começar, certifique-se de ter instalado:

- [.NET SDK 8.0 ou superior](https://dotnet.microsoft.com/download)
- [SQL Server ou outro banco de dados compatível](https://www.microsoft.com/sql-server)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## ⚙️ Como executar

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/NomeDoProjeto.git
Navegue até a pasta do projeto:

cd NomeDoProjeto
Restaure os pacotes:

dotnet restore
Atualize o banco de dados (caso use EF Core):

dotnet ef database update
Execute a aplicação:

dotnet run
A API estará disponível em: https://localhost:5001 ou http://localhost:5000

?? Testes
Para rodar os testes unitários:

dotnet test
⭐ Estrutura do Projeto
SONDA/
⭐ 
⭐ Controllers/       # Controllers da API
⭐ Models/            # Modelos de dados
⭐ Data/              # Contexto do banco de dados
⭐ Services/          # Regras de negócio
⭐ DTOs/              # Objetos de transferência de dados
⭐ Program.cs         # Ponto de entrada da aplicação
⭐ appsettings.json   # Configurações do projeto
🤔 Licença
Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

🧠 Autor
Desenvolvido por Alberto Barella Jr.



