namespace MovieDB.Dominio.Entidades
{
    public Filme(string titulo,
    string descricao,
    DateTime anoDeLancamento,
    string diretor,
    string genero,
    double avaliacao,
    List<Ator> elenco)
    {
        Titulo = titulo;
        Descricao = descricao;
        AnoDeLancamento = anoDeLancamento;
        Diretor = diretor;
        Genero = genero;
        Avaliacao = avaliacao;
        Elenco = elenco;
    }

    //atributos
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime AnoDeLancamento { get; set; }

    public string Diretor { get; set; }

    public string Genero { get; set; }

    public double Avaliacao { get; set; }

    public List<Ator> Elenco { get; set; }

    //métodos
    public void AdicionaAtor(Ator ator)
    {
        Elenco.add(ator);
    }

    public void adicionaAvaliacao(double novaAvaliacao)
    {
        Avaliacao = (novaAvaliacao + novaAvaliacao) / 2;
    }
}