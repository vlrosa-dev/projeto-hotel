using System;
using projeto_hotel.hotel.room;
using projeto_hotel.hotel.room.Double;
using projeto_hotel.hotel.room.Triple;

namespace projeto_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* CRIANDO OS QUARTOS DO HOTEL */
            var _simple = new SimpleBuilder();
            var _double = new DoubleBuilder();
            var _triple = new TripleBuilder();
            
            /* DIRETORES QUE CONSTROEM PELO TIPO DO HOTEL*/
            var _DirectorSimple = new DirectorRoom(_simple);
            var _DirectorDouble = new DirectorRoom(_double);
            var _DirectorTriple = new DirectorRoom(_triple);

            _DirectorSimple.Make();
            SimpleRoom a = _simple.build();

            Console.WriteLine(a.DescriptionRoom);
            a.Message();
            
        }
    }
}
