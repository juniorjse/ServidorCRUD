dotnet run

Se você está recebendo um erro 404 ao tentar acessar `http://localhost:5144/`, isso significa que o servidor está rodando, mas a URL específica que você está tentando acessar não está mapeada para nenhum endpoint na sua aplicação. Isso é esperado se você tentar acessar a raiz (`/`) da sua aplicação sem ter configurado uma rota para ela. Com base no controlador `ProdutosController` que foi criado anteriormente, as rotas definidas são para `/api/produtos`.

Aqui estão algumas etapas que você pode seguir para tentar acessar sua API:

### Verifique as Rotas

Com base no controlador `ProdutosController`, as rotas disponíveis seriam algo como:

- Para **obter todos os produtos**: `GET http://localhost:5144/api/produtos`
- Para **adicionar um novo produto**: `POST http://localhost:5144/api/produtos`
- Para **atualizar um produto**: `PUT http://localhost:5144/api/produtos/{id}`
- Para **deletar um produto**: `DELETE http://localhost:5144/api/produtos/{id}`

### Testando as Rotas

Você pode testar essas rotas usando ferramentas como Postman ou cURL. Aqui está como você pode fazer isso com cURL:

- **GET (Buscar Produtos)**:
  ```bash
  curl http://localhost:5144/api/produtos
  ```

- **POST (Adicionar Produto)**:
  ```bash
  curl -X POST http://localhost:5144/api/produtos -H "Content-Type: application/json" -d '{"nome":"Produto Teste", "preco": 99.99}'
  ```
  Certifique-se de substituir `"nome"` e `"preco"` pelos valores desejados.

- **PUT (Atualizar Produto)**:
  ```bash
  curl -X PUT http://localhost:5144/api/produtos/1 -H "Content-Type: application/json" -d '{"id":1, "nome":"Produto Atualizado", "preco": 199.99}'
  ```
  Substitua `1` pelo ID do produto que deseja atualizar.

- **DELETE (Deletar Produto)**:
  ```bash
  curl -X DELETE http://localhost:5144/api/produtos/1
  ```
  Substitua `1` pelo ID do produto que deseja deletar.

### Verificando a Configuração

Se mesmo seguindo essas etapas você não conseguir acessar as rotas, verifique novamente o código do seu controlador para garantir que tudo esteja configurado corretamente. Verifique especialmente as anotações `[HttpGet]`, `[HttpPost]`, `[HttpPut]` e `[HttpDelete]`, assim como os parâmetros das rotas.

### Swagger

Outra maneira de testar facilmente suas rotas é configurando o Swagger na sua aplicação. O Swagger gera uma interface de usuário web para documentar e testar as APIs RESTful. Se você seguiu o exemplo de código fornecido anteriormente, o Swagger já deve estar configurado. Você pode acessá-lo navegando para `http://localhost:5144/swagger`.

Se o Swagger não estiver configurado, você pode adicionar o pacote NuGet `Swashbuckle.AspNetCore` ao seu projeto e atualizar o método `ConfigureServices` e `Configure` no arquivo `Startup.cs` conforme necessário, seguindo a documentação oficial do Swashbuckle.

Lembre-se de que as portas e os endpoints exatos podem variar dependendo da configuração do seu projeto e da maneira como você definiu suas rotas.