# Decorator Pattern

Exemplos de uso do Decorator Pattern.

**Contexto**: uma aplicação possui dois serviços: ServiceOne e ServiceTwo. A aplicação passa a exigir alguns usos desses dois serviços com algumas
funcionalidades opcionais como cache e logging. Existem partes da aplicação que usam os serviços sem essas funcionalidades e outras
que as exigirão.

**Problema**: como implementar novos comportamentos às classes ServiceOne e ServiceTwo, sem criar subclasses para cada combinação
de funcionalidades opcionais? Como diminuir o acoplamento entre as classes existes e novas que deverão ser criadas?

# Solução
1. Criar uma classe abstrata ServiceDecorator que implementa ISomeService (interface dos serviços)
2. ServiceDecorator manipula um serviço, por composição, que implementa ISomeService
3. Criar subclasses ServiceCached e  ServiceLogging que herdam ServiceDecorator
4. As subclasses sobrescrevem o método base para adicionar suas funcionalidades (decoram o serviço)
5. As subclasses decoradoras chamam o método base de ServiceDecorator, que por sua vez chama o método do serviço alvo

**Resultado**: partes da aplicação que não exigem as novas funcionalidades nas classes não são impactadas, pois a instânciação com as funcionalidades não é obrigatória.
Por outro lado,  as novas classes de Cache e Logging são flexíveis para receber qualquer serviço compatível com a interface definida e se relacionam através da composição.
A solução por composição de classes também evita a criação de várias subclasses para cada combinação de funcionalidades (cache, cache com logging e logging).