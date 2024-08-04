# Visitor Pattern

Exemplo de uso do Visitor Pattern.

**Contexto**: o sistema de gerenciamento de veiculos em um estacionamento precisa persistir informações em um
segundo banco de dados. No sistema atual existe a classe base Vehicle e subclasses Car e Motorcycle. Para cada
subclasse, operações diferentes deverão ser executadas antes da persistência dos dados no segundo banco.

**Problema**: como implementar a nova funcionalidade sem incluir as implementações na classe base ou nas 
subclasses? Como permitir que cada subclasse lide somente com a sua implementação de persistência de dados?

## Solução

1. Criar um Visitor para implementar a operação com o segundo banco de dados
2. A interface do Visitor exige a implementação das operações para cada subclasse
3. Cada subclasse implementa um método para receber um Visitor e executar sua operação


**Resultado**: as complexidades em manipular um novo banco de dados foram removidas da classe base e das subclasses,
sendo concentradas no Visitor criado. Isso permite manter a coesão da hierarquia de classes e alterações na implementação
do Visitor não as impactaram.