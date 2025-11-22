# 🌐 TalentMind API  
### Plataforma RESTful para Gestão de Profissionais e Oportunidades — FIAP Global Solution

A **TalentMind API** é um projeto desenvolvido em **C# .NET 8**, estruturado para oferecer um conjunto de endpoints modernos para gerenciamento de **Trabalhadores (Workers)** e **Vagas de Emprego (Jobs)**.  
O foco da solução é apoiar empresas na organização de talentos e oportunidades usando boas práticas de arquitetura e versionamento de APIs.

---

## 👥 Integrante

- Diego Bassalo Canals Silva – RM558710 | Turma 2TDSPG
- Giovanni de Souza Lima – RM556536 | Turma 2TDSPH
- Vitor Tadeu Soares de Sousa – RM559105 | Turma 2TDSPH


## 🚀 Tecnologias e Ferramentas

Este projeto foi desenvolvido com um ecossistema moderno e robusto:

- **.NET 8 (C#)**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server Express (localdb / SQLEXPRESS)**
- **Swagger (OpenAPI)** para inspeção e testes dos endpoints
- **Visual Studio Code**

---

## 📚 Sobre a API

A aplicação possui duas entidades principais:

- **Workers** — representam profissionais cadastrados  
- **Jobs** — representam vagas disponíveis no sistema  

Além disso, a API implementa **versionamento de rotas**, permitindo evolução contínua sem quebrar compatibilidade.

---

## 📌 Funcionalidades Disponíveis

### 🔹 Workers — Versões V1 e V2
A API permite:

- Criar novos trabalhadores  
- Consultar lista de trabalhadores  
- Buscar trabalhador por ID  
- Atualizar dados  
- Remover cadastro  

A versão **V2** adiciona informações avançadas, incluindo o histórico de Jobs associados ao Worker.

---

### 🔹 Jobs — Versão V1
As operações disponíveis são:

- Criar vagas  
- Listar todas as vagas  
- Consultar vaga por ID  
- Atualizar vaga existente  
- Excluir vaga  

---

## 🧭 Mapa de Rotas

### 📍 **Workers — V1**

| Método | Rota | Descrição |
|--------|--------------------------|---------------------------|
| GET    | `/api/v1/Workers`        | Lista trabalhadores        |
| GET    | `/api/v1/Workers/{id}`   | Obtém um trabalhador       |
| POST   | `/api/v1/Workers`        | Cria novo trabalhador      |
| PUT    | `/api/v1/Workers/{id}`   | Atualiza informações       |
| DELETE | `/api/v1/Workers/{id}`   | Remove registro            |

#### 🧪 Exemplo — POST Worker
```json
{
  "name": "Carlos Almeida",
  "email": "carlos@gmail.com",
  "mainSkill": "Python",
  "preferredWorkMode": "Remoto",
  "yearsOfExperience": 5
}
```
## 📍 Workers — V2
Método	Rota	Descrição
GET	/api/v2/Workers	Lista trabalhadores com Jobs
GET	/api/v2/Workers/{id}	Detalha worker + jobs

## 📍 Jobs — V1
Método	Rota	Descrição
GET	/api/v1/Jobs	Lista vagas
GET	/api/v1/Jobs/{id}	Busca vaga
POST	/api/v1/Jobs	Cria vaga
PUT	/api/v1/Jobs/{id}	Atualiza vaga
DELETE	/api/v1/Jobs/{id}	Remove vaga

### 🧪 Exemplo — POST Job
{
  "title": "Analista de Dados",
  "company": "TechFlow",
  "workMode": "Remoto",
  "requiredSkill": "SQL, Power BI",
  "salaryFrom": 3500.00,
  "salaryTo": 7000.00,
  "workerId": null
}

## 🛢 Estrutura do Banco de Dados

O projeto utiliza SQL Server Express e Entity Framework Core, que gerencia migrations e versionamento do schema.

### 🧱 Tabela Workers
Campo	Tipo
Id	int
Name	string
Email	string
MainSkill	string
PreferredWorkMode	string
YearsOfExperience	int

### 🧱 Tabela Jobs
Campo	Tipo
Id	int
Title	string
Company	string
WorkMode	string
RequiredSkill	string
SalaryFrom	decimal
SalaryTo	decimal
WorkerId	int?

## ▶️ Como rodar o projeto
1- Clonar o repositório
```
git clone https://github.com/DGMMX/global-solution.net.git
```

2- Restaurar dependências
```
dotnet restore
```

3- Aplicar migrations
```
dotnet ef database update
```

4 Executar API
```
dotnet run
```

5- Acessar o Swagger
```
Acesse no navegador: http://localhost:5046/swagger
```


