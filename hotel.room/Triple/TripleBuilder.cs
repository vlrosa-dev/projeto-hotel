namespace projeto_hotel.hotel.room.Triple
{
    public class TripleBuilder : IRoom
    {
        private TripleRoom _tripleRoom;

        public IRoom DescriptionRoom(string _descriptRoom)
        {
            _tripleRoom.DescriptionRoom = _descriptRoom;
            return this;
        }

        public IRoom TypeRoom(string _typeRoom)
        {
            _tripleRoom.TypeRoom = _typeRoom;
            return this;
        }

        public IRoom ValueRoom(decimal _valueRoom)
        {
            _tripleRoom.ValueRoom = _valueRoom;
            return this;
        }
 
        public TripleRoom Build()
        {
            return this._tripleRoom;
        }
    }
}