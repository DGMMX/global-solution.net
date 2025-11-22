# 🌐 FutureOfWork API  
### Plataforma RESTful para Gestão de Profissionais e Oportunidades — FIAP Global Solution

A **FutureOfWork API** é um projeto desenvolvido em **C# .NET 8**, estruturado para oferecer um conjunto de endpoints modernos para gerenciamento de **Trabalhadores (Workers)** e **Vagas de Emprego (Jobs)**.  
O foco da solução é apoiar empresas na organização de talentos e oportunidades usando boas práticas de arquitetura e versionamento de APIs.

---

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
