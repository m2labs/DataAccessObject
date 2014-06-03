namespace Dao.Repositorio
{
    using System.Collections.Generic;

    public abstract class Dao<TEntidade> : SessaoOleDb<TEntidade>, IDao<TEntidade> where TEntidade : new()
    {
        public void Inserir(TEntidade entidade)
        {
            this.InserirEntidade(entidade);
        }

        public void Atualizar(TEntidade entidade)
        {
            this.AtualizarEntidade(entidade);
        }
        
        public void Excluir(TEntidade entidade)
        {
            this.ExcluirEntidade(entidade);
        }

        public IList<TEntidade> ListarTodos()
        {
            return this.ConsultarEntidade();
        }
    }
}
