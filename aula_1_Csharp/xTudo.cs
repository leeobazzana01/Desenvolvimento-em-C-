namespace exercicioOrientacaoObjetos
{
public class xTudo : Hamburguer
{
    public int Ovo { get; set; }
    public int Queijo { get; set; }
    public int Bacon { get; set; }

    //construtor x tudo
    public xTudo(int pao, int carne, int ovo, int queijo, int bacon) : base(pao, carne)
    {
        this.Pao = pao;
        this.Carne = carne;
        this.Ovo = ovo;
        this.Queijo = queijo;
        this.Bacon = bacon;
    }

    //métodos
    public void MontaXtudo()
    {
        Console.WriteLine("Montando o XTudo");
    }

    public void MostrarIngredientes()
    {
        Console.WriteLine($"Ingredientes do XTudo: \nPao: {Pao}, carne: {Carne}, Ovo: {Ovo}, Queijo: {Queijo}, Bacon: {Bacon}");
    }
}    
}
