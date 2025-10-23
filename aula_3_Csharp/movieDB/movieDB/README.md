# Aula III

Nessa aula, foi desenvolvido um projeto utilizando a estratégia de **Arquitetura em Camadas**.
Cada camada é uma dessas pastas. 

### Domínio
Nessa pasta nós temos a **representação do coração do negócio**, contendo **entidades, agregados, objetos de valor, interface de repositórios, serviços de domínio, regras de negócio**

## Aplicação
O objetivo dessa pasta é **orquestrar tarefas específicas**, como **serviços de aplicação, mapeamentos, casos de uso, DTOs**.

## Infra
Fornece suporte técnico a outras camadas, implementando interfaces definidas no domínio, como **acesso a bancos de dados, migrações, logging, Integrações com API's externas**. 

## Apresentação
Responsável por **expor a API HTTP**, recebendo requisições e devolvendo respostas, através do **controller, middlewares, condigurações de segurança**