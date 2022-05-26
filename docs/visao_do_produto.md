# Documento de Visão

## Sistema de Agendamento de Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2021 |  **`1.0`** | Versão Inicial  | Gilbert Azevedo |
| 26/05/2022 |  **`1.1`** | Versão Modificada  | Joanderson Santos |


### 1. Objetivo do Projeto 

O projeto __AgendEsportes__ tem como objetivo prover uma solução simples, acessível e padronizada para o agendamento de horários da CODESP serem feitos de modo virtual.

### 2. Descrição do Problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | Reservar um horário das quadras ou ginásio. |
| **_afetando_**      | Alunos e professores que estão tentando reservar horários na CODESP. |
| **_cujo impacto é_**| Dificuldade no agendamento do atendimento, pois às vezes os bolsistas não estão na sala nos momentos em que os alunos/professores estão indo reservar. Além de consumir um pouco mais do tempo de quem reserva. |
| **_uma boa solução seria_** | Um sistema na Internet que permita a coordenação informar a disponibilidade de horários disponíveis, facilitando o agendamento desses atendimentos para seus clientes. E para os clientes, um sistema que facilite a reserva de um horário sem precisar ir lá. |

### 3. Descrição dos Usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Administrador  | Realiza as atividades básicas para o início da operação do sistema | Mantém o cadastro dos funcionários responsáveis pela operação da agenda de serviços |
| Funcionário  | Realiza as atividades relacionadas ao controle da agenda de serviços | Mantém o cadastro de serviços; consulta a situação das agendas de serviços; mantém a agenda de atendimento; confirma o agendamento de clientes e exclui o agendamento de clientes |
| Cliente | Realiza as atividades relacionadas ao agendamento do serviço | Realiza o próprio cadastro no sistema; consulta a agenda de serviços e disponibilidades de atendimento; agenda um serviço; consulta seus agendamentos e cancela um agendamento |

### 4. Descrição do Ambiente dos Usuários

Em várias atividades esportivas feitas no ginásio ou nas quadras do CNAT, é necessário que os alunos, ou professores, reservem um horário na CODESP. 

Quando o aluno ou professor resolve pegar um horário, geralmente ele precisa se dirigir pessoalmente até a CODESP. E como, muitas vezes não há bolsistas na CODESP, esse agendamento pode ter causado apenas uma perca de tempo para o cliente que ainda precisará voltar a CODESP para reservar o horário, pois há a necessidade de encontrar um horário viável para os dois envolvidos.

Desta forma, a ideia central do sistema é permitir que a CODESP registre suas grade de horários disponíveis e que clientes, em geral, possam consultar e agendar os horários. Com isso, o sistema pode estabelecer um canal de comunicação mais ágil entre os alunos/professores e a CODESP.

### 5. Principais Necessidades dos Usuários

Para a CODESP, a necessidade é divulgar sua disponibilidade de horários para viabilizar, de forma mais eficiente, o atendimento dos seus clientes.

Para os clientes, as necessidades são reservar os horários na CODESP sem precisar que algum funcionário faça isso por ele e que ele precise ter de ir lá remotamente.

### 6.	Alternativas Concorrentes

As alternativas concorrentes são, em geral, específicas para uma empresa ou profissional. A ideia do sistema proposto é prover uma solução simples, acessível e padronizada para o agendamento de serviços e que pode ser utilizada por quaisquer profissionais e empresas.

### 7.	Visão Geral do Produto

Em resumo, o sistema AgendEsporte é uma aplicação que permite que Arenas, Ginásios ou Coordenações Desportivas a registrarem suas disponibilidades de atendimento aos seus clientes, de forma que estes possam consultar e agendar horários de forma online para realização de serviços.

O sistema deve ter uma interface amigável e permitir o acesso concorrente de clientes para agendamento de um horário de atendimento.

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Entrar no sistema | Usuários devem logar no sistema para acessar as funcionalidades relacionadas ao agendamento |
| RF02 | Cadastro de Funcionários | Administrador do sistema mantém o cadastro dos funcionários responsáveis pelo gerenciamento das agendas |
| RF03 | Gerenciamento de Serviços |  Funcionário mantém a relação de serviços prestados pela empresa ou profissional |
| RF04 | Gerenciamento da Agenda | Funcionário registra os horários disponíveis de atendimento, confirma e cancela o agendamento de clientes |
| RF05 | Cadastro de Clientes | Cliente deve realizar o auto cadastramento |
| RF06 | Consulta de Agendas | Cliente consulta a grade de horários disponíveis, podendo agendar um serviço  |
| RF07 | Consulta de Agendamento | Cliente consulta horários reservados, podendo cancelar um agendamento |


### 9. Requisitos Não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Tema | Deverá ter uma configuração fácil para mudar de tema, por exemplo tema claro e escuro. | Usabilidade | Desejável |
| RNF02 | Alteração Não Salva | Aparecera uma tela de confirmação se o cliente tentar sair da página sem confirmar as alterações não salvas. | Segurança | Obrigatório |
| RNF03 | Controle de acesso | Só usuários autenticados podem ter acesso ao sistema, com exceção ao auto cadastramento do usuário. | Segurança | Obrigatório |
| RNF04 | Tempo de resposta |A comunicação entre o servidor e o cliente deve ocorrer em tempo hábil | Performance | Desejável |
| RNF05 | Sistema Web | A aplicação deve ser um site. | Arquitetura | Obrigatório |
| RNF06 | Dados pessoais | Os clientes não devem visualizar dados de outros clientes (na agenda, por exemplo). | Privacidade | Obrigatório |
