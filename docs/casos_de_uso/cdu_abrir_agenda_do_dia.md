# Projeto Agendamento de Serviços

## Especificação do caso de uso - Abrir Agenda do Dia

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 16/05/2021 | **1.10** | Ajustes na redação  | Gilbert Azevedo |

### 1. Resumo 

Nesse caso de uso, o usuário funcionário acessa o sistema e gerencia sua agenda, ou a agenda da empresa, podendo: inserir novos horários de atendimento, atualizar horários existentes ou, até mesmo, excluindo horários ainda não agendados por clientes.

### 2. Atores 

Funcionário

### 3. Pré-condições

O funcionário deve ter consultado o painel de controle da agenda para um serviço e data específicos.

### 4. Pós-condições

O sistema disponibiliza os horários cadastrados na agenda para que os clientes possam agendar os serviços.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário abre a agenda de um determinado dia, a partir do painel de controle (dashborad) da agenda ||
|| 2. O sistema lista os horários da agenda do dia informado, permitindo inserir novos horários na agenda desse dia, atualizar as informações de um horário da agenda e excluir horários não agendados por clientes. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário tentar inserir ou atualizar horários com informações inválidas (por exemplo, horário repetido), o sistema deve apresentar um alerta e não realizar a operação. |
| 2. Exclusão de horário já agendado | Se o usuário tentar excluir horários já agendados, o sistema deve apresentar um alerta e não realizar a operação. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)
