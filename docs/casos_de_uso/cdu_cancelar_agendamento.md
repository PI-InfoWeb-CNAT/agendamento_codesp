# Projeto Agendamento de Serviços

## Especificação do caso de uso - Cancelar Agendamento

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 16/05/2021 | **1.10** | Ajustes na redação  | Gilbert Azevedo |
| 28/09/2022 | **2.0**  | Detalhamento  | Beatriz Ferreira |

### 1. Resumo 

Nesse caso de uso, o usuário acessa o sistema, visualiza o(s) agendamentos realizados e cancela um ou mais deles.

### 2. Atores 

* Usuário: poderá visualizar e cancelar um ou mais dos agendamnetos realizados.
* Funcionário: poderá visualizar e cancelar um ou mais dos agendamentos realizados.

### 3. Pré-condições

Qualquer um dos usuários deve possuir cadastro no sistema e também, deve realizado pelo menos um agendamento para conseguir cancelá-lo.

### 4. Pós-condições

O sistema deleta o agendamento, deixando o espaço/horário novamente dispovível para ser agendado.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. Na página de agendamentos, o usuário cancela sua solicitação. ||
|| 2. O sistema deleta o espaço/horário solicitado, deixando-o automaticamente disponível para ser reagendado. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Nenhum agendamento ter sido realizado | Se o usuário não tiver realizado pelo menos um agendamento, o sistema não tem como deletar nenhuma solicitação. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)