// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.IO.Compression;

namespace exercicioPokemonPOO
{

    //criando uma classe
    public class Pokemon
    {

        //atributos dessa classe (características do hambúrguer)
        public string Nome { get; set; }
        
        public string Tipo { get; set; }

        public int Ataca { get; set; }

        public int Level { get; set; }
        public int Captura { get; set; }

        //construtor para criar um objeto hamburguer
        public Pokemon(string nome, string tipo, int level, int ataca, int captura)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Level = level;
            this.Ataca = ataca;
            this.Captura = captura;
        }

        //métodos do Pokemon
        public void aparecerSelvagem(string nome, string tipo, int level)
        {
        Console.WriteLine($"O Pokemon {nome} do Tipo {tipo} Apareceu!{nome} tem Level {level});
        }

        public void capturaPokemon()
        {
            Console.WriteLine("Pão Selado");
        }

        public void assaCarne()
        {
            Console.WriteLine("Assando a carne");
        }

        //mostrando a montagem do hamburguer
        public void montaHamburguer()
        {
            Console.WriteLine("Montando Hamburguer");
        }

        public void MostrarIngredientes()
        {
            Console.WriteLine($"Pao: {Pao}, carne: {Carne}");
        }
    }
    
}
