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
            var teste = "Quarto Simples";

            if(teste == "Quarto Triplo"){
                var director = new DirectorRoom();
                TripleBuilder triple = new TripleBuilder();

                director.Triple(triple);
                TripleRoom tripleRoom = triple.Build();

                tripleRoom.Message();
                Console.WriteLine($"Descricao do Quarto: {tripleRoom.DescriptionRoom}");
    
            }else if(teste == "Quarto Duplo"){
                //var doubleRoom = new DirectorRoom(new DoubleBuilder());
                DoubleRoom double1 = new DoubleBuilder().Build();
                
                double1.Message();
                Console.WriteLine($"Descricao do Quarto: {double1.DescriptionRoom}");

            }else if(teste == "Quarto Simples"){
                //var simpleRoom = new DirectorRoom(new SimpleBuilder());
                SimpleRoom simple = new SimpleBuilder().Build();

                simple.Message();
                Console.WriteLine($"Descricao do Quarto: {simple.DescriptionRoom}");
                
            }
            
        }
    }
}
