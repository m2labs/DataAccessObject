namespace Dao.Repositorio
{
    public class CommandoSql
    {
        public static string MontarInsert(object entidade)
        {
            var tipo = entidade.GetType().GetProperty("Tipo");
            var modalidade = entidade.GetType().GetProperty("Modalidade");
            var proprietario = entidade.GetType().GetProperty("Proprietario");

            return string.Format(
                "insert into imovel (id, proprietario, tipo, modalidade) values (seq_imovel.nextval, '{0}', '{1}', '{2}')",
                proprietario.GetValue(entidade, null),
                tipo.GetValue(entidade, null),
                modalidade.GetValue(entidade, null));
        }

        public static string MontarConsulta<TEntidade>()
        {
            var assembly = typeof(TEntidade);

            return string.Format(
                "select * from {0}",
                assembly.Name);
        }
    }
}