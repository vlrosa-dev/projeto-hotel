using System;

namespace projeto_hotel.hotel.room.Triple
{
    public class TripleRoom
    {
        
        public string TypeRoom { get; set; }
        
        public int NumberRoom { get; set; }
        
        public string DescriptionRoom { get; set; }

        public decimal ValueRoom { get; set; }
        
        public void Message(){
            Console.WriteLine("Quarto Triplo Criado!");
        }
    }
}