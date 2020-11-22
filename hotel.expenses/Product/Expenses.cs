namespace projeto_hotel.hotel.expenses
{
    public abstract class Expenses
    {
        
        public abstract string DescricaoDespesa { get; set; }
        
        public abstract decimal Valor { get; set; }

        public decimal CalculaTotal(){
            return Valor++;
        }

    }
}