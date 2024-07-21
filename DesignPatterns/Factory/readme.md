# Factory pattern

Exemplo dos padrões Abstract Factory e Factory Method aplicado em alguns possíveis contextos de uso.

* **Contexto**: uma aplicação precisa chamar uma API ApiServiceOne ou ApiServiceTwo a depender da disponibilidade do primeiro serviço. Se ApiServiceOne está disponível, então o código cliente receberá a sua instância, caso ao contrário,deverá receber uma instância de ApiServiceTwo.

* **Problema**: como implementar a chamada aos diferentes serviços possíveis, de tal modo que o código cliente seja indiferente ao serviço que está sendo utilizado/chamado? Isto é, como deixar a decisão de escolha do serviço transparente ao código cliente?

# Solução com Abstract Factory

Fornece uma fábrica de objetos abstratos.
Cada subclasse implementa a sua própria fábrica de objetos.

* ApiServiceOne e ApiServiceTwo implementam a interface IApiService;
* A interface IApiServiceFactory exige a implementação do método Create(), para instanciar uma classe que implementa IApiService;
* As classes ApiServiceOneFactory e ApiServiceTwoFactory implementam IApiServiceFactory, cada uma instanciando a sua respectiva classe;
* O código cliente receberá sempre uma instância de IApiServiceFactory, podendo ser um ApiServiceOneFactory ou ApiServiceTwoFactory para instanciar uma classe que implementa IApiService.

**Resultado final**: quem chama o código cliente poderá decidir repassar uma instância de ApiServiceOneFactory ou ApiServiceTwoFactory. Assim, o código cliente não reconhece o tipo de serviço específico que está criando e manipulando.

# Solução com uma versão de Factory Method

Uma classe estática com um método fábrica estático.
O método fábrica implementa a decisão de qual instância será criada.

* ApiServiceOne e ApiServiceTwo implementam a interface IApiService;
* ApiServiceFactory como uma classe estática que fornece o método Create(), retornando uma implementação de IApiService a depender da disponibilidade;
* O código cliente cria uma instância de uma classe que implementa IApiService a partir do ApiServiceFactory.

**Resultado final**: o código cliente não reconhece o tipo de serviço específico que está criando e manipulando.