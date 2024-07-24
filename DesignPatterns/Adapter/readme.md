# Adapter Pattern

Exemplos de uso do padrão Adapter (ou Wrapper).

 **Contexto**: uma aplicação utiliza um serviço de arquivo existente para realizar a leitura de arquivos recuperados do disco. Contudo, deseja-se passar a consumir um serviço de arquivos em nuvem e o provedor escolhido foi a AWS. O Objetivo é deixar de ler os arquivos diretamente do disco e passar a acessá-los pelo serviço S3 da AWS.

 **Problema**: como implementar o serviço S3 da AWS na aplicação sem realizar a alteração das classes e interfaces já existentes? Além disso, como tornar o serviço que manipula arquivos, seja local ou na nuvem, transparente do código cliente?

 # Solução

1. reutilizar a interface IFileService, que era implementada pelo serviço de arquivo local
2. Criar o adaptador AdapterProviderAWS que implementa IFileService e manipula o serviço AWS
3. O código cliente passa a receber o adaptador AdapterProviderAWS para manipular o serviço de arquivos

**Resultado final**: o código cliente permanece desacoplado com o serviço em nuvem implementado e transparente com a operação de obtenção de arquivos (tanto faz se o serviço é on-premisses ou cloud).