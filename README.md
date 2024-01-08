# Teste técnico - nível Júnior

Neste desafio, você será responsável por criar uma API RESTful para uma lista de
empregos. A API permitirá que os usuários visualizem, criem, atualizem e excluam anúncios
de emprego.

## Endpoints
- GET /jobs: retorna uma lista de todos os anúncios de emprego disponíveis;
- GET /jobs/{id}: retorna um único anúncio de emprego com o ID correspondente;
- POST /jobs: cria um novo anúncio de emprego;
- PUT /jobs/{id}: atualiza um anúncio de emprego existente com o ID correspondente;
- DELETE /jobs/{id}: exclui um anúncio de emprego existente com o ID correspondente;

## As entidades e seus atributos
- Job;
	- Id: int (gerado automaticamente pelo servidor);
	- Title: string (título do anúncio de emprego);
	- Description: string (descrição do anúncio de emprego);
	- Location: string (localização do trabalho);
	- Salary: decimal (salário oferecido);

## Requisitos
- [RN1] A API deve ser desenvolvida usando ASP.NET Core;
- [RN2] Deve-se usar o banco de dados InMemory com Entity Framework Core;
- [RN3] Deve suportar as operações CRUD básicas (Create, Read, Update, Delete);
- [RN4] A API deve retornar respostas HTTP apropriadas (ex: 200 OK, 404 Not Found, 400 Bad Request, etc.);
- [RN5] Os dados enviados e recebidos pela API devem ser formatados como JSON;

# Passo a Passo da Resolução

1. Criar as Actions do Controller e testar todas para garantir que estejam funcionando. Retornar NoContent para PUT e DELETE, e OK para todas as outras

2. Implementar entidade do domínio

3. Atualizar Actions do Controller com entidade do domínio (POST e PUT recebendo como parâmetro, e POST retornando CreatedAtAction) - BUILD

4. Adicionar Microsoft.EntityFrameworkCore.InMemory, criar DbContext, e configurar na Program.cs

5. Adicionar instância do DbContext no Controller, e usar ele em todas as operações com a sintaxe LINQ

6. Testar e garantir que funciona em memória.

[OPCIONAL]
7. Adicionar configuração de connection string do Banco de Dados no appsettings.json, atualizar
configuração no Program.cs, e gerar as migrations com:

ˋˋˋcsharp
dotnet ef migrations add Initial -o Persistence/Migrations
dotnet ef database update
ˋˋˋ

8. Testar novamente