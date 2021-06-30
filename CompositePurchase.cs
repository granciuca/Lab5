using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class CompositePurchase : Bouquet, ICompositeOperations
    {
        private List<Bouquet> _bouquet;
        public CompositePurchase(string name, int price)
            : base(name, price)
        {
            _bouquet = new List<Bouquet>();
        }
        public void Add(Bouquet element)
        {
            _bouquet.Add(element);
        }
        public void Remove(Bouquet element)
        {
            _bouquet.Remove(element);
        }
        public override int CalculateTotalPrice()
        {
            int total = 0;
            Console.WriteLine($"{Plan} contains the following products with prices:");
            foreach (var element in _bouquet)
            {
                total += element.CalculateTotalPrice();
            }
            return total;
        }

    }
}
