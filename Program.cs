using auladeclasses.src;
using System;

namespace auladeclasses
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Os Simpsons");
            Console.WriteLine();
            PersonagensSimpsons Homer = new PersonagensSimpsons("Homer", 39, "preto, quase careca");
            PersonagensSimpsons Marge = new PersonagensSimpsons("Marge", 38, "azul");
            PersonagensSimpsons Lisa = new PersonagensSimpsons("Lisa", 8, "amarelo");
            PersonagensSimpsons Bart = new PersonagensSimpsons("Bart", 10, "amarelo");
            PersonagensSimpsons Maggie = new PersonagensSimpsons("Maggie", 1, "amarelo");

            Console.WriteLine($"O pai é o {Homer.Nome}, com {Homer.Idade} anos de idade e cabelo {Homer.Cabelo}");
            Console.WriteLine($"A mãe é a {Marge.Nome}, com {Marge.Idade} anos de idade e cabelo {Marge.Cabelo}");
            Console.WriteLine($"A filha é a {Lisa.Nome}, com {Lisa.Idade} anos de idade e cabelo {Lisa.Cabelo}");
            Console.WriteLine($"O filho é o {Bart.Nome}, com {Bart.Idade} anos de idade e cabelo {Bart.Cabelo}");
            Console.WriteLine($"A filha é a {Maggie.Nome}, com {Maggie.Idade} ano de idade e cabelo {Maggie.Cabelo}");

            Console.WriteLine();

            Homer.beber (" cerveja Duff");
            Marge.cuidar(" Maggie");
            Lisa.tocar (" saxofone");
            Bart.zoar(" com o Skinner");
            Maggie.Chupar(" chupeta");
        }
    }
}
