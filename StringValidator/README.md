# Problema

Os elementos de uma colecção de nomes têm um conjunto de propriedades a verificar. Para tal, foi criado um verificador automático que faz uso de avaliadores booleanos representados por objectos. Cada avaliador booleano tem uma função `IsValid` que aceita uma `string` e devolve um valor booleano.

Implemente os seguintes predicados e operadores:

- NonZeroLength
- LengthIsEven
- LengthIsOdd
- LengthGreaterThan
- LengthLesserThan
- LengthEqualTo
- And (operador binário que é verdadeiro quando dois elementos são verdadeiros)
- Or (operador binário que é falso quando dois elementos são falsos)
- Not (operador unário que é verdadeiro quando o seu argumento é falso)

## Exemplo

```c#
string s1 = "batata";
string s2 = "oo";
string s3 = "xyz";
IValidator validator = new Or(new And(new LengthGreaterThan(5), new LengthLesserThan(8)), new LengthEqualTo(2));
bool b1 = validator.IsValid(s1); // output: true
bool b2 = validator.IsValid(s2); // output: true
bool b3 = validator.IsValid(s3); // output: false
Console.WriteLine($"'{s1}' IsValid returned {b1}");
Console.WriteLine($"'{s2}' IsValid returned {b2}");
Console.WriteLine($"'{s3}' IsValid returned {b3}");
```