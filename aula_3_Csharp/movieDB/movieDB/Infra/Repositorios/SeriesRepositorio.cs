using movieDB.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace movieDB.Infra.Repositorios
{
    public class SeriesRepositorio : IRepositorio<Serie>
    {
        public List<Serie> series; //criando uma lista de series 
    
        //construtor da lista
        public SeriesRepositorio()
        {
            series = new List<Serie>(); 
        }

        public List<Serie> BuscaDado(Serie serie)
        {
            var resultado = series.Where(x => x.Titulo == serie.Titulo).ToList();
            return resultado; //retornar o resultado, não a lista completa
        }

        public void InsereDado(Serie serie)
        {
            series.Add(serie); //adicionando na lista series
        }
        public void AtualizaDado(Serie serie)
        {
            var serieExistente = series.FirstOrDefault(x => x.Titulo == serie.Titulo);
            if(serieExistente != null)
            {
                serieExistente.Descricao = serie.Descricao;
                serieExistente.AnoDeLancamento = serie.AnoDeLancamento;
                serieExistente.Diretor = serie.Diretor;
                serieExistente.Genero = serie.Genero;
                serieExistente.Avaliacao = serie.Avaliacao;
                serieExistente.Elenco = serie.Elenco;
            }
        }
        public void DeletaDado(Serie serie)
        {
            var serieExistente = series.FirstOrDefault(x => x.Titulo == serie.Titulo);
            if(serieExistente != null)
            {
                series.Remove(serieExistente); //remove da lista de series
            }
        }
    }
}