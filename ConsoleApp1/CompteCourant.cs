using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CompteCourant : Compte
    {
        public decimal MaxDecouvert { get; private set; }

        public CompteCourant(Client client)
        {
            MaxDecouvert = -200.0m;
        }

        public CompteCourant Crediter(decimal amount)
        {
            Balance += amount;
            return this;
        }

        public CompteCourant Debiter(decimal amount)
        {
            if (Balance - amount < MaxDecouvert)
            {
                return this;
            }
            else
            {
                Balance -= amount;
                return this;
            }
        }



    }
}
