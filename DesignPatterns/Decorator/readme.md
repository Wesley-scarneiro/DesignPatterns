# Decorator Pattern

Exemplos de uso do Decorator Pattern.

**Contexto**: uma aplica��o possui dois servi�os: ServiceOne e ServiceTwo. A aplica��o passa a exigir alguns usos desses dois servi�os com algumas
funcionalidades opcionais como cache e logging. Existem partes da aplica��o que usam os servi�os sem essas funcionalidades e outras
que as exigir�o.

**Problema**: como implementar novos comportamentos �s classes ServiceOne e ServiceTwo, sem criar subclasses para cada combina��o
de funcionalidades opcionais? Como diminuir o acoplamento entre as classes existes e novas que dever�o ser criadas?

# Solu��o
1. Criar uma classe abstrata ServiceDecorator que implementa ISomeService (interface dos servi�os)
2. ServiceDecorator manipula um servi�o, por composi��o, que implementa ISomeService
3. Criar subclasses ServiceCached e  ServiceLogging que herdam ServiceDecorator
4. As subclasses sobrescrevem o m�todo base para adicionar suas funcionalidades (decoram o servi�o)
5. As subclasses decoradoras chamam o m�todo base de ServiceDecorator, que por sua vez chama o m�todo do servi�o alvo

**Resultado**: partes da aplica��o que n�o exigem as novas funcionalidades nas classes n�o s�o impactadas, pois a inst�ncia��o com as funcionalidades n�o � obrigat�ria.
Por outro lado,  as novas classes de Cache e Logging s�o flex�veis para receber qualquer servi�o compat�vel com a interface definida e se relacionam atrav�s da composi��o.
A solu��o por composi��o de classes tamb�m evita a cria��o de v�rias subclasses para cada combina��o de funcionalidades (cache, cache com logging e logging).