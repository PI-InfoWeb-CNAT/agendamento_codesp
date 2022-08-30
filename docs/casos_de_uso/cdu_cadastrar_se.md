# Projeto Agendamento de Serviços

## Especificação do caso de uso - Cadastrar-se

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |
| 16/05/2021 | **1.10** | Ajustes na redação  | Gilbert Azevedo |
| 30/08/2002 | **2.0**  | Detalhamento  | Beatriz Ferreira |

### 1. Resumo 

Nesse caso de uso, o usuário acessa o sistema e realizam seu cadastro, podendo: fornecer informações como seu nome, uma senha de sua escolha, email, tipo de vínculo com o IFRN, matrícula e curso.

### 2. Atores 

* Usuário: poderá fornecer informações para seus próximos acessos no sistema.
* Funcionário: poderá fornecer informações para seus próximos acessos no sistema.

### 3. Pré-condições

Qualquer um dos usuários deve estar vinculado à instituição IFRN.

### 4. Pós-condições

O sistema disponibiliza a visualização dos horários e ambientes disponíveis para reserva.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O usuário fornece suas informações como nome, uma senha de sua escolha, email, tipo de vínculo com o IFRN, matrícula e curso. ||
|| 2. O sistema realiza o cadastro desses dados em seu banco de dados, permitindo que o usuário realize o login nos seus próximos acessos. |

#### 5.2. Fluxos de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário tentar inserir ou atualizar dados com informações inválidas (por exemplo, matrícula repetida), o sistema deve apresentar um alerta e não realizar a operação. |


### 6. Protótipos de Interface
[Protótipo de alta fidelidade realizado no Figma](/guides/content/editing-an-existing-page#modifying-front-matter)