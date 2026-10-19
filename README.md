# 📋 TaskFlow

O **TaskFlow** é uma solução desenvolvida em **.NET (C#)** voltada para o gerenciamento de tarefas via linha de comando, estruturada com foco em boas práticas de arquitetura, separação de responsabilidades e validação orientada a testes unitários automatizados com **xUnit**.

---

## 🏗️ Estrutura da Solução

O repositório é organizado em dois projetos principais:

* **`TaskFlow.Console`**: Projeto de console contendo o modelo de domínio, a lógica de negócio e a interface interativa com o utilizador.
  * `TaskItem.cs`: Entidade de domínio que representa uma tarefa com identificador (`Guid`), título e status de conclusão.
  * `TaskManager.cs`: Gerenciador responsável pelas operações de adição, busca e conclusão de tarefas.
  * `Program.cs`: Ponto de entrada da aplicação contendo o ciclo do menu interativo.
* **`TaskFlow.Tests`**: Projeto de testes unitários automatizados.
  * `TaskManagerTests.cs`: Suíte de testes cobrindo criação com dados válidos, tratamento de exceções para entradas em branco e busca resiliente por identificador.

---

## 🚀 Tecnologias Utilizadas

* **Linguagem**: C# (.NET 10 / SDK moderno)
* **Framework de Testes**: xUnit
* **Recursos de Linguagem**: Nullable Reference Types, Pattern Matching e LINQ

---

## ⚙️ Pré-requisitos

Para compilar e executar o projeto, é necessário ter instalado no ambiente:

* [.NET SDK](https://dotnet.microsoft.com/download) (versão 8.0 ou superior)
* Git instalado e configurado
* Editor de código recomendado: Visual Studio Code ou Visual Studio

---

## 🔧 Como Compilar o Projeto

Para restaurar as dependências e compilar todos os projetos da solução, execute na raiz do repositório:

```bash
dotnet build
```

---

## ▶️ Como Rodar a Aplicação Console

Para iniciar a interface interativa via console, execute o comando:

```bash
dotnet run --project TaskFlow.Console/TaskFlow.Console.csproj
```

### Funcionalidades do Menu Interativo

1. **Adicionar tarefa**: Cadastra uma nova tarefa validando a obrigatoriedade do título (rejeita entradas nulas ou compostas apenas por espaços).
2. **Listar tarefas**: Exibe todas as tarefas registadas com ID (`Guid`), título e status (`[ ]` pendente ou `[X]` concluída).
3. **Concluir tarefa**: Localiza o item pelo ID informado e marca o seu status como concluído.
4. **Sair**: Encerra o ciclo da aplicação no terminal.

---

## 🧪 Como Executar os Testes Unitários

Para rodar toda a suíte de testes unitários automatizados:

```bash
dotnet test
```

Para visualizar a listagem detalhada de cada teste executado:

```bash
dotnet test --logger "console;verbosity=detailed"
```

---

## 🔄 Padrão de Commits Utilizado

O repositório segue a especificação de *Conventional Commits*:

* `fix(manager): handle missing task gracefully in search method`
* `refactor(console): implement interactive menu loop in Program.cs`
* `docs(readme): add build, run and test instructions`