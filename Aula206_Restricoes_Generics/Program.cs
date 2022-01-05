using System;
using System.Globalization;
using System.Collections.Generic; // Biblioteca para utilizar listas
using Aula206_Restricoes_Generics.Entities;
using Aula206_Restricoes_Generics.Services;

namespace Aula206_Restricoes_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); // Cria lista de tipo "Product" e a instancia sem argumentos (vazia) 

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()); // Le 0 numero inteiro digitado e armazena na variavel int "n"

            for (int i = 0; i<n; i++) // Loop para entrada de dados baseado no numero inteiro digitado
            {
                string[] vect = Console.ReadLine().Split(','); // Vetor com elementos separados por virgula
                string name = vect[0]; // Atribui o primeiro elemento a posicao 0 do vetor
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture); // Atribui o segundo elemento a posicao 1 do vetor
                list.Add(new Product(name, price)); // Adiciona o nome e o valor a lista
            }

            CalculationService calculationService = new CalculationService(); // Instancia o servico "CalculationService"

            Product max = calculationService.Max(list); // Chama a funcao "Max", passando a lista como argumento

            Console.WriteLine("Max: " + max); // Exibe o valor da variavel "max"
        }
    }
}
