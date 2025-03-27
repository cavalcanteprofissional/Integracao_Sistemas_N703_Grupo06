# Consulta de CPF - Integração com API Pública

Este projeto tem como objetivo desenvolver uma aplicação em **C#** que realiza consultas de **CPF** utilizando a API pública **BrasilAPI**. O sistema permite buscar informações de um CPF válido, armazenar os dados localmente e demonstrar a integração entre sistemas distintos através de APIs REST.

## 📌 Funcionalidades
- Consulta de CPF utilizando a API pública BrasilAPI.
- Exibição dos dados retornados pela API.
- Armazenamento local das informações consultadas.
- Interface simples e intuitiva.

## 🛠 Tecnologias Utilizadas
- **Linguagem**: C#
- **Plataforma**: .NET 6.0
- **Bibliotecas**:
  - `System.Net.Http` para requisições HTTP
  - `Newtonsoft.Json` para manipulação de dados JSON
  - `SQLite` (opcional) para armazenamento local

## ⚙️ Requisitos de Software
- .NET 6.0 Desktop Runtime (v6.0.36)
- Sistema Operacional: Windows, Linux ou macOS
- Acesso à internet para consultar a API

## 🚀 Como Executar o Projeto

1. **Clone o repositório**:
   ```sh
   git clone https://github.com/seuusuario/consulta-cpf.git
   cd consulta-cpf
   ```
2. **Instale as dependências**:
   ```sh
   dotnet restore
   ```
3. **Execute a aplicação**:
   ```sh
   dotnet run
   ```

## 📡 Endpoints Utilizados
- API: [BrasilAPI - Consulta CPF](https://brasilapi.com.br/docs#tag/CPF)
- Exemplo de requisição:
  ```sh
  GET https://brasilapi.com.br/api/cpf/v1/{cpf}
  ```

## 📖 Estrutura do Projeto
```
/consulta-cpf
├── Program.cs  # Arquivo principal da aplicação
├── Services
│   ├── CpfService.cs  # Lógica para requisição da API
├── Models
│   ├── CpfResponse.cs  # Modelo de dados retornados
├── Data
│   ├── Database.cs  # Armazenamento local (opcional)
└── README.md
```

## ✨ Contribuição
Se deseja contribuir, fique à vontade para abrir um PR ou sugerir melhorias.

## 📄 Licença
Este projeto está sob a licença MIT. Sinta-se à vontade para utilizá-lo e modificá-lo conforme necessário.

---
Projeto desenvolvido para a **Universidade de Fortaleza**, no curso de **Análise e Desenvolvimento de Sistemas**, disciplina **Técnicas de Integração de Sistemas**.

