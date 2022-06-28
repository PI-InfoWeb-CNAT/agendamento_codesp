# Documento de Visão

## Sistema de Agendamento de Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2021 |  **`1.0`** | Versão Inicial  | Gilbert Azevedo |
| 26/05/2022 |  **`1.1`** | Versão Modificada  | Joanderson Santos |
| 26/05/2022 |  **`1.2`** | Versão Modificada  | Wagner Gomes |
| 26/05/2022 | **`1.3`** | Versão Modificada | Beatriz Ferreira |
| 27/06/2022 | **`1.4`** | Versão Modificada | Beatriz Ferreira |

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
| Administrador  | Realiza as atividades básicas para o início da operação do sistema de agendamentos | Mantém o cadastro dos funcionários responsáveis pela operação da agenda de serviços |
| Usuário CODESP (funcionário)  | Realiza as atividades relacionadas ao controle da agenda de serviços como realização de aula, evento, amistoso (normalmente requer uma descrição)| Mantém o cadastro de serviços (aula, evento, etc); Mantém o cadastro dos espaços esportivos; Mantém a agenda dos espaços esportivos; Confirma o agendamento dos clientes (alunos e professores); Exclui o agendamento dos clientes |
| Usuário Aluno/Servidor | Consulta agenda dos espaços; agenda um espaço | Realiza o próprio cadastro; Consulta a agenda dos espaços esportivos; Agenda horários em espaços esportivos; Cancela agendamentos |

### 4. Descrição do Ambiente dos Usuários

Em várias atividades esportivas feitas no ginásio ou nas quadras do CNAT, é necessário que os alunos, ou professores, reservem um horário na CODESP. 

Quando o aluno ou professor resolve pegar um horário, geralmente ele precisa se dirigir pessoalmente até a CODESP. E como, muitas vezes não tem nenhum bolsista lá, esse agendamento pode ter causado apenas uma perca de tempo para o cliente que ainda precisará voltar a CODESP para reservar o horário. Há a necessidade de encontrar um horário viável para os dois envolvidos.

Desta forma, a ideia central do sistema é permitir que a CODESP registre suas grade de horários disponíveis e que clientes, em geral, possam consultar e agendar os horários. Com isso, o sistema pode estabelecer um canal de comunicação mais ágil entre os alunos/professores e a CODESP.

### 5. Principais Necessidades dos Usuários

Para a CODESP, a necessidade é divulgar sua disponibilidade de horários para viabilizar, de forma mais eficiente, o atendimento dos seus clientes.

Para os clientes, as necessidades são reservar os horários na CODESP sem precisar que algum funcionário faça isso por ele e que ele precise ter de ir lá remotamente.

### 6.	Alternativas Concorrentes

No momento, não existe nenhum sistema digital que auxilie no agendamento de serviços da CODESP. A ideia do sistema proposto é que prover uma solução que seja simples, acessível e mais prática para esse tipo de ofício.

### 7.	Visão Geral do Produto

Em resumo, o sistema AgendEsporte é uma aplicação que permite que Arenas, Ginásios ou Coordenações Desportivas a registrarem suas disponibilidades de atendimento aos seus clientes, de forma que estes possam consultar e agendar horários de forma online para realização de serviços.

O sistema deve ter uma interface amigável e permitir o acesso concorrente de clientes para agendamento de um horário de atendimento.

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Entrar no sistema | Usuários devem logar no sistema para acessar as funcionalidades relacionadas ao agendamento |
| RF02 | Cadastro de Funcionários | Administrador do sistema mantém o cadastro dos funcionários responsáveis pelo gerenciamento das agendas |
| RF03 | Cadastro dos Espaços | Funcionário registra os espaços que podem ser reservados |
| RF04 | Gerenciamento de Serviços |  Funcionário registra o motivo da do agendamento  |
| RF05 | Gerenciamento da Agenda | Funcionário registra os horários disponíveis de atendimento, confirma e cancela o agendamento de clientes |
| RF06 | Cadastro de Clientes | Cliente deve realizar o auto cadastramento |
| RF07 | Consulta de Agendas | Cliente consulta a grade de horários disponíveis, podendo agendar um serviço  |
| RF08 | Consulta de Agendamento | Cliente consulta horários reservados, podendo cancelar um agendamento |
| RF09 | Cadastro dos Espaços | Funcionario cadastra espaços disponiveis para agendamento. |


### 9. Requisitos Não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Tema | Deverá ter uma configuração fácil para mudar de tema, por exemplo tema claro e escuro. | Usabilidade | Desejável |
| RNF02 | Alteração Não Salva | Aparecera uma tela de confirmação se o cliente tentar sair da página sem confirmar as alterações não salvas. | Segurança | Obrigatório |
| RNF03 | Reutilizar Dados | Utilizando dados cadastrados anteriormente, podemos acelerar o próximo processo que irá ser iniciado. | Reusabilidade | Desejável |
| RNF04 | Informações de Sessões | Mostrar ao usuário do sistema onde a conta dele possa estar logada, mostrando o computador e a hora que foi utilizado a conta. | Segurança | Obrigatório |
| RNF05 | Histórico de Agendamentos | Clientes podem ver o seu histórico de agendamentos, mostrando dia, hora e mês. | Usabilidade | Obrigatório |
| RNF06 | Participantes | Mostrar ao usuário que agendou um horário, outros usuários que agendaram naquele mesmo serviço. | Reusabilidade | Desejável |
