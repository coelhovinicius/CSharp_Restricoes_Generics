using System;
using System.Globalization;

namespace Aula206_Restricoes_Generics.Entities
{
    class Product : IComparable // Parametrizacao IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product)) // Se o objeto nao for do tipo "Product"
            {
                throw new ArgumentException("Comparing error: argument is not a Product"); // Erro
            }
            Product other = obj as Product; // Downcasting "obj as Product"
            return Price.CompareTo(other.Price); // Compara os valores dos produtos
        }
    }
}
