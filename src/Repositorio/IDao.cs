namespace Dao.Repositorio
{
    using System.Collections.Generic;

    public interface IDao<TEntidade>
    {
        void Inserir(TEntidade entidade);

        void Atualizar(TEntidade entidade);

        void Excluir(TEntidade entidade);

        IList<TEntidade> ListarTodos();
    }
}