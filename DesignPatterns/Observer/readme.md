# Observer Pattern

Exemplos de uso do Observer Pattern.

**Contexto**: uma aplica��o � respons�vel por monitorar algumas taxas financeiras, entre elas a Selic. Quando a taxa Selic mudar,
esse sistema deve notificar em tempo real os servi�os de cart�o de cr�dito, empr�stimo pessoal e financiamento imobili�rio 
para que possam reajustar as suas taxas de juros.

**Problema**: como n�o acoplar o servi�o que manipula as atualiza��es das taxas dos servi�os que as consomem? Como permitir
que novos servi�os possam tamb�m ser notificados de forma transparente, sem a necessidade de modificar ou alterar o servi�o base?

## Solu��o

1. Criar uma classe abstrata Subject, que representa um sujeito que pode ser observado
3. Subject declara uma lista de observadores, um m�todo para adicionar observadores e notific�-los
2. Criar uma interface gen�rica IObserver<T>, que representa um observador que observa um dado sujeito do tipo T