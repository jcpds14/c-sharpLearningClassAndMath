using ClassAndMath.Models;

//OPERADORES ARITMÉTICOS E A CLASSE MATH
Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(20, 10);

//Potência
calc.Potencia(3, 3);

//Trigonometria Seno, Coseno e Tangente

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

//INCREMENTO E DECREMENTO
Console.WriteLine("Digite o número para ser incrementado: ");
int numeroIncremento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Agora, Digite um número para ser decrementado: ");

int numeroDecremento = Convert.ToInt32(Console.ReadLine());

// if (numeroIncremento || numeroDecremento);
// {

// }

Console.WriteLine($"Incrementando {numeroIncremento}");
Console.WriteLine(++numeroIncremento);

Console.WriteLine($"Decrementando {numeroDecremento}");
Console.WriteLine(--numeroDecremento);

//Raiz Quadrada
calc.RaizQuadrada(9);