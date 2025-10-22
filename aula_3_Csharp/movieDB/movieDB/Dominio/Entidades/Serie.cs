
namespace movieDB.Dominio.Entidades
{
    public class Serie : Filme
    {
        public Serie(int numeroDeEpisodios, int numeroDeTemporadas, 
            string titulo, string descricao, DateTime anoDeLancamento, 
            string diretor, string genero, double avaliacao, List<Ator> elenco) : base(titulo, 
                descricao, anoDeLancamento, diretor, genero, avaliacao, elenco)
        {
            NumeroDeEpisodios = numeroDeEpisodios;
            NumeroDeTemporadas = numeroDeTemporadas;
        }

        public int NumeroDeEpisodios { get; set; }
        public int NumeroDeTemporadas { get; set; }
    }
}
