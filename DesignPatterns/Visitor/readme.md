# Visitor Pattern

Exemplo de uso do Visitor Pattern.

**Contexto**: o sistema de gerenciamento de veiculos em um estacionamento precisa persistir informa��es em um
segundo banco de dados. No sistema atual existe a classe base Vehicle e subclasses Car e Motorcycle. Para cada
subclasse, opera��es diferentes dever�o ser executadas antes da persist�ncia dos dados no segundo banco.

**Problema**: como implementar a nova funcionalidade sem incluir as implementa��es na classe base ou nas 
subclasses? Como permitir que cada subclasse lide somente com a sua implementa��o de persist�ncia de dados?

## Solu��o

1. Criar um Visitor para implementar a opera��o com o segundo banco de dados
2. A interface do Visitor exige a implementa��o das opera��es para cada subclasse
3. Cada subclasse implementa um m�todo para receber um Visitor e executar sua opera��o


**Resultado**: as complexidades em manipular um novo banco de dados foram removidas da classe base e das subclasses,
sendo concentradas no Visitor criado. Isso permite manter a coes�o da hierarquia de classes e altera��es na implementa��o
do Visitor n�o as impactaram.