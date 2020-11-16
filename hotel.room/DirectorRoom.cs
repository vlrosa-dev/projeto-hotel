using projeto_hotel.hotel.room.Double;
using projeto_hotel.hotel.room.Triple;

namespace projeto_hotel.hotel.room
{
    public class DirectorRoom
    {
        private IRoom _room;

        public IRoom Simple(SimpleBuilder _simpleBuilder){
            return _simpleBuilder.TypeRoom("Quarto Simples")
                                 .ValueRoom(1000)
                                 .DescriptionRoom("Quarto para uma pessoa!");
        }

        public IRoom Double(DoubleBuilder _doubleBuilder){
            return _doubleBuilder.TypeRoom("Quarto Duplo")
                                 .ValueRoom(2000)
                                 .DescriptionRoom("Quarto para até duas pessoas!");
        }

        public IRoom Triple(TripleBuilder _tripleBuilder){
            return _tripleBuilder.TypeRoom("Quarto Triplo")
                                 .ValueRoom(2000)
                                 .DescriptionRoom("Quarto para até três pessoas!");
        }
    }
}