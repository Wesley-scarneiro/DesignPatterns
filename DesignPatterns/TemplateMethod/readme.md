# Template Method

Exemplos de uso do Template Method Pattern.

**Contexto**: uma aplicação realiza o processamento da folha de pagamento de funcionários públicos e CLTs. A fim de refatorar o
sistema, deseja-se ter métodos base pré-definidos para serem usados pelas subclasses que serão criadas - uma para funcionário
público e outra para funcionário CLT. No cálculo do salário líquido final, as subclasses devem calcular o desconto da previdência,
plano de saúde e outros descontos.

**Problema**: como garantir que as subclasses implementem todas as operações intermediárias necessárias, mas que não tenham 
a necessidade de implementar o método do cálculo do salário líquido final?

# Solução

1. Criar uma classe base abstrata que será herdada pelas subclasses
2. A classe base exige a implementação das operações intermediárias para as subclasses
3. As subclasses implementam somente as operações intermediárias
4. A classe base implementa o cálculo do salário líquido, chamando as implementações das subclasses 

**Resultado**: as subclasses passam a ter a responsabilidade de implementar somente as operações
intermediárias para o cálculo do salário líquido. A classe base fornece o método final que utilizará
as implementações das subclasses, garantindo o cálculo correto para cada caso.