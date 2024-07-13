# API (Camada) KnightsChallenge: .NET8 + Redis + MongoDB
Repositório do API (Camada) para o teste técnico, que tratará as regras de negócio

### Pré-requisitos

* [Docker](https://www.docker.com/products/docker-desktop/)

## Começando

* Clonar o repositório
* Na raiz do repositorio, executar docker-compose up -d

## Lista de EndPoints

[GET] /Knights - Lista todos os knights 

[GET] /Knights/{id} - Lista apenas 1 knight de acordo com o id

[GET] /Knights/filter={filter} - Lista os herois quando setado o filter=heros  

[POST] /Knights/ - Insere um novo knight

[DEL] /Knights/{id} - Remove um knight e insere na lista de Heros de acordo com o id

[PUT] /Knights/{id} - Edita o apelido de um knight de acordo com o id

## Construído com

* [.NET8] [Redis] [MongoDB]