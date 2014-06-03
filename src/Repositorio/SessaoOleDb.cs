namespace Dao.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.OleDb;

    public abstract class SessaoOleDb<TEntidade> : IDisposable where TEntidade : new()
    {
        private readonly OleDbConnection conexao;

        protected SessaoOleDb()
        {
            this.conexao = new OleDbConnection(
            ConfigurationManager.ConnectionStrings["imob"].ConnectionString);
            this.conexao.Open();
        }

        public void InserirEntidade(TEntidade entidade)
        {
            using (var command = this.conexao.CreateCommand())
            {
                command.CommandText = CommandoSql.MontarInsert(entidade);
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarEntidade(TEntidade entidade)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirEntidade(TEntidade entidade)
        {
            throw new System.NotImplementedException();
        }

        public IList<TEntidade> ConsultarEntidade()
        {
            OleDbDataReader resultado;

            using (var command = this.conexao.CreateCommand())
            {
                command.CommandText = CommandoSql.MontarConsulta<TEntidade>();
                resultado = command.ExecuteReader();
            }

            var entidades = new List<TEntidade>();
            
            while (resultado.Read())
            {
                var entidade = new TEntidade();

                entidade.GetType().GetProperty("Proprietario").SetValue(entidade, resultado["proprietario"], null);
                entidade.GetType().GetProperty("Tipo").SetValue(entidade, 0, null);
                entidade.GetType().GetProperty("Modalidade").SetValue(entidade, 1, null);

                entidades.Add(entidade);
            }

            return entidades;
        }

        public void Dispose()
        {
            this.conexao.Close();
        }
    }
}