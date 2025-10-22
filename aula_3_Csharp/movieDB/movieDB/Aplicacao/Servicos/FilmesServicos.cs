using movieDB.Dominio.Entidades;

namespace movieDB.Aplicacao.Servicos
{
    public class FilmesServicos
    {
        public void CriaFilme(Filme filme)
        {
            Console.WriteLine($"Filme criado com sucesso!\n {filme}");
        }
        public void AtualizaFilme(Filme filme)
        {
            Console.WriteLine($"Filme atualizado: \n {filme}");
        }
        public List<Filme> BuscaTodosFilmes()
        {
            return new List<Filme>();
        }
        public Filme BuscarFilmePorNome(string nome)
        {
            return null;
        }
        public void DeletaFilme(Filme filme)
        {
            Console.WriteLine($"Filme deletado: \n {filme}");
        }
    }
}
