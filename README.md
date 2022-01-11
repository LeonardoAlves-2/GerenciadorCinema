# GerenciadorCinema
Este projeto é uma parte de um gerenciador de um cinema, ele possue algumas operações básicas como criar, listar, editar e deletar filmes, salas e também sessões.

# Como configurar
Este projeto foi feito com SQL Server, então para configurar, é preciso ir ao AppSettings.json que está na pasta GerenciadorDeCinema.Api, e mudar a connection string para a que deseja usar.

# Divisão
O projeto foi dividido em camadas, sendo elas:
 - API
 - Domínio
 - Infraestrutura
 - Aplicação

O projeto tem uma API, e na API foi desenvolvido 3 controladores, sendo eles:

- FilmeController
- SessaoController
- SalaController

Funcionalidades:
 - Adicionar
 - Listar
 - Editar (A sala não possui essa funcionalidade)
 - Deletar

# Tecnologias
As tecnologias usadas foram:
 - ASP.NET Core C#: Para desenvolvimento da API
 - FluentValidation: Para fazer as validações
