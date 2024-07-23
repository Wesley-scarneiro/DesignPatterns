# Proxy Pattern

Exemplo de uso do padrão Proxy.

**Contexto**: uma aplicação web acessa um banco de dados para obter o catálogo de produtos registrados. O serviço ProductCatalogService realiza a consulta no banco e retorno dos dados. Como esse serviço é o mais utilizado na aplicação e afim de reduzir a latência da comunicação, decidiu-se armazenar os dados da consulta em um serviço de cache. Quando ProdutoCatalogService for chamado, deve-se primeiro consultar o cache para obter os dados. Se existir dados em cache, o resultado é retornado. Caso ao contrário, uma nova consulta ao banco de dados deve ser realizada.

**Problema**: como implementar o serviço de cache mantendo a alta coesão e baixo acoplamento com o serviço ProductCatalogService? Além disso, como manter o uso do cache transparente com o código cliente e o código base?

# Solução

1. Criar a classe ProductCatalogProxy que implementa a mesma interface de ProductCatalogService e que manipulará o cache
2. O código cliente deve passa a chamar ProductCatalogProxy ao invés de ProductCatalogService
3. O proxy passa a manipular as chamadas ao cache e ao ProductCatalogService

**Resultado final**: o código cliente e o serviço base permanecem isolados do serviço de cache. Além disso, a operação de cache é transparente para ambos. Se em algum momento for decidido que o cache não é mais necessário, basta volta a fornecer uma instância de ProductCatalogService ao código cliente.
