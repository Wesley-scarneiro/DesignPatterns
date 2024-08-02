# Observer Pattern

Exemplos de uso do Observer Pattern.

**Contexto**: uma aplicação é responsável por monitorar algumas taxas financeiras, entre elas a Selic. Quando a taxa Selic mudar,
esse sistema deve notificar em tempo real os serviços de cartão de crédito, empréstimo pessoal e financiamento imobiliário 
para que possam reajustar as suas taxas de juros.

**Problema**: como não acoplar o serviço que manipula as atualizações das taxas dos serviços que as consomem? Como permitir
que novos serviços possam também ser notificados de forma transparente, sem a necessidade de modificar ou alterar o serviço base?

## Solução

1. Criar uma classe abstrata Subject, que representa um sujeito que pode ser observado
3. Subject declara uma lista de observadores, um método para adicionar observadores e notificá-los
2. Criar uma interface genérica IObserver<T>, que representa um observador que observa um dado sujeito do tipo T