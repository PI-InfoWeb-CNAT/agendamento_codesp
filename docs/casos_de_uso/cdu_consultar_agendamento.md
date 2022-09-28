# Projeto Agendamento de Serviços

## Especificação do caso de uso - Consultar Agendamento

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 16/05/2021 | **1.10** | Ajustes na redação  | Gilbert Azevedo |
| 28/09/2022 | **2.0**  | Detalhamento  | Beatriz Ferreira |

### 1. Resumo 

Nesse caso de uso, o usuário acessa o sistema e visualiza o agendamento realizado.

### 2. Atores 

* Usuário: poderá visualizar informações do agendamento realizado.
* Funcionário: poderá visualizar e editar informações do agendamento realizado.

### 3. Pré-condições

Qualquer um dos usuários deve possuir cadastro no sistema e também, deve realizado pelo menos um agendamento para conseguir visualizar informações do mesmo.

### 4. Pós-condições

O sistema disponibiliza a visualização das informações dos agendamentos realizados.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário realiza o login e acessa página de agendamentos. ||
|| 2. O sistema disponibiliza a visualização das informações dos agendamentos realizados.. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Nenhum agendamento ter sido realizado | Se o usuário não tiver realizado pelo menos um agendamento, o sistema não tem como oferecer nenhuma informação. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)