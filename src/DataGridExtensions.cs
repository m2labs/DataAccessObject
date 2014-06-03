namespace Dao
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entidades;

    public static class DataGridExtensions
    {
        public static void Carregar(this DataGridView datagrid, IList<Imovel> imoveis)
        {
            datagrid.DataSource = imoveis;
        } 
    }
}