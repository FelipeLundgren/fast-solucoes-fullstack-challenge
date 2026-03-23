# 🚀 FAST Soluções - Desafio Técnico Fullstack

## 🎯 Objetivo do Projeto
Desenvolver uma aplicação para analisar e rastrear a participação dos colaboradores nos workshops trimestrais da empresa, atendendo aos requisitos de Backend (C#) e Frontend (Angular).

---

## 🛠️ Tecnologias Utilizadas

**Backend:**
* C# .NET (Web API)
* Arquitetura MVC (Models, Controllers)
* Armazenamento de dados em memória (DataStorage) simulando um banco de dados real.

**Frontend:**
* Angular (Componentes Standalone)
* TypeScript, HTML5 e CSS3
* Rotas dinâmicas (`@angular/router`)
* Mock de dados em Services (`MockDataService`)

---

## ⚙️ Como executar o projeto na sua máquina

### 1️⃣ Executando o Backend (API)
O Backend possui dados mockados que são carregados na memória toda vez que a aplicação é iniciada.

1. Abra o terminal na pasta raiz do projeto (`fast-solucoes-fullstack-challenge`).
2. Execute o comando:
   ```bash
   dotnet run
A API estará rodando (geralmente na porta http://localhost:5282 ou similar).

Endpoints disponíveis para teste (GET/POST):

/api/colaboradores

/api/workshops

/api/atas/workshop/{id} (Relacionamento de presença)

2️⃣ Executando o Frontend (Interface Angular)
O Frontend foi construído consumindo um Mock de dados interno, conforme exigido no desafio, para demonstrar o domínio de Services e Interfaces no Angular.

Abra um novo terminal.

Navegue até a pasta do Frontend:

Bash
cd fast-frontend
Instale as dependências (caso seja a primeira vez):

Bash
npm install
Rode o servidor de desenvolvimento:

Bash
ng serve -o
O seu navegador abrirá automaticamente no endereço http://localhost:4200/.

✨ Funcionalidades Entregues
[x] Backend: CRUD em memória de Colaboradores e Workshops.

[x] Backend: Registro de Atas de Presença (Tabela de Relacionamento).

[x] Frontend: Tela com listagem de todos os Colaboradores.

[x] Frontend: Tela com listagem de todos os Workshops.

[x] Frontend: Tela de Detalhes do Workshop (exibindo data formatada, descrição e lista de participantes através de passagem de ID via rota).

Desenvolvido com dedicação por Felipe para o desafio da FAST Soluções.
