namespace projeto_hotel.hotel.expenses
{
    public class Daily : Expenses
    {

        private string _descricao;

        private decimal _valor;

        public Daily(string descricao, decimal valor)
        {
            this.DescricaoDespesa = descricao;
            this.Valor = valor;

        }

        public override string DescricaoDespesa 
        {
            get { return _descricao; }
            set { _descricao = value; } 
        }

        public override decimal Valor 
        { 
            get { return _valor; }
            set { _valor = value; }  
        }

    }
}