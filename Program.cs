using System;
using projeto_hotel;
using projeto_hotel.hotel.room.Double;
using projeto_hotel.hotel.room.Triple;
using projeto_hotel.hotel.booking;
using projeto_hotel.hotel.expenses.Creator;
using projeto_hotel.hotel.expenses.ConcreteCreator;
using projeto_hotel.hotel.expenses;

namespace projeto_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* CRIANDO OS QUARTOS DO HOTEL */
            //var _simple = new SimpleBuilder();
            //var _double = new DoubleBuilder();
            //var _triple = new TripleBuilder();
            
            /* DIRETORES QUE CONSTROEM PELO TIPO DO HOTEL*/
            //var _DirectorSimple = new DirectorRoom(_simple);
            //var _DirectorDouble = new DirectorRoom(_double);
            //var _DirectorTriple = new DirectorRoom(_triple);

            
            //_DirectorSimple.Make();
            //SimpleRoom a = _simple.build();

            //Console.WriteLine(a.DescriptionRoom);
            //a.Message();


            // FACTORYYYYYYYYYYYY

            ExpensesFactory expensesFactory = null;
            Console.Write("Digite o tipo de cartão que gostaria de obter:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "diaria":
                    expensesFactory = new DailyFactory("Diaria Do Hotel", 200);
                    break;
                
                case "alimento":
                    expensesFactory = new FoodFactory("Barra de Cereal", 5);
                    break;
                
                case "Telefone":
                    expensesFactory = new TelephoneFactory("Ligação 01", 19);
                    break;
                
                default:
                    break;
            }

            Expenses expenses = expensesFactory.getExpenses();
            Console.WriteLine($"Tipo de despesa: {expenses.DescricaoDespesa} e valor: {expenses.Valor}");
            Console.ReadKey();

            expensesFactory = new TelephoneFactory("Ligação 01", 19);

        }
    }
}
