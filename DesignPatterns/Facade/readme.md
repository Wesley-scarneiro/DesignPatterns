# Facade Pattern

Exemplos possíveis de uso do Facade Pattern.

**Context**: uma determina aplicação é utilizada para gerar arquivos CSV a partir de uma lista de objetos (Record). Para realizar essas operações, os desenvolvedores precisam sempre manipular diretamente os métodos ConvertListToString<T>(T records), CreateStream(string content) e CreateFileCsv(Stream stream, string fileName).

**Problema**: como permitir que novas operações de geração de arquivos CSV possam ser realizadas com mais facilidade e flexibilidade? Além disso, como ocultar as etapas de geração do arquivo e possíveis mudanças futuras do código cliente?

# Solução

1. Implementar um serviço que encapsule a complexidade de geração de arquivos CSV
2. O novo serviço passa a expor uma interface de fácil uso
3. Para geração do arquivo CSV passa a ser necessário chamar somente um método (que encapusla a chamada dos outros três)

**Resultado final**: através de uma única chamada de método passa a ser possível gerar arquivos CSV. Possíveis alterações nas operações de geração do arquivo ou inclusões de novas operações intermediárias tendem a não impactar o código cliente (desde que a interface do serviço permaneça a mesma). 