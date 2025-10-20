// See https://aka.ms/new-console-template for more information
using System.Dynamic;

namespace exercicioOrientacaoObjetos
{

    //criando uma classe
    public class Hamburguer
    {

        //atributos dessa classe (características do hambúrguer)
        public int Pao { get; set; }
        public int Carne { get; set; }

        //construtor para criar um objeto hamburguer
        public Hamburguer(int pao, int carne)
        {
            this.Pao = pao;
            this.Carne = carne;
        }

        //métodos do hamburguer
        public void preparaChapa(int graus)
        {
            Console.WriteLine($"Chapa preparada a {graus} graus");
        }

        public void selaPao()
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
