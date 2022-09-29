# Projeto Agendamento de Serviços

## Especificação do caso de uso - Gerenciar Funcionário

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 09/05/2022 | **1.10** | Ajustes da redação | Gilbert Azevedo |
| 28/09/2022 | **2.0**  | Detalhamento  | Beatriz Ferreira |

### 1. Resumo 

Nesse caso de uso, o administrador acessa o sistema e abre a aba de cadastro de funcionários. Essa operação disponiliza tanto as opções de visualização quanto a de alteração dos dados dos profissionais.

### 2. Atores 

Administrador

### 3. Pré-condições

O administrador deve estar autenticado no sistema.

### 4. Pós-condições

O sistema remove ou adiciona as alterações realizadas pelo administrador quanto aos funcionários.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário acessa o painel de gerenciamento de quadras. ||
|| 2. O sistema apresenta o painel de controle com controles que permitem ao usuário selecionar uma data e um serviço. O controle de seleção de data deve iniciar no dia atual. O controle de seleção de serviço deve iniciar vazio, se houver mais de um tipo de serviço disponível, ou com o serviço selecionado, caso apenas um serviço esteja disponível. |
| 3. O usuário ajusta, se necessário, os controles de seleção de data e serviço e submete a consulta ao sistema. ||
|| 4. O sistema apresenta no formato de tabela os horários da agenda do dia e serviço informados, disponibilizando as opções de confirmar um agendamento e excluir um agendamento, para cada horário da agenda, e de abrir a agenda do dia, para gerenciar o cadastro de horários disponíveis. O sistema deve apresentar todos os horários da agenda do dia, informando os dados dos clientes. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o administrador para a realização da consulta, o sistema deve apresentar um alerta de dados não informados e a consulta não é realizada. Essa operação se repete até que uma data e um serviço sejam informados. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)
