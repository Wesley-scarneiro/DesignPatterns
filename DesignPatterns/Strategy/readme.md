# Strategy Pattern

Exemplos de uso do Strategy Pattern.

**Contexto**: uma aplica��o realiza a consulta e ordena��o de uma lista de clientes por n�mero de ID. 
Contudo, surgiu a necessidade de permitir a ordena��o por ordem alfab�tica e daqui a alguns meses tamb�m ser� preciso
permitir a ordena��o por idade.

**Problema**: como fazer com que a classe que realiza a pesquisa e ordena��o dos dados respeite o pric�pio de projeto Aberto/Fechado?
Isto �, a classe deve estar aberta a extens�o (permitir a parametriza��o de algoritmos ou funcionalidades internas) e fechada 
a modifica��o (n�o altera��o do c�digo existe para adi��o de novas funcionalidades).

## Solu��o

1. Parametrizar o algoritmo de ordena��o e remover a responsabilidade da classe principal de implement�-lo
2. Criar uma interface SortStrategy que exige a implementa��o de um m�todo Sort()
3. A classe principal passa a criar um IdSortStrategy por padr�o, mas permite a altera��o para qualquer SortStrategy
4. A classe principal passa a utilizar uma implementa��o do StorStrategy definido para ordenar os dados