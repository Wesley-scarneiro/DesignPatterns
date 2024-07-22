# Singleton Pattern

Exemplo de uso do padrão Singleton.

**Contexto**: uma aplicação requer o uso de um serviço de logging para registrar o início e fim de algumas operações em um arquivo. Diferentes partes da aplicação deverão utilizar a mesma instância do serviço de logging e registrar as informações também no mesmo arquivo.

**Problema**: como garantir que a aplicação lide, de forma transparente, sempre com uma única instância do serviço de logging?

## Solução

1. Criar uma classe Logger que encapsule as operações de logging
2. Tornar o construtor privado, impedindo que seja chamado externamente
3. Declarar um atributo estático _instance de leitura do tipo Logger
4. Declarar um método GetInstance(), que retorna a instância armazenada de _instance

Resultado final: qualquer parte da aplicação poderá obter a mesma instância do serviço de logging, garantindo a restrição estabelecida.