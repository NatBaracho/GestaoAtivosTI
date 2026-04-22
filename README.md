# 📌 Sistema de Gestão de Ativos de TI

Projeto desenvolvido em **C# com Windows Forms** para gerenciar equipamentos de TI (Notebooks e Servidores).  
A persistência dos dados é feita em um arquivo **JSON local**, dispensando banco de dados e tornando o sistema portátil e fácil de instalar.

---

## 🎯 Objetivo
Construir um sistema de gestão de equipamentos de TI totalmente funcional, aplicando conceitos de **Orientação a Objetos** e utilizando **serialização JSON** para persistência dos dados.

---

## 🚀 Funcionalidades
- Tela de **Login** com validação simples.
- Tela **Principal** com listagem dos equipamentos em `DataGridView`.
- Tela de **Cadastro** para inserir novos ativos.
- **Persistência em JSON**: leitura e gravação automática na mesma pasta do executável.
- Aplicação prática dos **4 pilares da POO**:
  - **Abstração**: classe base `Equipamento`.
  - **Encapsulamento**: propriedades com validações.
  - **Herança**: classes `Notebook` e `Servidor`.
  - **Polimorfismo**: cálculo de depreciação diferenciado por tipo de equipamento.

---

## 🛠️ Tecnologias Utilizadas
- **C# .NET (Windows Forms)**
- **System.Text.Json** para serialização
- **Orientação a Objetos (POO)**

---

## 📂 Estrutura do Projeto
- `Models/Equipamento.cs` → Classe abstrata base.
- `Models/Notebook.cs` → Classe derivada para notebooks.
- `Models/Servidor.cs` → Classe derivada para servidores.
- `Models/AtivosRepository.cs` → Repositório que substitui o banco de dados.
- `FormLogin.cs` → Tela inicial de login.
- `FormPrincipal.cs` → Tela principal com listagem e ações.
- `FormCadastro.cs` → Tela de cadastro de novos ativos.

---

## ▶️ Como Executar
1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/gestao-ativos-ti.git
