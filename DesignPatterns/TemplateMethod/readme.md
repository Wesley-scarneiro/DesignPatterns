# Template Method

Exemplos de uso do Template Method Pattern.

**Contexto**: uma aplica��o realiza o processamento da folha de pagamento de funcion�rios p�blicos e CLTs. A fim de refatorar o
sistema, deseja-se ter m�todos base pr�-definidos para serem usados pelas subclasses que ser�o criadas - uma para funcion�rio
p�blico e outra para funcion�rio CLT. No c�lculo do sal�rio l�quido final, as subclasses devem calcular o desconto da previd�ncia,
plano de sa�de e outros descontos.

**Problema**: como garantir que as subclasses implementem todas as opera��es intermedi�rias necess�rias, mas que n�o tenham 
a necessidade de implementar o m�todo do c�lculo do sal�rio l�quido final?

# Solu��o

1. Criar uma classe base abstrata que ser� herdada pelas subclasses
2. A classe base exige a implementa��o das opera��es intermedi�rias para as subclasses
3. As subclasses implementam somente as opera��es intermedi�rias
4. A classe base implementa o c�lculo do sal�rio l�quido, chamando as implementa��es das subclasses 

**Resultado**: as subclasses passam a ter a responsabilidade de implementar somente as opera��es
intermedi�rias para o c�lculo do sal�rio l�quido. A classe base fornece o m�todo final que utilizar�
as implementa��es das subclasses, garantindo o c�lculo correto para cada caso.