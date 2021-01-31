using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CompteEpargne : Compte
    {
        public CompteEpargne(Client client)
        {
            TauxInteret = 0.05m;
        }

        public decimal TauxInteret { get; set; }

        public CompteEpargne Crediter(decimal amount)
        {
            Balance += amount;
            return this;
        }

        public CompteEpargne Debiter(decimal amount)
        {
            if (Balance - amount < 0)
            {
                return this;
            }
            else
            {
                Balance -= amount;
                return this;
            }
        }

        public CompteEpargne CalculerInteret(int days)
        {
            decimal parsedInYears = days / 365;
            decimal coefficient = (decimal)TauxInteret * parsedInYears;
            Balance += Balance * coefficient;
            return this;
        }

    }
}
