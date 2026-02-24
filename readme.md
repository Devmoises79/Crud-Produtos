# 📒 Agenda de Contatos - API com .NET 10 e SQLite

![.NET Version](https://img.shields.io/badge/.NET-10.0-purple)
![SQLite](https://img.shields.io/badge/SQLite-3-green)
![License](https://img.shields.io/badge/license-MIT-blue)
![Status](https://img.shields.io/badge/status-finalizado-brightgreen)

## 📋 Sobre o Projeto

API RESTful para gerenciamento de produtos/contatos, desenvolvida com ASP.NET Core 10 e SQLite. Este projeto demonstra operações CRUD básicas e serve como exemplo para estudos e implementações futuras.

### ✨ Funcionalidades

- ✅ Listar todos os produtos/contatos
- ✅ Buscar item específico por ID
- ✅ Adicionar novos itens
- ✅ Atualizar itens existentes
- ✅ Remover itens
- ✅ Banco de dados SQLite local
- ✅ Documentação Swagger UI
- ✅ Interface web simples para testes

## 🚀 Tecnologias Utilizadas

- [.NET 10.0](https://dotnet.microsoft.com/download/dotnet/10.0) - Framework principal
- [ASP.NET Core 10](https://dotnet.microsoft.com/apps/aspnet) - API Web
- [Entity Framework Core 10](https://docs.microsoft.com/ef/core/) - ORM para banco de dados
- [SQLite](https://www.sqlite.org/) - Banco de dados leve e local
- [Swagger UI](https://swagger.io/tools/swagger-ui/) - Documentação e testes da API

## 📁 Estrutura do Projeto
AgendaContatos/
├── Controllers/ # Controladores da API
│ └── ProdutosController.cs
├── Data/ # Contexto do banco de dados
│ └── AppDbContext.cs
├── Models/ # Modelos/Entidades
│ └── Produto.cs
├── wwwroot/ # Arquivos estáticos
│ └── index.html # Interface web simples
├── Program.cs # Configuração da aplicação
├── appsettings.json # Configurações do banco de dados
└── AgendaContatos.csproj # Arquivo de projeto

text

## 🏁 Como Executar

### Pré-requisitos

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (Preview)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) 17.12+ ou VS Code
- [Git](https://git-scm.com/) (opcional)

### Passos para execução

1. **Clone o repositório**
```bash
git clone https://github.com/seu-usuario/AgendaContatos.git
```

```bash
cd AgendaContatos
```
Restaure os pacotes NuGet



```bash
dotnet restore
```
Execute a aplicação

```bash
dotnet run
```

Acesse no navegador

```bash
API: http://localhost:5126/api/produtos
```

```bash
Swagger: http://localhost:5126/swagger
```

```bash
Interface Web: http://localhost:5126/index.html
```

# 📦 Modelo de Dados
Produto/Contato
Propriedade	Tipo	Descrição	Exemplo
Id	int	Identificador único	1
Nome	string	Nome do item	"Arroz"
Preco	decimal	Preço/Valor	5.50
Quantidade	int	Quantidade em estoque	100

# 🔌 Endpoints da API


- Listar todos os itens:

```bash
http
GET /api/produtos
Resposta:

json
[
  {
    "id": 1,
    "nome": "Água",
    "preco": 2.5,
    "quantidade": 100
  },
  {
    "id": 2,
    "nome": "Sabão",
    "preco": 1.5,
    "quantidade": 80
  }
]
```

```bash
Buscar item por ID
http
GET /api/produtos/{id}
Exemplo: GET /api/produtos/3

Resposta:

json
{
  "id": 3,
  "nome": "Feijão",
  "preco": 4.0,
  "quantidade": 120
}
```

```bash
Criar novo item
http
POST /api/produtos
Content-Type: application/json

{
  "nome": "Leite",
  "preco": 4.5,
  "quantidade": 60
}
```

```bash
Atualizar item existente
http
PUT /api/produtos/{id}
Content-Type: application/json

{
  "id": 7,
  "nome": "Leite Integral",
  "preco": 5.0,
  "quantidade": 80
}
```

```bash
Remover item
http
DELETE /api/produtos/{id}
```

# 💻 Exemplos de Uso
PowerShell

```powershell
# Listar todos
Invoke-RestMethod -Uri http://localhost:5126/api/produtos

# Adicionar novo
$body = @{
    nome = "Café"
    preco = 8.50
    quantidade = 50
} | ConvertTo-Json

Invoke-RestMethod -Uri http://localhost:5126/api/produtos `
                  -Method Post `
                  -Body $body `
                  -ContentType "application/json"
```

cURL

```bash
# GET todos
curl -X GET "http://localhost:5126/api/produtos"
```

```bash
# POST novo
curl -X POST "http://localhost:5126/api/produtos" \
     -H "Content-Type: application/json" \
     -d '{"nome":"Café","preco":8.50,"quantidade":50}'
JavaScript (Fetch API)
```

```bash
javascript
// Buscar todos
fetch('http://localhost:5126/api/produtos')
    .then(response => response.json())
    .then(data => console.log(data));
```

```bash
// Adicionar novo
fetch('http://localhost:5126/api/produtos', {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({
        nome: 'Café',
        preco: 8.50,
        quantidade: 50
    })
})
    .then(response => response.json())
    .then(data => console.log(data));
```

# ⚙️ Configuração

```bash
Connection String (appsettings.json)
json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=agenda.db"
  }
}
```

```bash
Porta da Aplicação
O projeto está configurado para rodar na porta 5126 por padrão:

HTTP: http://localhost:5126
```


# 📊 Dados de Exemplo
* Ao iniciar, o banco já contém estes dados de exemplo:


```bash
ID	Nome	Preço	Quantidade
1	Água	2.50	100
2	Sabão	1.50	80
3	Feijão	4.00	120
4	Óleo	5.00	100
5	Arroz	5.50	100
6	Carne	17.00	130
```

# 🧪 Testes Realizados
Todos os endpoints foram testados e estão funcionando:

- ✅ GET /api/produtos

- ✅ GET /api/produtos/{id}

- ✅ POST /api/produtos

- ✅ PUT /api/produtos/{id}

- ✅ DELETE /api/produtos/{id}


# 🤝 Contribuindo

Contribuições são bem-vindas! Siga estes passos:

- Faça um fork do projeto

- Crie uma branch (git checkout -b feature/nova-feature)

- Commit suas mudanças (git commit -m 'Adiciona nova feature')

- Push para a branch (git push origin feature/nova-feature)

- Abra um Pull Request

# 📝 Licença
Este projeto está sob a licença MIT. 