using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Bouquet
    {
        public string Plan { get; set; }
        public string Color { get; set; }
        public string Proportions { get; set; }
        public int Price { get; set; }

        public Bouquet(string plan, int price)
        {
            this.Plan = plan;
            this.Price = price;
        }
        public Bouquet()
        {
        }
        public abstract int CalculateTotalPrice();

        public override string ToString() =>
            new StringBuilder()
            .AppendLine(Plan)
            .AppendLine(Color)
            .AppendLine(Proportions)
        .ToString();
    }
}
