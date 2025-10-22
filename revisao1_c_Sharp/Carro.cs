// criar uma classe Carro
namespace exercicioRevisao1
{
    public class Carro
    {
        public string Modelo { get; set; }

        public string Fabricante { get; set; }

        public int Ano { get; set; }

        public bool Ligado = false;

        //criando um construtor
        public Carro(string modelo, string fabricante, int ano)
        {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }

        //método de dirigir 
        public void dirigeCarro()
        {
            
        }
    }
}