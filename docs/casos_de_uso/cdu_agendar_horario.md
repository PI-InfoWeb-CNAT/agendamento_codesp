# Projeto Agendamento de Serviços

## Especificação do caso de uso - Fazer Login

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 16/05/2021 | **1.10** | Ajustes na redação  | Gilbert Azevedo |
| 29/09/2022 | **2.00** | Detalhamento  | Beatriz Ferreira |

### 1. Resumo 

Nesse caso de uso, o usuário acessa o sistema, podendo: escolher um horário vago para marcar o serviço.

### 2. Atores 

Usuário

### 3. Pré-condições

O cliente deve estar logado para marcar um serviço.

### 4. Pós-condições

O sistema disponibiliza os horários cadastrados na agenda do funcionário para que os usuários possam agendar os serviços.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário deve clicar em agendar agora, e escolher o serviço, escolher a modalidade e o espaços disponíveis da mesma e por fim um horário/data em que este espaço esteja disponível. ||
|| 2. O sistema apresenta o painel de controle com controles que permitem ao usuário selecionar uma data e um serviço. O controle de seleção de data deve iniciar no dia atual. O controle de seleção de serviço deve iniciar vazio, se houver mais de um tipo de serviço disponível, ou com o serviço selecionado, caso apenas um serviço esteja disponível. |
| 3. O usuário ajusta, se necessário, os controles de seleção de data e serviço e submete a consulta ao sistema. ||
|| 4. O sistema apresenta no formato de tabela os horários da agenda do dia e serviço informados, disponibilizando as opções de confirmar um agendamento e excluir um agendamento, para cada horário da agenda, e de abrir a agenda do dia, para gerenciar o cadastro de horários disponíveis. O sistema deve apresentar todos os horários da agenda do dia, informando os dados dos clientes. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário não selecionar uma data e um serviço para a realização da consulta, o sistema deve apresentar um alerta de dados não informados e a consulta não é realizada. Essa operação se repete até que uma data e um serviço sejam informados. |




### 6. Protótipos de Interface
https://www.figma.com/file/2ShvFH0X1J4tdr0bG6O9uh/PROJETO-INTEGRADOR