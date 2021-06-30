using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class SingleBouquet : Bouquet
    {
        public SingleBouquet(string plan, int price)
        : base(plan, price)
        {
        }
        public SingleBouquet()
       : base()
        {
        }
        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{Plan} with the price {Price}");
            return Price;
        }
    }
}
