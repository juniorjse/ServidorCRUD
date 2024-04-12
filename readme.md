# HTTP Versions Study Server

Este repositório contém um servidor desenvolvido em C#, projetado para facilitar o estudo e a compreensão das diferentes versões do protocolo HTTP - desde o HTTP/1.1 até o HTTP/3.0. O objetivo é fornecer uma aplicação prática onde os usuários podem experimentar as características e diferenças entre cada versão do protocolo HTTP.

## Pré-requisitos

Para executar e trabalhar com este servidor, você precisará ter instalado em seu sistema:

- .NET 6.0 SDK (ou superior)
- Um editor de código de sua escolha (Recomendado: Visual Studio Code ou Visual Studio)

## Configuração do Ambiente

1. Clone o repositório para sua máquina local usando:
  `git clone https://github.com/juniorjse/ServidorCRUD`

3. Compile o projeto para garantir que todas as dependências estejam corretamente instaladas:
  `dotnet build`


## Executando o Servidor

Para iniciar o servidor, execute o seguinte comando no diretório do projeto:
  `dotnet run`


O servidor será iniciado, e você poderá acessar as diferentes rotas através do endereço `http://localhost:5000` (ou a porta configurada).

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- `Controllers/` - Contém os controladores que gerenciam as requisições HTTP para cada versão do protocolo.
- `Models/` - Define os modelos de dados utilizados pelo servidor.
- `Services/` - Contém a lógica de negócios e serviços auxiliares.

Desenvolvido por Junior (https://github.com/juniorjse)
