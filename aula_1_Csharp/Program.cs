using System;
using System.Collections.Generic;

namespace exercicioOrientacaoObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //criando XTudo 
            xTudo xtudo_leo = new xTudo(1, 1, 1, 1, 1); // passando valores para pao, carne, ovo, queijo, bacon
            xtudo_leo.MontaXtudo();
            xtudo_leo.MostrarIngredientes();

            //criando Xbacon 
            xBacon xbacon_leo = new xBacon(1, 1, 1, 1); // pao, carne, queijo, bacon
            xbacon_leo.MontaXbacon();
            xbacon_leo.MostrarIngredientes();

        }
    }
}
