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

        public int Hp { get; set; }

        public int Speed { get; set; }

        public int Ataque { get; set; }

        public int Defesa { get; set; }

        public int Captura { get; set; }

        //construtor para criar um objeto hamburguer
        public Pokemon(string nome, string tipo, int level, int hp, int speed, int ataque, imt defesa, int ataca, int captura)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Level = level;
            this.Hp = hp;
            this.Speed = speed;
            this.Ataque = ataque;
            this.Defesa = defesa;
            this.Ataca = ataca;
            this.Captura = captura;
        }

        //métodos do Pokemon
        public void aparecerSelvagem(string nome, string tipo, int hp, int level)
        {
        Console.WriteLine($"O Pokemon {nome} do Tipo {tipo} Apareceu!{nome} tem hp {hp} Level {level});
        }

        public void capturaPokemon(string nome, string tipo, int level, int hp, int speed, int ataque, int defesa)
        {   
            if(level < 25 && level > 0){
                if(hp < 80){
                    Console.WriteLine($"Pokemon {nome} capturado!")    
                }
            }
            if(level >= 25 and level < 50){
                if(hp < 55){
                    Console.WriteLine($"Pokemon {nome} capturado!")
                }
                else{
                    Console.WriteLine($"Pokemon {nome} Escapou!")
                }
            }
            if(level >= 50 and level < 100){
                if(hp < 30){
                    Console.WriteLine($"Pokemon {nome} capturado!")
                }
                else{
                    Console.WriteLine($"Pokemon {nome} Escapou!")
                }
            }
        }
        
        public void batalhaPokemon(string nome, string tipo, int level, int hp, int speed, int ataque, int defesa)
        {   
            while(hp > 0 and hp != 0){
                if(hp <= 0){ //lógica dele morrer
                Console.WriteLine($"Pokemon {nome} falhou!")

                int xp = (level+speed+ataque+defesa)/(ataque*1)+(defesa*1)+(seed*1)+(level*3)

                Console.WriteLine($"Xp obtido {xp}!")
                //adicionar a lógica para adicionar xp      
                }
                else{
                    if(//adicionar a lógica da speed do meu pokjemon ser maior){
                        //colocar a lógica da perda de hp 
                    }
                }
            }
            
        }
        //construtor do Pokemon
        public void buildPokemon(string nome, string tipo, int level, int hp, int speed, int ataque, int defesa)
        {
            //receber os inputs do usuário
        }
    }
    
}
