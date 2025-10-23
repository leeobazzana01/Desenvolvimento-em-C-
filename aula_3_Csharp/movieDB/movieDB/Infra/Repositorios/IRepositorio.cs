namespace movieDB.Infra.Repositorios
{
    public interface IRepositorio<T> where T : class
    {
        List<T> BuscaDado(T entidade);
        Task InsereDado(T entidade);
        Task AtualizaDado(T entidade);
        Task DeletaDado(T entidade);

    }
}
