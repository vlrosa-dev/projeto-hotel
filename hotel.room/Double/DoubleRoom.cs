using System;

namespace projeto_hotel.hotel.room
{
    public class DoubleRoom
    {
        public string TypeRoom { get; set; }
        
        public string DescriptionRoom { get; set; }

        public decimal ValueRoom { get; set; }
        
        public void Message(){
            Console.WriteLine("Quarto Duplo Criado!");
        }
    }
}