using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auladeclasses.src
{
    public class PersonagensSimpsons
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cabelo { get; set; }

        public PersonagensSimpsons(string _nome, int _idade, string _cabelo)

        {
            Nome = _nome;
            Idade = _idade;
            Cabelo = _cabelo;
        }

        public void beber(string cerveja)
        {
            Console.WriteLine($"Estou bebendo{cerveja}");
        }
        public void cuidar(string Maggie)
        {
            Console.WriteLine($"Estou cuidando da{Maggie}");
        }
        public void tocar(string saxofone)
        {
            Console.WriteLine($"Estou tocando{saxofone}");
        }
        public void zoar(string Skinner)
        {
            Console.WriteLine($"Estou zoando{Skinner}");
        }
        public void Chupar(string Chupeta)
        {
            Console.WriteLine($"Estou chupando{Chupeta}");
        }


    }

}

