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

O administrador deve estar logado no sistema.

### 4. Pós-condições

O sistema remove ou adiciona as alterações realizadas pelo administrador quanto aos funcionários.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O administrador acessa o painel de gerenciamento de funcionário. ||
|| 2. O sistema apresenta o painel de controle com controles que permitem ao usuário selecionar os funcionários autenticados no sistema. |
|| 3. O sistema apresenta no formato de tabela todos os funcionários cadastrados no sistema. O sistema deve apresentar todos os funcionários autenticados no sistema informando os dados dos mesmos. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o administrador não selecionar um funcionário válido para a realização da consulta, o sistema deve apresentar um alerta de dados não informados e a consulta não é realizada. Essa operação se repete até que uma data e um serviço sejam informados. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)
