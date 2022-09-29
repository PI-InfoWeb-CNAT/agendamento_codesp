# Projeto Agendamento de Serviços

## Especificação do caso de uso - Fazer Login

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 16/05/2021 | **1.10** | Ajustes na redação  | Gilbert Azevedo |
| 29/09/2022 | **2.0**  | Detalhamento  | Beatriz Ferreira |

### 1. Resumo 

Nesse caso de uso, o usuário acessa o sistema e digita sua matrícula e sua senha no formulário de login.

### 2. Atores 

* Usuário: fornece matrícula e senha para que as mesmas sejam autenticadas.
* Funcionário: fornece matrícula e senha para que as mesmas sejam autenticadas.

### 3. Pré-condições

Qualquer um dos usuários deve estar vinculado à instituição IFRN.

### 4. Pós-condições

O sistema disponibiliza a visualização do dashboard de agenda.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário fornece suas informações como matrícula e senha. ||
|| 2. O sistema realiza a autenticação desses dados em seu banco de dados, permitindo que o usuário acesse o sistema. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário tentar inserir ou atualizar dados com informações inválidas (por exemplo, dados não cadastrados), o sistema deve apresentar um alerta e não realizar a operação. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)