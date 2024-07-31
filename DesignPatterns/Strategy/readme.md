# Strategy Pattern

Exemplos de uso do Strategy Pattern.

**Contexto**: uma aplicação realiza a consulta e ordenação de uma lista de clientes por número de ID. 
Contudo, surgiu a necessidade de permitir a ordenação por ordem alfabética e daqui a alguns meses também será preciso
permitir a ordenação por idade.

**Problema**: como fazer com que a classe que realiza a pesquisa e ordenação dos dados respeite o pricípio de projeto Aberto/Fechado?
Isto é, a classe deve estar aberta a extensão (permitir a parametrização de algoritmos ou funcionalidades internas) e fechada 
a modificação (não alteração do código existe para adição de novas funcionalidades).

## Solução

1. Parametrizar o algoritmo de ordenação e remover a responsabilidade da classe principal de implementá-lo
2. Criar uma interface SortStrategy que exige a implementação de um método Sort()
3. A classe principal passa a criar um IdSortStrategy por padrão, mas permite a alteração para qualquer SortStrategy
4. A classe principal passa a utilizar uma implementação do StorStrategy definido para ordenar os dados