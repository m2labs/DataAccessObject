namespace Dao
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entidades;
    using Repositorio;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InserirButtonClick(object sender, System.EventArgs e)
        {
            var imovelRepositorio = new ImovelRepositorio();

            var imovel = new Imovel
            {
                Modalidade = (Modalidade) this.modalidadeComboBox.SelectedIndex,
                Tipo = (Tipo)this.tipoComboBox.SelectedIndex,
                Proprietario = this.proprietarioTextBox.Text
            };

            imovelRepositorio.Inserir(imovel);

            var imoveis = imovelRepositorio.ListarTodos();
            this.ImoveisGridView.Carregar(imoveis);
        }

        private void Form1Load(object sender, System.EventArgs e)
        {
            var imovelRepositorio = new ImovelRepositorio();
            var imoveis = imovelRepositorio.ListarTodos();

            this.ImoveisGridView.Carregar(imoveis);
        }
        
       
    }
}
