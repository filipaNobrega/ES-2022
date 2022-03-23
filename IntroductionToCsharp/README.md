# Introdução ao C#

## Declaração e utilização de variáveis

```csharp
const string FriendName = "Scoot";
Console.WriteLine("Hello " + friendName + "!"); // concatenação de strings
```

```csharp
Console.WriteLine("Enter your friend's name, and then press Enter:");
string friendName = Console.ReadLine();
Console.WriteLine($"Hello {friendName}!"); // string interpolation
```

## Conversões entre tipos numéricos

As conversões entre tipos numéricos podem ser `implícitas` ou `explícitas`.

Numa conversão `implícita`, nenhuma sintaxe especial é necessária porque a conversão sempre é bem sucedida e nenhuma informação será perdida.

```c#
int age = 78;
double ageAsDouble = weight;
Console.WriteLine(number);
```

As conversões `explícitas` exigem uma expressão de conversão, que é chamada de _cast_. Pode haver perda de informação na conversão ou pode falhar por outros motivos.

```c#
double weight = 78.7;
int integral = (int) weight;
```

Ao realizar o `casting` para o tipo `int` do valor contido em `weight`, somente a parte inteira do valor inicial é considerada, "perdendo-se" a parte fracionária.

## Operações Aritméticas

```c#
int addResult = 15 + 10;
Console.WriteLine($"The result of 15 + 10 is {addResult}");
int subtractResult = 15 - 10;
Console.WriteLine($"The result of 15 - 10 is {subtractResult}");
int multResult = 25 * 5;
Console.WriteLine($"The result of 25 * 5 is {multResult}");
double divResult = 45 / 2;
// Resultado esperado: 22.5 Resultado obtido: 22
// Divisão de 2 números inteiros, resulta em 1 número inteiro
Console.WriteLine($"The result of 45 / 2 is {divResult}");
```

```c#
// Dada a largura e o comprimento de uma sala, calcula o preço de uma carpete por metro quadrado
const double PricePerSquareFoot = 5.50;
Console.WriteLine("Enter the length of your room, and then press Enter:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of your room, and then press Enter:");
double width = double.Parse(Console.ReadLine());

double area = length * width;
double price = area * PricePerSquareFoot;

Console.WriteLine($"The total price is {0}!", price);
```

## If-Else

A instrução `if-else` identifica qual instrução executar com base no valor de uma expressão booleana.

É comum utilizarmos **operadores lógicos**, tais como:

- Operador de negação lógica `!`
- Operador AND lógico condicional `&&`, não avalia o operando à direita se o operando à esquerda for avaliado como `false`
- Operador OR lógico condicional `||`, não avalia o operando à direita se o operando à esquerda for avaliado como `true`

```c#
// Verifique se um número é par ou ímpar
Console.WriteLine("Enter a number, and then press Enter:");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
if (isEven) {
    Console.WriteLine($"The value {number} is even!");
} else {
    Console.WriteLine($"The value {number} is odd!");
}
// O operador condicional ?: avalia uma expressão booliana e retorna o resultado de uma das duas expressões.
// Console.WriteLine("The value {0} is {1}!", number, number % 2 == 0 ? "even" : "odd");
```

```c#
// Dada a largura e o comprimento de um jardim, determine o preço do serviço de jardinagem
Console.WriteLine("Enter the length of your yard, and then press Enter:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of your yard, and then press Enter:");
double width = double.Parse(Console.ReadLine());

double area = length * width;
double price;

if (area < 400.0)
{
    price = 25.0;
}
else if(area >= 400.0 && area < 600.0)
{
    price = 35.0;
}
else
{
    price = 50.0;
}
Console.WriteLine("The weekly fee is {0} euros.", price);
```

## Switch

A instrução `switch` seleciona uma única _secção de opção_ para executar a partir de uma lista de possibilidades, e é geralmente usada como uma alternativa à instrução `if-else`, se uma única expressão é testada com três ou mais condições. Em suma, a instrução `switch` é um conjunto de instruções `if`.

```c#
// Dada a largura e o comprimento de um jardim, determine o preço do serviço de jardinagem
Console.WriteLine("Enter the length of your yard, and then press Enter:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of your yard, and then press Enter:");
double width = double.Parse(Console.ReadLine());

double area = length * width;
double price;
switch(area) {
    case < 400.0:
        price = 25.0;
        break;
    case >= 400.0 and < 600.0:
        price = 35.0;
        break;
    default:
        price = 35.0;
        break;
}
Console.WriteLine("The weekly fee is {0} euros.", price);
```

## While

A instrução `while` executa uma instrução ou um bloco de instruções com base no valor de uma expressão booleana.

```c#
int i = 1;
while (i <= 5)
{
    Console.WriteLine("C# Loop: Iteration {0}", i);
    i++;
}
```

## Do-While

Um loop `do-while` é executado uma ou mais vezes, uma vez que a expressão booleana é avaliada após cada execução do loop.

```c#
int i = 1;
do
{
    Console.WriteLine("C# Loop: Iteration {0}", i);
    i++;

    Console.Write("Press Escape (Esc) key to exit...");
} while (Console.ReadKey().Key != ConsoleKey.Escape);
```

## For

A instrução `for` executa uma instrução ou um bloco de instruções com base no valor de uma expressão booleana.

```c#
// for (inicializador; condição; iterador)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("C# Loop: Iteration {0}", i);
}
```

## Coleções de dados

As coleções fornecem uma maneira mais flexível de trabalhar com grupos de objetos.

```c#
int[] array = new [] { 0, 1, 1, 2, 3, 5, 8, 13 };
Console.WriteLine("Number of elements: {0}", array.Length);
for (int index = 0; index < array.Length; index++)
{
    Console.WriteLine($"Element #{index}: {array[index]}");
}
```

A instrução `foreach` executa uma instrução ou um bloco de instruções para cada elemento em uma instância do tipo que representa uma coleção (mais corretamente, que implementa `IEnumerable<T>`).

Os `genéricos` apresentam o conceito de tipos paramétricos, o que possibilita definir estruturas de dados fortemente tipificadas sem se comprometer com um tipo de dados real.

```c#
var names = new List<string> { "João", "Ana", "Filipe" };
// Modificar o conteúdo de uma lista
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Ana");

// Pesquisar e classificar listas
// var index = names.IndexOf("Felipe");
// if (index != -1)
//   Console.WriteLine($"The name {names[index]} is at index {index}");
// var notFound = names.IndexOf("Not Found");
// Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
// names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
```

## Tipo de estrutura (Struct)

Um tipo de estrutura (ou tipo de `struct`) é um tipo de valor que pode encapsular dados e funcionalidade relacionada.
No C#, os tipos de estrutura assumem uma semântica de tipo por valor.

```c#
public readonly struct Digit
{
    private readonly byte digit;
    public Digit(byte digit)
    {
        if (digit > 9)
        {
            throw new ArgumentOutOfRangeException(
                nameof(digit), "Digit cannot be greater than nine.");
        }
        this.digit = digit;
    }

    public static implicit operator byte(Digit d) => d.digit;
    public static explicit operator Digit(byte b) => new Digit(b);

    public override string ToString() => $"{digit}";
}
public static void Main()
{
    var digit = new Digit(7);

    byte number = digit;
    Console.WriteLine(number);

    Digit newDigit = (Digit) number;
    Console.WriteLine(newDigit);
}
```

## Classes

Classes são declaradas usando a palavra-chave `class`. Umas classe é uma especificação para um determinado tipo de objeto.

```c#
//[access modifier] - [class] - [identifier]
public class Base
{
    public virtual int    GetLevel() { return 1; }
    public virtual string GetKind()  { return "I'm an instance of Base"; }
}
```

Nas classes, o `encapsulamento` é obtido por meio da limitação do acesso externo ao estado interno da classe usando **modificadores de acesso**.

Os objetos podem ser criados usando a palavra-chave `new`, seguida pelo nome da classe na qual ele se baseará, dessa maneira:

```c#
// Object initializers
Base b1 = new Base();
Console.WriteLine( "b1.GetLevel() returns " + b1.GetLevel() );
// Output: `b1.GetLevel() returns 1`
Console.WriteLine( "b1.GetKind() returns " + b1.GetKind() );
// Output: `b1.GetKind() returns I'm an instance of Base`
...
```

Vejamos o que acontece quando criámos uma classe derivada da classe `Base`:

Este fragmento de código apresenta a `herança` em C#. A `herança` permite-nos criar novas classes que reutilizam, estendem e modificam o comportamento definido em outras classes.

```c#
public class Derived : Base
{
    public int    GetLevel() { return 1; }
    public string GetKind()  { return "I'm an instance of Derived"; }
}
```

```c#
Derived derived = new Derived() { Height = 50, Width = 20 };
Console.WriteLine( "derived.GetLevel() returns " + derived.GetLevel() );
// Output: `derived.GetLevel() returns 2`
Console.WriteLine( "derived.GetKind() returns " + derived.GetKind() );
// Output: `derived.GetKind() returns I'm an instance of Derived`
```

O _output_ obtido não evidencia qualquer problema, dado que o `rectangle` referencia uma instância da classe `Rectangle`. No entanto, devemos notar que os métodos `GetLevel` e `GetKind` estão definidos simultaneamente na classe `Base` e `Derived`. Na linguagem C# esta situação não resulta em qualquer erro de compilação, sendo assinalada pelo compilador através do seguinte _warning_:

`'Base.GetLevel()' hides inherited member 'Derived.GetLevel()'. Use the new keyword if hiding was intended.`

`'Base.GetKind()' hides inherited member 'Derived.GetKind()'. Use the new keyword if hiding was intended.`

A sugestão contida nesta mensagem é que devemos de utilizar a _keyword_ `new` para indicar que é intensão do programador esconder o atributo herdado:

```c#
public class Derived : Base
{
    public new int    GetLevel() { return 1; }
    public new string GetKind()  { return "I'm an instance of Derived"; }
}
```

Após esta definição o _warning_ deixará de ser emitido pelo compilador.

> Salienta-se que este tipo de situação configura um designado "_bad code smell_" e, regra geral, resulta de um incorreto desenho do sistema.

Embora a situação anterior possa ser considerado normal (e é), existem construções que exibem um comportamento que poderá não ser o esperado.

Considere a seguinte instanciação desta classe:

Este fragmento de código apresenta o `polimorfismo` em C#. O `polimorfismo` permite-nos ter várias classes que podem ser usadas de forma intercambiável, ainda que cada classe implemente as mesmas propriedades ou métodos de maneiras diferentes.

```c#
Base derived = new Derived();
Console.WriteLine( "derived.GetLevel() returns " + derived.GetLevel() );
// Output: `derived.GetLevel() returns 1`
Console.WriteLine( "derived.GetKind() returns " + derived.GetKind() );
// Output: `derived.GetKind() returns I'm an instance of Base`
```

O _output_ para a variável `derived` poderá parecer estranho.

Nas linguagens OOP, existe sempre a possibilidade de permitir às subclasses sobrepor o comportamento definido nas superclasses através da definição de **métodos virtuais**.

Considere o seguinte fragmento de código:

```c#
class Base
{
    public virtual int    GetLevel() { return 1; }
    public virtual string GetKind()  { return "I'm an instance of Base"; }
}

class Derived : Base
{
    public override int    GetLevel()   { return 2; }
    public override string GetKind()    { return "I'm an instance of Derived"; }
}
```

Após estas alterações, a execução da sequência abaixo:

```c#
Base derived = new Derived();
Console.WriteLine( "derived.GetLevel() returns " + derived.GetLevel() );
// Output: `derived.GetLevel() returns 2`
Console.WriteLine( "derived.GetKind() returns " + derived.GetKind() );
// Output: `derived.GetKind() returns I'm an instance of Derived`
```

O _output_ para a variável `derived` está mais de acordo com o que era esperado.

### Pseudo-variável `base`

No caso anterior, uma versão melhorada do método `GetLevel()` deveria somar uma unidade ao resultado da invocação do mesmo método da superclasse. Para esta situações, existe uma pseudo-variável designada por `base` que permite aceder aos elementos da superclasse.

Assim, obtemos a seguinte implementação para o método `GetLevel()`:

```c#
class Derived : Base
{
    public override int    GetLevel()   { return base.GetLevel() + 1; }
    public override string GetKind()    { return "I'm an instance of Derived"; }
}
```

Esta pseudo-variável também é utilizada para evocar o construtor da superclasse, dessa maneira:

```c#
class Base
{
   public Base(string description)
   {
       Description = description;
   }
   public string Description { get; };
   public virtual int    GetLevel() { return 1; }
   public virtual string GetKind()  { return "I'm an instance of Base"; }
}
class Derived : Base
{
   public Derived(string description) : base( description )
   {
   }
   public override int    GetLevel()   { return 2; }
   public override string GetKind()    { return "I'm an instance of Derived"; }
}
```

### Classes abstractas

As classes abstratas são classes que representam conceitos que são abstratos e que não faz sentido existirem instâncias. Quando uma classe é marcada como `absract`, o compilador não permite que seja o operador `new` para criar instâncias dessa classe.

A classe `Base` é claramente candidata a ser uma classe abstrata:

```c#
public abstract class Base
{
    public virtual int    GetLevel() { return 1; }
    public virtual string GetKind()  { return "I'm an instance of Base"; }
}
```

O seguinte código:

```c#
Shape a = new Base():
```

Produz a seguinte mensagem de erro:

`Cannot create an instance of the abstract class or interface 'Base'`

De notar que uma classe abstrata não necessita de ter um método abstrato, mas se uma classe possui uma classe um método abstrata, então essa classe tem de ser definida como abstrata.

Os **métodos abstratos** são métodos cujo comportamento não está definido, o que obriga a que esse comportamento seja definido nas subclasses.

```c#
abstract class Base
{
    protected Base(string description)
    {
        Description = description;
    }
    public string Description { get; };
    public virtual int    GetLevel() { return 1; }
    public virtual string GetKind()  { return "I'm an instance of Base"; }
    public abstract string GetHash();
}
```

Na definição anterior, foi introduzido o método abstrato `GetHash()` na classe `Base`. De notar que na definição deste método não existe comportamento associado.

```c#
class Derived : Base
{
    public Derived( string description ) : base( description )
    {
    }
    public override int    GetLevel()   { return 2; }
    public override string GetKind()    { return "I'm an instance of Derived"; }
    public override string GetHash() { return System.Guid.NewGuid().ToString(); }
}
```

Na sobreposição do método abstrato é necessário utilizar a _keyword_ `override` como no caso dos métodos virtuais.

### Selagem de Classes e de Métodos Virtuais

A partir do momento em que um método é declarado virtual ou abstrato, este pode ser redefinido por qualquer das subclasses. No contexto da criação de bibliotecas ou por opção de desenho, existem situações em que não é desejável que seja possível criar subclasse de uma dada classe. Essa decisão pode ser expressa através da utilização da _keyword_ `sealed` na declaração da classe:

```c#
sealed class DerivedDerived : Derived
{
    DerivedDerived( string description ) : base( description ) {}
}
```

Dado que a classe `DerivedDerived` está "selada", não é possível definir subclasse.

Caso a decisão seja selar alguns métodos, em vez de toda a classe (obviamente, não faz sentido selar um método de uma classe selada), tal pode ser indicado através da utilização da mesma _keyword_ na declaração do método:

```c#
class DerivedDerived : Derived
{
    DerivedDerived( string description ) : base( description ) {}

    public sealed override int GetLevel() { return base.GetLevel() + 1; }
}
```

No caso anterior, o método `GetLevel()` foi selado e nenhuma subclasse de `DerivedDerived` pode realizar a sobreposição deste método.

## Interfaces

Uma `interface` contém definições para um grupo de funcionalidades relacionadas que uma classe ou uma struct deve implementar.

Em c# define-se uma interface usando a palavra-chave `interface`, dessa maneira:

```c#
interface IEquatable<T>
{
    bool Equals(T obj);
}
```

Por convenção, os nomes de interface começam com uma letra maiúscula `I`.

Considere a seguinte implementação desta interface:

```c#
public class Car : IEquatable<Car>
{
    public string Make {get; set;}
    public string Model { get; set; }
    public string Year { get; set; }

    // Implementation of IEquatable<T> interface
    public bool Equals(Car car)
    {
        return (this.Make, this.Model, this.Year) ==
            (car.Make, car.Model, car.Year);
    }
}
```

# 1ª Ficha Prática

1. Escreva um programa em C# que leia 2 números inteiros a partir do teclado e escreva no ecrã o maior deles.

2. Escreva um programa em C# que leia 10 números inteiros a partir do teclado e escreva no ecrã a soma e a média dessa sequência de entrada.

3. Escreva um programa em C# que leia uma sequência de 10 inteiros e escreva no ecrã a sequência de entrada por ordem inversa.

4. Escreva um programa em C# que calcule o máximo divisor comum entre dois naturais.

5. Escreva um programa em C# que leia um ficheiro de texto e escreva o conteúdo desse ficheiro no ecrã sem espaços ou mudanças de linha e utilizando somente maiúsculas.

6. Escreva um programa em C# que mostre no ecrã os primeiros 20 números da série de Fibonacci: 1, 1, 2, 3, 5, 8, 13, ...

7. Escreva um programa em C# que leia 2 números decimais a partir do teclado, mostre no ecrã uma lista de opções (soma, subtração, multiplicação e divisão), aceite a escolha do utilizador (só pode escolher uma opção) e escreva no ecrã o resultado da operação aritmética.

8. Escreva um programa em C# que leia uma linha de texto a partir do teclado até ao máximo de 60 caracteres e escreva no ecrã o número de caracteres, o número de palavras, o número de caracteres maiúsculos, o número de caracteres minúsculos e o número de caracteres numéricos.

9. Escreva um programa em C# que leia uma linha de texto a partir do teclado, converta o texto para maiúsculas e escreva a linha convertida no ecrã. O programa deve repetir o processamento até que o utilizador introduza o número 0.

10. Dada uma sequência de N números inteiros, calcular os seguintes resultados:

    a) o mínimo valor da sequência;

    b) os três maiores valores da sequência;

    c) a média dos valores da sequência;

    d) o número de valores superiores a 10;

    e) a percentagem de valores superiores a 10;

    f) a média dos valores superiores a 10.
