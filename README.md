## Challenge Password API - Iti

~**Desafio Proposto**: Desenvolver uma API com o intuito de receber uma senha e realizar a validação da mesma de acordo com requisitos pré definidos. 

## Requisitos da API
 * **Quantidade de Caracteres** - Nove ou mais 
 * **Dígitos** - No mínimo 1
 * **Letra Maiúscula** - No mínimo 1
 * **Letra Minúscula** - No mínimo 1
 * **Caracteres Especiais** - No mínimo 1 (apenas os seguintes: !@#$%^&*()-+)
 * **Espaçamento** - Não permitido
 * **Repetições** - Não permitido

## Requisitos do Sistema
* [**IDE**] - Visual Studio ou Visual Studio Code
* [**SDK**] - .Net Core
* [**Extensão**] - C# Extension (para IDE VsCode)
 
 ## Exemplo para Validação
| Senha | Válido |
|---|---|
| "" | Inválido|
| "aa" | Inválido|
| "ab" | Inválido|
| "AAAbbbCc" | Inválido|
| "AbTp9!foo" | Inválido|
| "AbTp9!foA" | Inválido|
| "AbTp9 fok" | Inválido|
| "AbTp9!fok" | **Válido**|

## Recursos disponíveis da API:
* [**Password/ValidatePassword**]

## Requisições
Requisições para a API devem seguir os padrões:
| HTTP | Descrição |
|---|---|
| `POST` | Utilizado para receber a senha e retorna-la validada. |

## Dados para envio do POST
| Parâmetro | Descrição |
|---|---|
| `password` | Recebe o valor passado pelo usuário |

+ Request (application/json)

    + Body

            {
                "password": "AbTp9!fok",                
            }

+ Response 200 (application/json)


## Retornos
| Status | Descrição |
|---|---|
| `200` | Requisição executada retornando true ou false para a senha.|
| `400` | Requisição não executada, retornando mensagem de erro.|


## Execução da aplicação
Abrir o projeto na IDE (VSCode), acessar a pasta do projeto principal **ChallengePasswordItau** e compilar a solução via comando:

```
dotnet restore
```

Após, executá-lo via comando:

```
dotnet run
```
**Em seguida acessar o endereço http://localhost:**port**/swagger/index.html, para que a API seja aberta via documentação do Swagger **

Para executar os **testes**, acessar a pasta **ChallengePasswordItauTest**, compilar a solução (comando acima) e execute-lo via comando abaixo:
```
dotnet test
```

## API
Esta API pode ser acessada via Postman ou via Swagger (Navegador), conforme exemplos abaixo:

[**Postman:**]

![Postman](https://user-images.githubusercontent.com/28115304/112548966-cfc25980-8d9b-11eb-9fec-87eb4afb69df.JPG)

[**Swagger:**]

![Swagger](https://user-images.githubusercontent.com/28115304/112548986-da7cee80-8d9b-11eb-86e1-4791ae4f9841.jpg)









