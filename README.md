![image](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgDwmUNq7SglZ1tum81yxdFKJVA9NVwOonNkFq1zwa1g&s)

# LAB Clothing Collection

O projeto intitulado **LAB Clothing Collection** , é um software para gestão de coleções de moda no setor de vestuário. Ele gerencia suas coleções e modelos de vestuário criados por determinados usuários da equipe. Essa API soluciona o problema de organizar modelos, coleções e usuários no ramo da moda através da disponibilização de endpoints para cadastro, atualização e pesquisa das informações armazenadas no seu banco de dados.


## Desenvolvimento

A aplicação Back-End do software é construída com:

* Uma API Rest desenvolvida em C# com uso de .Net;
* Utiliza o banco de dados SQL Server Express;
* É planejada utilizando o modelo Kanban na ferramenta Trello;
* É versionada no GitHub;
* E possui um vídeo explicativo sobre o projeto.

## Projeto

O projeto possui a seguinte organização:

* Módulo Controllers: Onde estão as definições de rota da API Rest, este módulo de Controller recebe os parâmetros e corpo das requisições e envia aos services para que os dados possam ser distribuídos/modificados pelo cliente.
* Módulo Database: É onde são realizadas as configurações entre o C# e o SQL, nele são definidas as tabelas que existirão no SQL por meio do DbSet<Tipo> do EntityFramework. E é onde são definidas as classes de repositories com suas funções de create, read, update e delete. Os parâmetros das funções dos repositories costumam ser originários do que são recebidos no módulo de Services. O módulo Database possui ainda uma pasta de Configurations, que possui as definições das propriedades (colunas) das tabelas, como a obrigatoriedade do dado, tamanho máximo entre outros.
* Módulo Migrations: As migrações permitem que você defina e mantenha o estado do banco de dados em sincronia com o modelo de dados definido em seu código. Então é uma forma de manter o versionamento do banco SQL com base no código que vai sendo construído no C#, principalmente o que for relacionado as classes conectadas ao EntityFramework.
* Módulo Models: Possui as estruturas de dados dos objetos C#. Como a classe Modelo.cs, que é uma definição de como um Modelo é identificado. Com id, nome modelo, id colecao relacionada, tipo e layout.
Na pasta ainda possui as definições dos Enums utilizados no projeto e o ViewModels, que são as definições do que espero receber por meio da API Rest, caso o dado recebido não esteja em conformidade com o que está definido nas classes em ViewModels, o sistema poderá gerar erro de que determinada propriedade é requerida.
* Módulo Services: É o responsável por tratar as informações recebidas pelo controller (via API). E de certa forma, é onde são montados os objetos antes de serem definitivamente salvos no banco de dados, isso por meio dos repositories. Portanto, é um modulo que realiza uma conexão entre o Controller e o Repository, neste módulo podemos aplicar se as propriedades recebidas estão de acordo, se o usuário realmente possui acesso a modificação e outras aplicações.
* Módulo Seeders: Os seeders são basicamente funções para inserir dados automaticamente no banco de dados para teste mas configurados apenas com a execução em "dev" e não em produção. Nele definimos objetos que desejamos inserir automaticamente no banco de dados na primeira inicialização e isso auxilia na integração de novos devs ou clientes frontend ao projeto, pois os dados já estarão registrados no momento da liberação da porta para acesso a aplicação.

## Conclusão

Após executar e testar o software seu feedback e contribuição são valiosos! Caso encontre algum bug ou perceba uma melhoria em algum aspecto do projeto não hesite em nos comunicar. 

*No mundo da tecnologia cada dia construímos um novo olhar para as aplicações visando uma melhor experiência para nossos clientes.*

