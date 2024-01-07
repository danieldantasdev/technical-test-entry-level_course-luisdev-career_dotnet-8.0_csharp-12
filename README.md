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