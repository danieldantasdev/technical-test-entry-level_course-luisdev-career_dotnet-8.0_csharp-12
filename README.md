# Teste t�cnico - n�vel J�nior

Neste desafio, voc� ser� respons�vel por criar uma API RESTful para uma lista de
empregos. A API permitir� que os usu�rios visualizem, criem, atualizem e excluam an�ncios
de emprego.

## Endpoints
- GET /jobs: retorna uma lista de todos os an�ncios de emprego dispon�veis;
- GET /jobs/{id}: retorna um �nico an�ncio de emprego com o ID correspondente;
- POST /jobs: cria um novo an�ncio de emprego;
- PUT /jobs/{id}: atualiza um an�ncio de emprego existente com o ID correspondente;
- DELETE /jobs/{id}: exclui um an�ncio de emprego existente com o ID correspondente;

## As entidades e seus atributos
- Job;
	- Id: int (gerado automaticamente pelo servidor);
	- Title: string (t�tulo do an�ncio de emprego);
	- Description: string (descri��o do an�ncio de emprego);
	- Location: string (localiza��o do trabalho);
	- Salary: decimal (sal�rio oferecido);

## Requisitos
- [RN1] A API deve ser desenvolvida usando ASP.NET Core;
- [RN2] Deve-se usar o banco de dados InMemory com Entity Framework Core;
- [RN3] Deve suportar as opera��es CRUD b�sicas (Create, Read, Update, Delete);
- [RN4] A API deve retornar respostas HTTP apropriadas (ex: 200 OK, 404 Not Found, 400 Bad Request, etc.);
- [RN5] Os dados enviados e recebidos pela API devem ser formatados como JSON;