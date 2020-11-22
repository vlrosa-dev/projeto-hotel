using projeto_hotel.hotel.expenses.Creator;

namespace projeto_hotel.hotel.expenses.ConcreteCreator
{
    public class DailyFactory : ExpensesFactory
    {
        private string _descricao;
        private decimal _valor;

        public DailyFactory(string descricao, decimal valor)
        {
            this._descricao = descricao;
            this._valor = valor;
        }

        public override Expenses getExpenses()
        {
            return new Daily(_descricao, _valor);
        }
    }
}