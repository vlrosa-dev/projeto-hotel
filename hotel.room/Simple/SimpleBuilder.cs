namespace projeto_hotel.hotel.room
{
    public class SimpleBuilder : IRoom
    {
        private SimpleRoom _simpleRoom;

        public SimpleBuilder()
        {
            _simpleRoom = new SimpleRoom();
        }

        public IRoom DescriptionRoom(string _descriptRoom)
        {
            _simpleRoom.DescriptionRoom = _descriptRoom;
            return this;
        }

        public IRoom TypeRoom(string _typeRoom)
        {
            _simpleRoom.TypeRoom = _typeRoom;
            return this;
        }

        public IRoom ValueRoom(decimal _valueRoom)
        {
            _simpleRoom.ValueRoom = _valueRoom;
            return this;
        }
 
        public SimpleRoom Build()
        {
            return this._simpleRoom;
        }

    }
}