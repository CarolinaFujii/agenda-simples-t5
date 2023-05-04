using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_simples_t5
{
    internal class Contato
    {
        //Variáveis locais da classe Contato.
        //Acessiveis apenas pela classe Contato.
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        //PROPRIEDADES da classe Contato.
        //Acessiveis por qualquer parte desse programa.
        public string PrimeiroNome
        { 
            get { return primeiroNome; } 
            set { primeiroNome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00-00000-0000";
                }
            }
        }
        public Contato()
        {
            PrimeiroNome = "Carolina";
            Sobrenome = "Fujii";
            Telefone = "11-99988-8777";
        }
        //Sobrecarga de método.
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        //Sobreescrita do método ToString().
        public override string ToString()
        {
            //Melhor utilizar String.Empty invés de "".
            string saída = String.Empty;
            saída += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saída += String.Format("{0}-({1}-{2}", Telefone.Substring(0,1), Telefone.Substring(2,6), Telefone.Substring(7,10));
        }
    }
}
