using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Client : IEquatable<Client>
    {
        //Ctors
        public Client()
        {

        }
        public Client(string numero, string nom, string prenom, string tel)
        {
            Numero = numero;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }


        //Properties
        public string Numero { get; private set; }
        public Client SetNumero(string value)
        {
            Numero = value;
            return this;
        }
        public string Nom { get; private set; }
        public Client SetNom(string value)
        {
            if (value.Length < 2) return this;
            Nom = value;
            return this;
        }

        public string Prenom { get; private set; }
        public Client SetPrenom(string value)
        {
            Prenom = value;
            return this;
        }

        public string Tel { get; private set; }
        public Client SetTel(string value)
        {
            Tel = value;
            return this;
        }

        //Methods
        public override string ToString()
        {
            return $"{Nom} {Prenom} (N°:{Numero})";
        }

        public bool Equals(Client other)
        {
            return this.Nom == other.Nom &&
                this.Prenom == other.Prenom &&
                this.Numero == other.Numero;
        }
    }
}
