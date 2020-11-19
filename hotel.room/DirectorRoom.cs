using System;
using projeto_hotel.hotel.room.Double;
using projeto_hotel.hotel.room.Triple;

namespace projeto_hotel.hotel.room
{
    public class DirectorRoom
    {
        private IRoom _room;

        public DirectorRoom(IRoom room)
        {
            _room = room;
        }

        public void Make(){
            
            var _TypeRoom = _room.GetType();
            
            if (_TypeRoom.Equals(typeof(SimpleBuilder)))
            {
                _room
                    .TypeRoom("Quarto Simples")
                    .ValueRoom(500)
                    .DescriptionRoom("Quarto para uma pessoa!");
            
            }else if (_TypeRoom.Equals(typeof(DoubleBuilder)))
            {
                _room
                    .TypeRoom("Quarto Duplo")
                    .ValueRoom(1000)
                    .DescriptionRoom("Quarto para até duas pessoas!");
            
            }else if (_TypeRoom.Equals(typeof(TripleBuilder)))
            {
                _room
                    .TypeRoom("Quarto Triplo")
                    .ValueRoom(1500)
                    .DescriptionRoom("Quarto para até três pessoas!");
            } 
        }

    }
}