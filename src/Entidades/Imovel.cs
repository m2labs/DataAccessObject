namespace Dao.Entidades
{
    public class Imovel : Entidade
    {
        public string Proprietario { get; set; }    

        public Tipo Tipo { get; set; }

        public Modalidade Modalidade { get; set; }
    }
}