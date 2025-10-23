using System.Security.Cryptography.X509Certificates;
using movieDB.Dominio.Entidades;

namespace movieDB.Infra.Repositorios
{
    public class FilmeRepositorio: IRepositorio<Filme>
    {
        public List<Filme> filme; //criando uma lista de filmes 
    
        //construtor da lista
        public FilmeRepositorio()
        {
            filmes = new List<Filme>(); 
        }
        public List<Filme> BuscaDado(Filme filme)
        {
            var resultado = filmes.Where(x => x.Titulo == filme.Titulo).ToList(); //analisa qual objeto da lista tem o mesmo titulo do titulo que estamos passando, nós retornamos filme 
            return filmes;
        }
        public void InsereDado(Filme filme)
        {
            filmes.Add(filme); //adicionando filme na lista de filmes
        }
        public void AtualizaDado(Filme filme)
        {
            var filmeExistente = filmes.FirstOrDefault(x => x.Titulo == filme.Titulo); //busca na lista de filmes por um filme que tenha o mesmo nome do objeto 
            if(filmeExistente != null)
            {
                filmeExistente.Descricao = filme.Descricao;
                filmeExistente.AnoDeLancamento = filme.AnoDeLancamento;
                filmeExistente.Diretor = filme.Diretor;
                filmeExistente.Genero = filme.Genero;
                filmeExistente.Avaliacao = filme.Avaliacao;
                filmeExistente.Elenco = filme.Elenco;
            }
        }
        public void DeletaDado(Filme filme)
        {
            var filmeExistente = filmes.FirstOrDefault(x => x.Titulo == filme.Titulo); //buscando na lista de filmes um filme c o mesmo nome do objeto

            if(filmeExistente != null)
            {
                filmes.Remove(filmeExistente); //removendo o filme
            }
        }
    }
}
