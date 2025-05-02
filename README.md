# MarkdownNotesApp

Aplicativo simples de anotações em .NET 6 que permite aos usuários carregar arquivos Markdown, verificar a gramática, salvar anotações e renderizá-las em HTML via API RESTful.

---

## Funcionalidades

- Upload e manipulação de texto Markdown via API.
- Verificação gramatical do texto enviado.
- Salvamento de anotações (Markdown) com conversão automática para HTML.
- Listagem das notas salvas.
- Recuperação da versão HTML da nota por ID.

---

## Tecnologias Utilizadas

- .NET 6 (ASP.NET Core Web API)
- Markdig (para renderização de Markdown para HTML)
- Insomnia/Postman para testes da API
- Swagger/OpenAPI para documentação dos endpoints

---

## Estrutura do Projeto
MarkdownNotesApp/
│
├── Controllers/
│   └── NotesController.cs
│
├── Models/
│   └── TextDto.cs
│   └── Note.cs
│
├── Program.cs
└── MarkdownNotesApp.csproj

![image](https://github.com/user-attachments/assets/544e0cc6-91f6-4be3-b90b-04be5098c871)


---

## Como Executar

1. Clone o repositório.

2. No terminal, navegue até a pasta do projeto:

```bash
cd MarkdownNotesApp


Execute o projeto
bash
Run
Copy code
dotnet run
Acesse a API Swagger para documentação e testes rápidos:
Run
Copy code
https://localhost:7081/swagger/index.html
Endpoints Principais
POST /api/notes/check-grammar
Verifica a gramática do texto recebido.

Body JSON exemplo:

json
Run
Copy code
{
  "text": "Texto para verificação gramatical."
}
Retorna uma lista de mensagens de erros gramaticais (ou lista vazia).

POST /api/notes/save
Salva uma nota com título e conteúdo Markdown. Retorna a nota salva com Id e versão HTML.

Body JSON exemplo:

json
Run
Copy code
{
  "title": "Minha Nota",
  "content": "# Cabeçalho\n Este é um texto em Markdown."
}
GET /api/notes/list
Retorna a lista de todas as notas salvas.

GET /api/notes/{id}
Retorna a versão HTML da nota com id informado.

Testando com Insomnia ou Postman
Utilize o endereço https://localhost:7081
Para requisições POST, envie o Content-Type: application/json
Desabilite a verificação SSL em ferramentas caso use certificado autoassinado localmente.
Possíveis Melhorias Futuras
Implementação real da verificação gramatical usando API externa.
Persistência das notas em banco de dados.
Interface web para facilitar o uso.
Autenticação e controle de usuários.
Contato
Para dúvidas ou melhorias, abra uma issue ou contribua com pull requests.

Autor
Projeto criado por Romeu Garcia.






