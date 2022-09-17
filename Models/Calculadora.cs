using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAndMath.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;//cálculo para encontrar o valor radiano do Seno, Coseno e Tangente
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");//Math.Round serve para diminuir a quantidade números depois do ponto
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;//cálculo para encontrar o valor radiano do Seno, Coseno e Tangente
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");//Math.Round serve para diminuir a quantidade números depois do ponto
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;//cálculo para encontrar o valor radiano do Seno, Coseno e Tangente
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");//Math.Round serve para diminuir a quantidade números depois do ponto
        }

        public void RaizQuadrada(double raiz)
        {
            double raizQuadrada = Math.Sqrt(raiz);
            Console.WriteLine($"Raiz Quadradada de {raiz} é: {raizQuadrada}");
        }
    }
}