using projeto_hotel.hotel.expenses.Creator;

namespace projeto_hotel.hotel.expenses.ConcreteCreator
{
    public class TelephoneFactory : ExpensesFactory
    {
        private string _descricao;
        private decimal _valor;

        public TelephoneFactory(string descricao, decimal valor)
        {
            this._descricao = descricao;
            this._valor = valor;
        }

        public override Expenses getExpenses()
        {
            return new Telephone(_descricao, _valor);
        }
    }
}