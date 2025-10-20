namespace exercicioOrientacaoObjetos
{
    public class xBacon : Hamburguer
{
    public int Queijo { get; set; }
    public int Bacon { get; set; }

    //construtor x tudo
    public xBacon(int pao, int carne, int queijo, int bacon) : base(pao, carne) 
    {
        this.Pao = pao;
        this.Carne = carne;
        this.Queijo = queijo;
        this.Bacon = bacon;
    }

    //métodos
    public void MontaXbacon()
    {
        Console.WriteLine("Montando o X Bacon");
    }

    public void MostrarIngredientes()
    {
        Console.WriteLine($"Ingredientes do XTudo: \nPao: {Pao}, carne: {Carne}, Queijo: {Queijo}, Bacon: {Bacon}");
    }

}    
}
