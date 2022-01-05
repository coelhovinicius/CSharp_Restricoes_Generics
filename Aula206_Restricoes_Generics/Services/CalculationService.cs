using System;
using System.Collections.Generic;

namespace Aula206_Restricoes_Generics.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable /* Funcao "Max" - Cria uma lista de valores do tipo
                                                             * generico "T", de nome "list", desde (where) que "T" seja 
                                                             * um tipo compativel com IComparable */
        {
            if (list.Count == 0) // Se a lista estiver vazia
            {
                throw new ArgumentException("The list cannot be empty"); // Erro
            }
            // Senao
            T max = list[0]; // Armazena o valor na posicao 0 da lista e armazena na variavel "max" 
            for (int i = 1; i < list.Count; i++) // Loop - Para cada valor da lista, a partir da posicao 1:
            {
                if (list[i].CompareTo(max) > 0) // Compara o valor da posicao 1 com a variavel "max"
                {
                    max = list[i]; // Armazena esse valor na variavel "max"
                }
            }
            return max; // Retorna o valor da variavel "max"
        }
    }
}
