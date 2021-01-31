using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Compte
    {
        public decimal Balance { get; set; }
        public string Numero { get; }
        public static int LastNumero { get; private set; }
        public Client Client { get; set; }


        public Compte()
        {

        }

        public Compte(Client client)
        {
            Balance = 0.0m;
            int tmp = LastNumero + 1;
            Numero = "CMPT" + tmp;
            Client = client;
            LastNumero++;

        }
    }
}
