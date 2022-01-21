# Gerenciador de Cinema
Este projeto é uma parte de um gerenciador de um cinema, nele você pode criar, editar, remover e listar filmes, e criar e remover sessões.

# Como configurar
Este projeto foi feito com SQL Server, então para configurar, é preciso ir ao AppSettings.json que está na pasta GerenciadorDeCinema.Api, e mudar a connection string para a que deseja usar, as variáveis de ambiente que controlam as URL's estão no App.config na pasta do GerenciadorDeCinema.Apresentação.
As credênciais para entrar no sistema são:
 - Usuário: admin@cinema.com
 - Senha: admin43

# Divisão
O projeto foi dividido em camadas, sendo elas:
 - Apresentação
 - API
 - Domínio
 - Infraestrutura
 - Aplicação

O projeto tem uma API, e na API foi desenvolvido 3 controladores, sendo eles:
- FilmeController
- SessaoController
- SalaController

Funcionalidades:
- Na aba salas, você obtêm todas as salas
- Na aba filmes, você obtêm todos os filmes, e tem botões para criar, editar e remover filmes
- Na aba sessões, você obtêm todas as sessões, e tem botões para criar e remover sessões

# Tecnologias
As tecnologias usadas foram:
 - ASP.NET Core C#: Para desenvolvimento da API
 - FluentValidation: Para fazer as validações
 - WindowsForms: Para fazer as telas
 - HttpClient: Para fazer a comunicação com a API
 - XUnit: Para fazer os testes de unidade
